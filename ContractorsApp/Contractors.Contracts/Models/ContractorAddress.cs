using System.ComponentModel.DataAnnotations;

namespace Contractors.Contracts.Models
{
    public class ContractorAddress : AuditModel
    {
        [MaxLength(50)]
        public string Country { get; set; } = default!;
        [MaxLength(50)]
        public string City { get; set; } = default!;
        [MaxLength(10)]
        public string PostalCode { get; set; } = default!;
        [MaxLength(100)]
        public string StreetAndNumber { get; set; } = default!;
        public Contractor Contractor { get; set; } = default!; 
        public int ContractorId { get; set; }
    }
}
