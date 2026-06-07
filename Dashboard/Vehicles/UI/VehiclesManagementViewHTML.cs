using Dashboard.Shared.Interfaces;
using Dashboard.Vehicles.Interfaces;
using Dashboard.Vehicles.Services;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using Dashboard.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dashboard.Shared.Http;

namespace Dashboard.Vehicles.UI
{
    public partial class VehiclesManagementViewHTML : DevExpress.XtraEditors.XtraUserControl, IRefreshable
    {
        private readonly IVehicleManagementService _vehicleService = new VehicleManagementApiService();

        public VehiclesManagementViewHTML()
        {
            InitializeComponent();
        }

        public Task RefreshDataAsync()
        {
            return LoadVehicleManagementDataAsync();
        }

        private async Task LoadVehicleManagementDataAsync()
        {
            IOverlaySplashScreenHandle handle = null;

            try
            {
                handle = SplashScreenManager.ShowOverlayForm(this);

                int currentCompanyId = GlobalState.Session.CompanyDto.Id;

                var pageData = await _vehicleService.GetPageDataAsync(currentCompanyId);

                if (pageData != null)
                {
                    htmlContentControl2.DataContext = new
                    {
                        TotalFleet = pageData.TotalVehicles,
                        InMaintenance = pageData.MaintedVehicleCount,
                        OnTheRoad = pageData.VehiclesOnTheRoadCount
                    };

                    // Grid ataması (Varsa)
                    vehicleTable.DataSource = pageData.Vehicles;
                }
            }
            catch (ApiException ex)
            {
                XtraMessageBox.Show($"Araç verileri yüklenirken bir hata oluştu: {ex.Message}", "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (handle != null)
                {
                    SplashScreenManager.CloseOverlayForm(handle);
                }
            }
        }
    }
}
