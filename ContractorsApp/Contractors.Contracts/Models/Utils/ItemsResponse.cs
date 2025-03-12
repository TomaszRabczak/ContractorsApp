namespace Contractors.Contracts.Models.Utils
{
    public class ItemsResponse<T>
    {
        public IEnumerable<T> Items { get; private set; }
        public Pagination Pagination { get; private set; }

        public ItemsResponse(IEnumerable<T> items, int totalCount, Pagination pagination)
        {
            Items = items;
            Pagination = new Pagination
            {
                Total = totalCount,
                Page = pagination.Page,
                PerPage = pagination.PerPage,
            };
        }
    }
}
