using Birlik.Shared.DTOs;
using Birlik.Shared.Enums;
using Dashboard.Shared;
using Dashboard.Trips.Services;
using DevExpress.XtraCharts.Design;
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
    public partial class AddTripForm : DevExpress.XtraEditors.XtraForm
    {
        public AddTripForm()
        {
            InitializeComponent();

            // Enum içindeki tüm değerleri dizi olarak alıp ComboBox'ın içine atıyoruz
            comboboxTripStatus.Properties.Items.AddRange(Enum.GetValues(typeof(TripStatus)));

            // İsteğe bağlı: İlk açılışta kutu boş gelmesin, ilk eleman seçili olsun
            comboboxTripStatus.SelectedIndex = 0;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        private async void CreateButtonClicked(object sender, EventArgs e)
        {
            // 2. DTO Hazırla
            var newTrip = new TripCreateDto()
            {
                CompanyId = GlobalState.Session.CompanyDto.Id,
                RouteId = Convert.ToInt32(txtRouteID.Text),
                VehicleId = Convert.ToInt32(txtVehicleID.Text),
                DriverId = Convert.ToInt32(txtDriverID.Text),
                DepartureTime = dateEditDeparture.DateTime.ToUniversalTime(),
                Capacity = Convert.ToInt32(txtCapacity.Text),
                PassengerNumbers = Convert.ToInt32(txtPassengerNumber.Text),
                TripStatus = (TripStatus) comboboxTripStatus.SelectedItem
            };

            // 3. API'ye Gönder (Animasyonla)
            var handle = SplashScreenManager.ShowOverlayForm(this);
            try
            {
                var service = new TripManagementApiService();
                await service.CreateTripAsync(newTrip);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Kayıt başarısız: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { SplashScreenManager.CloseOverlayForm(handle); }
        }

        private void DiscardButtonClicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}