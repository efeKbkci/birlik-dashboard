using Birlik.Shared.DTOs.Page;
using Birlik.Shared.Enums;
using Dashboard.Drivers.Interfaces;
using Dashboard.Drivers.Services;
using Dashboard.Shared;
using Dashboard.Shared.Interfaces;
using Dashboard.Trips.UI;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.Drivers.UI
{
    public partial class DriversManagementViewHTML : DevExpress.XtraEditors.XtraUserControl, IRefreshable
    {
        private readonly IDriverManagementService _driverService = new DriverManagementApiService();

        public DriversManagementViewHTML()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            repositoryItemImageComboBox1.Items.AddEnum(typeof(DriverStatus));
        }

        public Task RefreshDataAsync()
        {
            return LoadDriverManagementDataAsync();
        }

        private async Task LoadDriverManagementDataAsync()
        {
            IOverlaySplashScreenHandle handle = null;

            try
            {
                // 1. SADECE BU KONTROLÜN ÜZERİNİ KARART (MainForm kitlenmez!)
                handle = SplashScreenManager.ShowOverlayForm(this);

                // 2. Global State'ten Firma ID'sini al
                int currentCompanyId = GlobalState.Session.CompanyDto.Id;

                // 3. Veriyi Arka Planda Çek
                var pageData = await _driverService.GetPageDataAsync(currentCompanyId);

                // 4. Verileri Ekrana Bağla
                if (pageData != null)
                {
                    htmlContentControl2.DataContext = new
                    {
                        TotalDrivers = pageData.TotalDrivers,
                        NotWorking = pageData.InActiveDriverCount,
                        OnTheRoad = pageData.VehiclesOnTheRoadCount
                    };

                    // GridControl ataması devam ediyor...
                    tripTable.DataSource = pageData.Drivers;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Sürücü verileri yüklenirken bir hata oluştu: {ex.Message}", "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // 5. KARARTMAYI KALDIR (Veri geldi, ekran aydınlandı)
                if (handle != null)
                {
                    SplashScreenManager.CloseOverlayForm(handle);
                }
            }
        }
        private async void AddDriverButtonClicked(object sender, EventArgs e)
        {
            // using bloğu, form kapandığında onu RAM'den tamamen temizler
            using var addForm = new AddDriverForm();

            DialogResult result = addForm.ShowDialog(this);

            // Form kapandıktan sonra kod buraya düşer ve sonucu kontrol ederiz:
            if (result == DialogResult.OK)
            {
                XtraMessageBox.Show("Test Başarılı! Ekleme ekranı kapandı ve 'Kaydet' seçildi.", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await RefreshDataAsync();
            }
            else if (result == DialogResult.Cancel)
            {
                XtraMessageBox.Show("Kullanıcı işlemi iptal etti veya pencereyi kapattı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void dataTableView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Status")
            {
                // Arka plandaki Value "1" veya "4" gibi bir sayıdır, onu Enum'a dönüştürüyoruz
                DriverStatus newStatus = (DriverStatus)e.Value;

                var changedRow = dataTableView.GetRow(e.RowHandle) as DriverListDto;

                if (changedRow != null)
                {
                    await _driverService.UpdateDriverStatusAsync(changedRow.Id, newStatus);
                }
            }
        }
    }
}
