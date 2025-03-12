using Contractors.Contracts.Models;
using Contractors.Contracts.Models.Requests;
using Contractors.Contracts.Models.Utils;

namespace Contractors.Contracts.Interfaces
{
    public interface IContractorRepository
    {
        Task<ItemsResponse<Contractor>> GetContractorsAsync(GetContractorsRequest request);
    }
}
