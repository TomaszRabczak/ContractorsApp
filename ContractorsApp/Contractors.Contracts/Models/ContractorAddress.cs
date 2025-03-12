using System.ComponentModel.DataAnnotations;

namespace Contractors.Contracts.Models
{
    public class ContractorAddress
    {
        public int Id { get; set; }
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

        public ContractorAddress(int id, string country, string city, string postalCode, string streetAndNumber)
        {
            Id = id;
            Country = country;
            City = city;
            PostalCode = postalCode;
            StreetAndNumber = streetAndNumber;
        }

        public static ContractorAddress Create(int id, string country, string city, string postalCode, string streetAndNumber)
            => new ContractorAddress(id, country, city, postalCode, streetAndNumber);
    }
}
