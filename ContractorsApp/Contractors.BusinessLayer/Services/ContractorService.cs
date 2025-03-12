using Contractors.Contracts.Interfaces;
using Contractors.Contracts.Models.Requests;
using Contractors.Contracts.Models.Utils;
using Contractors.Contracts.Models.ViewModel;

namespace Contractors.BusinessLayer.Services
{
    public class ContractorService : IContractorService
    {
        private readonly IContractorRepository _contractorRepository;
        public ContractorService(IContractorRepository contractorRepository)
        {
            _contractorRepository = contractorRepository;
        }

        public async Task<ItemsResponse<ContractorViewModel>> GetContractorsAsync(GetContractorsRequest request)
        {
            var contractors = await _contractorRepository.GetContractorsAsync(request);

            var mappedContractors = contractors.Items
                .Select(x => ContractorViewModel.Create(x.Id, x.Name, x.Nip, x.Regon, x.Addresses)).ToList();

            return new ItemsResponse<ContractorViewModel>(mappedContractors, contractors.Pagination.Total, request.Pagination);
        }
    }
}
