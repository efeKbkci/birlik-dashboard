using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using Dashboard.Shared;
using Dashboard.Stops.Interfaces;
using Dashboard.Stops.Services;
using Birlik.Shared.DTOs.Page;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dashboard.Shared.Interfaces;

namespace Dashboard.Stops.UI
{
    public partial class StopManagementViewHTML : DevExpress.XtraEditors.XtraUserControl, IRefreshable
    {
        private readonly IStopManagementService _stopService = new StopManagementApiService();

        public StopManagementViewHTML()
        {
            InitializeComponent();
        }

        public async Task RefreshDataAsync()
        {
            await LoadStopManagementDataAsync();
        }

        private void dataTable_Click(object sender, EventArgs e)
        {
            // Eğer panel zaten açıksa, geri kapatarak gizle
            if (flyoutPanel1.IsPopupOpen)
            {
                flyoutPanel1.HidePopup();
            }
            // Eğer panel kapalıysa, sağdan kaydırarak aç
            else
            {
                flyoutPanel1.ShowPopup();
            }
        }

        private async Task LoadStopManagementDataAsync()
        {
            IOverlaySplashScreenHandle handle = null;

            try
            {
                // 1. SADECE BU KONTROLÜN ÜZERİNİ KARART (MainForm kitlenmez!)
                handle = SplashScreenManager.ShowOverlayForm(this);

                // 2. Global State'ten Firma ID'sini al
                int currentCompanyId = GlobalState.Session.CompanyDto.Id;

                // 3. Veriyi Arka Planda Çek
                var pageData = await _stopService.GetPageDataAsync(currentCompanyId);

                // 4. Verileri Ekrana Bağla
                if (pageData != null)
                {
                    // Örnek: htmlContentControl benzeri bir kontrol yok ise label/text atamaları yapılmalı.
                    // Ancak grid kontrolümüz var, onu dolduralım.
                    stopTable.DataSource = pageData.Stops;
                    dataTableView.PopulateColumns();

                    if (dataTableView.Columns["Id"] != null) // Hata almamak için sütunun varlığını kontrol etmek iyi bir reflekstir
                    {
                        dataTableView.Columns["Id"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
                        dataTableView.Columns["Id"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Durak verileri yüklenirken bir hata oluştu: {ex.Message}", "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
