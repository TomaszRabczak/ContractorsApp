namespace Contractors.Contracts.Models.Filters
{
    public class GetContractorsFilters
    {
        public string? Name { get; set; }
        public string? Nip { get; set; }

        public IQueryable<Contractor> ApplyFilters(IQueryable<Contractor> query)
        {
            query = GetQueryBasedOnNameFilter(query);
            query = GetQueryBasedOnNipFilter(query);

            return query;
        }

        private IQueryable<Contractor> GetQueryBasedOnNameFilter(IQueryable<Contractor> query)
        {
            if (string.IsNullOrWhiteSpace(Name))
                return query;

            return query.Where(contractor => contractor.Name.Contains(Name));
        }

        private IQueryable<Contractor> GetQueryBasedOnNipFilter(IQueryable<Contractor> query)
        {
            if (string.IsNullOrWhiteSpace(Nip))
                return query;

            return query.Where(contractor => contractor.Nip.Contains(Nip));
        }
    }
}
