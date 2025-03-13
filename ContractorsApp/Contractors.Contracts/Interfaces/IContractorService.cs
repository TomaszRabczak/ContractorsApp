using Contractors.Contracts.Models;
using Contractors.Contracts.Models.Requests;
using Contractors.Contracts.Models.Utils;
using Contractors.Contracts.Models.ViewModel;

namespace Contractors.Contracts.Interfaces
{
    public interface IContractorService
    {
        Task<ItemsResponse<ContractorViewModel>> GetContractorsAsync(GetContractorsRequest request);
        Task<bool> SaveContractorAsync(ContractorViewModel contractor);
        Task<bool> DeleteContractors(IEnumerable<ContractorViewModel> contractors);
    }
}
