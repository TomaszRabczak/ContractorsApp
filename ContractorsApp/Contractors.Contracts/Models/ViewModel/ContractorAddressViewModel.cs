namespace Contractors.Contracts.Models.ViewModel
{
    public class ContractorAddressViewModel
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
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
            => new ContractorAddressViewModel(id, country, city, postalCode, streetAndNumber);
    }
}
