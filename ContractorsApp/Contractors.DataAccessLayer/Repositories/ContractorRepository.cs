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
            var items = await _dbContext.Contractors
                .Include(x => x.Addresses)
                .OrderByDescending(x => x.Id)
                .Skip((request.Pagination.Page - 1) * request.Pagination.PerPage)
                .Take(request.Pagination.PerPage)
                .ToListAsync();

            return new ItemsResponse<Contractor>(items, _dbContext.Contractors.Count(), request.Pagination);
        }
    }
}
