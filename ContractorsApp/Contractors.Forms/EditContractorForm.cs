using Contractors.Contracts.Interfaces;
using Contractors.Contracts.Models;
using Contractors.Contracts.Models.ViewModel;

namespace Contractors.Forms
{
    public partial class EditContractorForm : Form
    {
        private GridContractorForm _gridContractorForm;
        private ContractorViewModel? _contractorViewModel;
        private readonly IContractorService _contractorService;
        public EditContractorForm(GridContractorForm gridContractorForm, IContractorService contractorService,
            ContractorViewModel? contractorViewModel)
        {
            _gridContractorForm = gridContractorForm;
            _contractorViewModel = contractorViewModel;
            _contractorService = contractorService;

            InitializeComponent();
            InitializeContractorData();
        }

        private void InitializeContractorData()
        {
            if (_contractorViewModel != null)
            {
                textBoxName.Text = _contractorViewModel.Name;
                textBoxNip.Text = _contractorViewModel.Nip;
                textBoxRegon.Text = _contractorViewModel.Regon;
                textBoxCountry.Text = _contractorViewModel.Addresses.FirstOrDefault()?.Country;
                textBoxCity.Text = _contractorViewModel.Addresses.FirstOrDefault()?.City;
                textBoxStreetAndNumber.Text = _contractorViewModel.Addresses.FirstOrDefault()?.StreetAndNumber;
                textBoxPostalCode.Text = _contractorViewModel.Addresses.FirstOrDefault()?.PostalCode;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            int contractorId = _contractorViewModel != null ? _contractorViewModel.Id : 0;
            int addressId = _contractorViewModel != null ? _contractorViewModel.Addresses.First().Id : 0;

            var addresses = new List<ContractorAddress>
            {
                ContractorAddress.Create(addressId, textBoxCountry.Text, textBoxCity.Text, textBoxPostalCode.Text,
                    textBoxStreetAndNumber.Text)
            };

            var contractor = ContractorViewModel.Create(contractorId, textBoxName.Text, textBoxNip.Text, textBoxRegon.Text, addresses);

            await _contractorService.SaveContractorAsync(contractor);

            Close();
            await _gridContractorForm.SetDataGrid();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
