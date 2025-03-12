namespace Contractors.Contracts.Models.ViewModel
{
    public class ContractorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nip { get; set; }
        public string Regon {  get; set; }
        public string DisplayedAddress { get; set; }
        public ICollection<ContractorAddressViewModel> Addresses { get; set; }

        public ContractorViewModel(int id, string name, string nip, string regon, ICollection<ContractorAddress> addresses)
        {
            Id = id;
            Name = name;
            Nip = nip;
            Regon = regon;
            Addresses = addresses.Select(x => ContractorAddressViewModel.Create(x.Id, x.Country, x.City, x.PostalCode, 
                x.StreetAndNumber)).ToList();
            DisplayedAddress = FormatAddress(addresses.FirstOrDefault());
        }

        public static ContractorViewModel Create(int id, string name, string nip, string regon, 
            ICollection<ContractorAddress> addresses) => new ContractorViewModel(id, name, nip, regon, addresses);

        private string FormatAddress(ContractorAddress? address)
        {
            if(address == null)
                return string.Empty;

            return $"{address.StreetAndNumber}, {address.City} {address.PostalCode}";
        }
    }
}
