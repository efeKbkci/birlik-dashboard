using Birlik.Shared.DTOs.Page;
using Birlik.Shared.Enums;
using Dashboard.Shared;
using Dashboard.Shared.Interfaces;
using Dashboard.Trips.Services;
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

namespace Dashboard.Trips.UI
{
    public partial class TripsManagementViewHTML : XtraUserControl, IRefreshable
    {
        private readonly ITripManagementService _tripService = new TripManagementApiService();

        public TripsManagementViewHTML()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Arayüzde oluşturduğumuz editörün içini dinamik olarak Enum ile doldur
            repositoryItemImageComboBox1.Items.AddEnum(typeof(TripStatus));
        }

        public async Task RefreshDataAsync()
        {
            await LoadTripManagementDataAsync();
        }

        private async Task LoadTripManagementDataAsync()
        {
            IOverlaySplashScreenHandle handle = null;

            try
            {
                // 1. SADECE BU KONTROLÜN ÜZERİNİ KARART (MainForm kitlenmez!)
                handle = SplashScreenManager.ShowOverlayForm(this);

                // 2. Global State'ten Firma ID'sini al
                int currentCompanyId = GlobalState.Session.CompanyDto.Id;

                // 3. Veriyi Arka Planda Çek
                var pageData = await _tripService.GetPageDataAsync(currentCompanyId);

                // 4. Verileri Ekrana Bağla
                if (pageData != null)
                {
                    htmlContentControl2.DataContext = new
                    {
                        TodayTrips = pageData.TodayTotalTrips,
                        ActiveVehicles = pageData.ActiveVehiclesCount,
                        Driver = pageData.ActiveDriversCount
                    };

                    // GridControl ataması devam ediyor...
                    tripTable.DataSource = pageData.Trips;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Sefer verileri yüklenirken bir hata oluştu: {ex.Message}", "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private async void NewTripButtonClicked(object sender, EventArgs e)
        {
            // using bloğu, form kapandığında onu RAM'den tamamen temizler
            using var addForm = new AddTripForm();

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

        // UTC -> TR Zaman Dilimi Dönüşümü
        private void dataTableView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "DepartureTime" && e.Value is DateTime utcDate)
            {
                DateTime kesinUtc = DateTime.SpecifyKind(utcDate, DateTimeKind.Utc);
                TimeZoneInfo trZone = TimeZoneInfo.FindSystemTimeZoneById("Turkey Standard Time");
                DateTime localDate = TimeZoneInfo.ConvertTimeFromUtc(kesinUtc, trZone);

                e.DisplayText = localDate.ToString("dd.MM.yyyy HH:mm");
            }
        }

        private async void dataTableView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Status")
            {
                // Arka plandaki Value "1" veya "4" gibi bir sayıdır, onu Enum'a dönüştürüyoruz
                TripStatus newStatus = (TripStatus)e.Value;

                var changedRow = dataTableView.GetRow(e.RowHandle) as TripListDto;

                if (changedRow != null)
                {
                    await _tripService.UpdateTripStatusAsync(changedRow.Id, newStatus);
                }
            }
        }
    }
}
