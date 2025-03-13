using Contractors.Contracts.Interfaces;
using Contractors.Contracts.Models;
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

            return new ItemsResponse<ContractorViewModel>(mappedContractors, contractors.Pagination.Total, 
                request.Pagination);
        }

        public async Task<bool> SaveContractorAsync(ContractorViewModel contractor)
        {
            try
            {
                var contractorAddresses = contractor.Addresses.Select(x => ContractorAddress.Create(x.Id, x.Country,
                    x.City, x.PostalCode, x.StreetAndNumber));

                var mappedContractor = Contractor.Create(contractor.Id, contractor.Name, contractor.Nip,
                    contractor.Regon, contractorAddresses.ToList());

                await _contractorRepository.SaveContractorAsync(mappedContractor);

                return true;
            }
            catch (Exception ex)
            {
                // TODO log
                return false;
            }
        }

        public async Task<bool> DeleteContractors(IEnumerable<ContractorViewModel> contractors)
        {
            try
            {
                var mappedContractors = contractors.Select(x => new Contractor { Id = x.Id });
                await _contractorRepository.DeleteContractors(mappedContractors);

                return true;
            }
            catch (Exception ex)
            {
                // TODO log
                return false;
            }
        }
    }
}
