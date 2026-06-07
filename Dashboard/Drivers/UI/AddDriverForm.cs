using Birlik.Shared.DTOs;
using Birlik.Shared.Enums;
using Dashboard.Drivers.Services;
using Dashboard.Shared;
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

namespace Dashboard.Drivers.UI
{
    public partial class AddDriverForm : DevExpress.XtraEditors.XtraForm
    {
        public AddDriverForm()
        {
            InitializeComponent();

            // Enum içindeki tüm değerleri dizi olarak alıp ComboBox'ın içine atıyoruz
            comboboxDriverStatus.Properties.Items.AddRange(Enum.GetValues(typeof(DriverStatus)));

            // İsteğe bağlı: İlk açılışta kutu boş gelmesin, ilk eleman seçili olsun
            comboboxDriverStatus.SelectedIndex = 0;
        }

        private async void CreateButtonClicked(object sender, EventArgs e)
        {
            // 2. DTO Hazırla
            var newDriver = new DriverCreateDto()
            {
                CompanyId = GlobalState.Session.CompanyDto.Id,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Status = (DriverStatus) comboboxDriverStatus.SelectedItem
            };

            // 3. API'ye Gönder (Animasyonla)
            var handle = SplashScreenManager.ShowOverlayForm(this);
            try
            {
                var service = new DriverManagementApiService();
                await service.CreateDriver(newDriver);
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