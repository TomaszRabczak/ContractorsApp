using Contractors.Contracts.Models.Utils;

namespace Contractors.Contracts.Models.Requests
{
    public class GetContractorsRequest
    {
        public Pagination Pagination { get; set; } = new Pagination();
    }
}
