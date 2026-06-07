using Dashboard.Login.Core;
using Dashboard.Login.Interfaces;
using Birlik.Shared.DTOs;
using Dashboard.Shared.Constants;
using Dashboard.Shared.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ApiException = Dashboard.Shared.Http.ApiException;

namespace Dashboard.Login.Services
{
    public class AuthApiService : IAuthService
    {
        private readonly ApiClient _apiClient = new ApiClient(ApiEndpoints.BaseUrl);

        public async Task<(bool IsSuccess, string ErrorMessage, UserSession UserSession)> LoginAsync(string emailOrPhone, string password)
        {
            try
            {
                var payload = new { EmailOrPhone = emailOrPhone, Password = password };

                var endpoint = ApiEndpoints.Admins.Login();

                var companyDto = await _apiClient.PostAsync<object, DetailedCompanyReadDto>(endpoint, payload);

                var userSession = new UserSession() { CompanyDto = companyDto };

                return (true, string.Empty, userSession);
            }
            // İş Kuralı Hataları (Yanlış şifre, bulunamayan kullanıcı vb.)
            catch (ApiException apiEx)
            {
                if (apiEx.StatusCode == HttpStatusCode.Unauthorized)
                {
                    return (false, "Geçersiz e-posta/telefon numarası veya şifre.", null);
                }

                // Diğer API hataları (400, 409 vb.)
                return (false, apiEx.Message, null);
            }
            // Ağ/İnternet Hataları (Sunucu kapalıysa, timeout vs.)
            catch (Exception ex)
            {
                return (false, $"Sunucuya ulaşılamıyor. Lütfen internet bağlantınızı kontrol edin. Detay: {ex.Message}", null);
            }
        }
    }
}
