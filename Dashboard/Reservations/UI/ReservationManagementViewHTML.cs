using Birlik.Shared.DTOs.Page;
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

                    // 1. Tablonun genel olarak düzenlenebilir olduğundan emin olalım
                    dataTableView.OptionsBehavior.Editable = true;

                    // 2. İşlemler sütununun adını tasarımda ne koyduysan onu çağır (Örn: "colActions")
                    if (dataTableView.Columns["colActions"] != null)
                    {
                        dataTableView.Columns["colActions"].OptionsColumn.AllowEdit = true;  // Tıklamaya izin ver
                        dataTableView.Columns["colActions"].OptionsColumn.ReadOnly = false; // Salt okunurluğu kapat
                    }
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

        private async void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            // 1. Tıklanan satırdaki rezervasyon verisini (DTO) yakala
            var clickedReservation = dataTableView.GetFocusedRow() as ReservationListDto;

            if (clickedReservation == null) return;

            // 2. Hangi butona tıklandığını Tag özelliğinden anla (Confirm mi, Cancel mı?)
            string action = e.Button.Tag?.ToString();

            if (action == "Confirm")
            {
                DialogResult dialogResult = XtraMessageBox.Show($"{clickedReservation.PassengerName} adlı kişinin rezervasyonunu onaylamak istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    await _reservationService.ConfirmReservation(clickedReservation.Id);
                    await LoadReservationManagementDataAsync();
                    XtraMessageBox.Show("Rezervasyon Onaylandı!");
                }
            }
            else if (action == "Cancel")
            {
                // Reddetme işlemi
                DialogResult dialogResult = XtraMessageBox.Show($"{clickedReservation.PassengerName} adlı kişinin rezervasyonunu REDDETMEK istiyor musunuz?", "Reddet", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    await _reservationService.CancelReservation(clickedReservation.Id);
                    await LoadReservationManagementDataAsync();
                    XtraMessageBox.Show("Rezervasyon Reddedildi!");
                }
            }
        }

        // UTC -> TR Zaman Dilimi Dönüşümü
        private void dataTableView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "TripDepartureTime" && e.Value is DateTime utcDate)
            {
                DateTime kesinUtc = DateTime.SpecifyKind(utcDate, DateTimeKind.Utc);
                TimeZoneInfo trZone = TimeZoneInfo.FindSystemTimeZoneById("Turkey Standard Time");
                DateTime localDate = TimeZoneInfo.ConvertTimeFromUtc(kesinUtc, trZone);

                e.DisplayText = localDate.ToString("dd.MM.yyyy HH:mm");
            }
        }
    }
}
