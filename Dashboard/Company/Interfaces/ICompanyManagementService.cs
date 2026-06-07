using Birlik.Shared.DTOs;
using Birlik.Shared.DTOs.Page;
using System.Threading.Tasks;

namespace Dashboard.Company.Interfaces
{
    public interface ICompanyManagementService
    {
        Task<CompanyManagementPageDto> GetPageDataAsync(int companyId);
        Task UpdatePageDataAsync(int companyId, CompanyPatchDto patchDto);
    }
}