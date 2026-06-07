using Birlik.Shared.DTOs;
using Birlik.Shared.DTOs.Page;
using Dashboard.Company.Interfaces;
using Dashboard.Shared.Constants;
using Dashboard.Shared.Http;
using System.Threading.Tasks;

namespace Dashboard.Company.Services
{
    public class CompanyManagementApiService : ICompanyManagementService
    {
        private readonly ApiClient _apiClient = new(ApiEndpoints.BaseUrl);

        public async Task<CompanyManagementPageDto> GetPageDataAsync(int companyId)
        {
            string endpoint = ApiEndpoints.Companies.GetCompanyManagementPage(companyId);
            return await _apiClient.GetAsync<CompanyManagementPageDto>(endpoint);
        }

        public async Task UpdatePageDataAsync(int companyId, CompanyPatchDto patchDto)
        {
            string endpoint = ApiEndpoints.Companies.Patch(companyId);
            await _apiClient.PatchAsync<CompanyPatchDto>(endpoint, patchDto);
        }
    }
}