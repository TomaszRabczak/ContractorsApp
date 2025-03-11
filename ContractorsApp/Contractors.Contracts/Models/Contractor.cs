using System.ComponentModel.DataAnnotations;

namespace Contractors.Contracts.Models
{
    public class Contractor : AuditModel
    {
        [MaxLength(100)]
        public string Name { get; set; } = default!;
        [StringLength(10)]
        public string Nip { get; set; } = default!;
        [StringLength(9)]
        public string Regon { get; set; } = default!;
        public ICollection<ContractorAddress> Addresses { get; set; } = new List<ContractorAddress>();
    }
}
