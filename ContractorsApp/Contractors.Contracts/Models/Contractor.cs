using System.ComponentModel.DataAnnotations;

namespace Contractors.Contracts.Models
{
    public class Contractor : AuditModel
    {
        [MaxLength(100)]
        public string Name { get; set; } = default!;
        [MaxLength(15)]
        public string Nip { get; set; } = default!;
        [MaxLength(15)]
        public string Regon { get; set; } = default!;
        public ICollection<ContractorAddress> Addresses { get; set; } = new List<ContractorAddress>();

        public Contractor() {}
        public Contractor(int id, string name, string nip, string regon, ICollection<ContractorAddress> addresses)
        {
            Id = id;
            Name = name;
            Nip = nip;
            Regon = regon;
            Addresses = addresses;
        }

        public static Contractor Create(int id, string name, string nip, string regon, 
            ICollection<ContractorAddress> addresses) => new Contractor(id, name, nip, regon, addresses);
    }
}
