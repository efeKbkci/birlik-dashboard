using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Shared.Constants
{
    public static class ApiEndpoints
    {
        private const int _dockerPort = 8080;
        private const int _vsPort = 5000;

        public static readonly string BaseUrl = $"http://localhost:{_vsPort}/";

        public static class Admins
        {
            public const string Base = "api/admins";
            public static string GetById(int id) => $"{Base}/{id}";
            public static string Create() => $"{Base}";
            public static string Login() => $"{Base}/login-preview";
        }

        public static class Trips
        {
            public const string Base = "api/trips";
            public static string GetById(int id) => $"{Base}/{id}";
            public static string Patch(int id) => $"{Base}/{id}";
            public static string GetTripManagementPage(int companyId) => $"{Base}/company/{companyId}/management-page";
            public static string Create() => $"{Base}";

            // Filtreleme endpoint'leri henüz eklenmedi
        }

        public static class Reservations
        {
            public const string Base = "api/reservations";
            public static string GetById(int id) => $"{Base}/{id}";
            public static string Patch(int id) => $"{Base}/{id}";
            public static string GetReservationManagementPage(int companyId) => $"{Base}/company/{companyId}/management-page";
            public static string Create() => $"{Base}";
        }

        public static class Companies
        {
            public const string Base = "api/companies";
            public static string GetById(int id) => $"{Base}/{id}";
            public static string Patch(int id) => $"{Base}/{id}";
            public static string Create() => $"{Base}";
            public static string GetCompanyManagementPage(int companyId) => $"{Base}/{companyId}/management-page";
        }

        public static class Stops
        {
            public const string Base = "api/stops";
            public static string GetById(int id) => $"{Base}/{id}";
            public static string Patch(int id) => $"{Base}/{id}";
            public static string GetStopManagementPage(int companyId) => $"{Base}/company/{companyId}/management-page";
            public static string Create() => $"{Base}";
        }

        public static class Vehicles
        {
            public const string Base = "api/vehicles";
            public static string GetById(int id) => $"{Base}/{id}";
            public static string Patch(int id) => $"{Base}/{id}";
            public static string GetVehicleManagementPage(int companyId) => $"{Base}/company/{companyId}/management-page";
            public static string Create() => $"{Base}";
        }

        public static class Drivers
        {
            public const string Base = "api/drivers";
            public static string GetById(int id) => $"{Base}/{id}";
            public static string Patch(int id) => $"{Base}/{id}";
            public static string GetDriverManagementPage(int companyId) => $"{Base}/company/{companyId}/management-page";
            public static string Create() => $"{Base}";
        }

        // İlerleyen aşamalarda diğer varlıklar buraya eklenecek
    }
}
