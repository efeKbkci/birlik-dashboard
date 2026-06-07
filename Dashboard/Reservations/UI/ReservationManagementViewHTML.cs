using Dashboard.Reservations.Interfaces;
using Dashboard.Reservations.Services;
using Dashboard.Shared;
using Dashboard.Shared.Interfaces;
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

namespace Dashboard.Reservations.UI
{
    public partial class ReservationManagementViewHTML : XtraUserControl, IRefreshable
    {
        private readonly IReservationManagementService _reservationService = new ReservationManagementApiService();

        public ReservationManagementViewHTML()
        {
            InitializeComponent();
        }

        public async Task RefreshDataAsync()
        {
            await LoadReservationManagementDataAsync();
        }

        private async Task LoadReservationManagementDataAsync()
        {
            IOverlaySplashScreenHandle handle = null;

            try
            {
                // 1. SADECE BU KONTROLÜN ÜZERİNİ KARART (MainForm kitlenmez!)
                handle = SplashScreenManager.ShowOverlayForm(this);

                // 2. Global State'ten Firma ID'sini al
                int currentCompanyId = GlobalState.Session.CompanyDto.Id;

                // 3. Veriyi Arka Planda Çek
                var pageData = await _reservationService.GetPageDataAsync(currentCompanyId);

                // 4. Verileri Ekrana Bağla
                if (pageData != null)
                {
                    htmlContentControl2.DataContext = new
                    {
                        Requires = pageData.RequiresApprovalCount,
                        Approved = pageData.ApprovedTodayCount,
                    };

                    // GridControl ataması devam ediyor...
                    reservationTable.DataSource = pageData.Reservations;
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
    }
}
