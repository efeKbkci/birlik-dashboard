using Dashboard.Shared.Interfaces;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace Dashboard
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private readonly Dictionary<string, Action> _viewRouter;

        public MainForm()
        {
            InitializeComponent();

            // 1. Sol paneli (AccordionControl) tasarım sistemindeki gibi tam 240px genişliğe mühürlüyoruz.
            // Hem normal genişliğini hem de açık haldeki sınırını 240px yapıyoruz.
            accordionControl1.Width = 340;
            accordionControl1.OptionsMinimizing.NormalWidth = 340;

            _viewRouter = new Dictionary<string, Action>
            {
                { "itemCompanyInfo", async () => await ShowPage<Company.UI.CompanyManagementViewHTML>() },
                { "itemTripManagement", async() => await ShowPage < Trips.UI.TripsManagementViewHTML >() },
                { "itemReservationManagement", async() => await ShowPage < Reservations.UI.ReservationManagementViewHTML >() },
                { "itemVehicleManagement" , async() => await ShowPage < Vehicles.UI.VehiclesManagementViewHTML >() },
                { "itemDriverManagement" , async() => await ShowPage < Drivers.UI.DriversManagementViewHTML >() },
                { "itemStopManagement" , async() => await ShowPage < Stops.UI.StopManagementViewHTML >() },
                // Yeni sayfalar geldikçe buraya tek satır olarak eklenecek
            };

            accordionControl1.ElementClick += AccordionControl1_ElementClick;

        }

        // Menüden herhangi bir sekmeye tıklandığında bu blok çalışır
        private void AccordionControl1_ElementClick(object sender, ElementClickEventArgs e)
        {
            if (_viewRouter.TryGetValue(e.Element.Name, out Action routeAction))
            {
                routeAction.Invoke();
            }
        }

        // Sadece istenilen sayfayı getirir. Zaten açıksa belleği yormaz, olanı öne çıkarır.
        private async Task ShowPage<T>() where T : XtraUserControl, new()
        {
            // Container içinde bu sayfadan zaten daha önce üretilmiş mi diye bakıyoruz
            var page = fluentDesignFormContainer1.Controls.OfType<T>().FirstOrDefault();

            if (page == null)
            {
                // Eğer ilk defa tıklanıyorsa, sayfanın bir kopyasını oluştur (Instance al)
                page = new T
                {
                    Dock = DockStyle.Fill // Container'ı tam kapla
                };

                // Container'ın içine sayfayı yerleştir
                fluentDesignFormContainer1.Controls.Add(page);
            }

            // Sayfayı en öne getir ve kullanıcıya göster
            page.BringToFront();

            // Eğer bu sayfa güncellenebilir bir sayfa ise verisini tazele.
            if (page is IRefreshable refreshablePage)
            {
                await refreshablePage.RefreshDataAsync();
            }
        }

        private void LogOutButtonClick(object sender, EventArgs e)
        {
            DialogResult yanit = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (yanit == DialogResult.Yes)
            {
                // Uygulamayı tamamen kapatıp, RAM'i temizleyip Login ekranından baştan başlatır.
                Application.Restart();
            }
        }
    }
}
