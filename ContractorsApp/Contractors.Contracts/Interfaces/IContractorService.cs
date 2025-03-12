using Contractors.Contracts.Models.Requests;
using Contractors.Contracts.Models.Utils;
using Contractors.Contracts.Models.ViewModel;

namespace Contractors.Contracts.Interfaces
{
    public interface IContractorService
    {
        Task<ItemsResponse<ContractorViewModel>> GetContractorsAsync(GetContractorsRequest request);
    }
}
