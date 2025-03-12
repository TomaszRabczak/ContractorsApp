using System.ComponentModel.DataAnnotations;

namespace Contractors.Contracts.Models.ViewModel
{
    public class ContractorAddressViewModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Country { get; set; }
        [Required]
        [MaxLength(50)]
        public string City { get; set; }
        [Required]
        [MaxLength(10)]
        public string PostalCode { get; set; }
        [Required]
        [MaxLength(100)]
        public string StreetAndNumber { get; set; }

        public ContractorAddressViewModel(int id, string country, string city, string postalCode, string streetAndNumber)
        {
            Id = id;
            Country = country;
            City = city;
            PostalCode = postalCode;
            StreetAndNumber = streetAndNumber;
        }

        public static ContractorAddressViewModel Create(int id, string country, string city, string postalCode, string streetAndNumber)
        {
            return new ContractorAddressViewModel(id, country, city, postalCode, streetAndNumber);
        }
    }
}
