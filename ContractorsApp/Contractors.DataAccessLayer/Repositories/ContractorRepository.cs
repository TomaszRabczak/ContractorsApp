using Contractors.Contracts.Interfaces;
using Contractors.Contracts.Models;
using Contractors.Contracts.Models.Requests;
using Contractors.Contracts.Models.Utils;
using Contractors.DatabaseCore;
using Microsoft.EntityFrameworkCore;

namespace Contractors.DataAccessLayer.Repositories
{
    public class ContractorRepository : IContractorRepository
    {
        private readonly ContractorsDbContext _dbContext;
        public ContractorRepository(ContractorsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ItemsResponse<Contractor>> GetContractorsAsync(GetContractorsRequest request)
        {
            var query = _dbContext.Contractors.Include(x => x.Addresses);
            var filteredItems = request.Filters.ApplyFilters(query);

            var items = await filteredItems
                .AsNoTracking()
                .OrderByDescending(x => x.Id)
                .Skip((request.Pagination.Page - 1) * request.Pagination.PerPage)
                .Take(request.Pagination.PerPage)
                .ToListAsync();

            return new ItemsResponse<Contractor>(items, filteredItems.Count(), request.Pagination);
        }

        public async Task SaveContractorAsync(Contractor contractor)
        {
            var updatedContractor = await _dbContext.Contractors.FirstOrDefaultAsync(x => x.Id == contractor.Id);
            if(updatedContractor != null)
            {
                updatedContractor.Name = contractor.Name;
                updatedContractor.Nip = contractor.Nip;
                updatedContractor.Regon = contractor.Regon;
                updatedContractor.Addresses = contractor.Addresses;
            }
            else
            {
                await _dbContext.Contractors.AddAsync(contractor);
            }
            
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteContractors(IEnumerable<Contractor> contractors)
        {
            var ids = contractors.Select(x => x.Id).ToList();
            await _dbContext.Contractors.Where(x => ids.Contains(x.Id)).ExecuteDeleteAsync();
            await _dbContext.SaveChangesAsync();
        }
    }
}
