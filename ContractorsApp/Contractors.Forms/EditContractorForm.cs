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
            if(!ValidateForm())
            {
                MessageBox.Show("Please enter valid data.");
                return;
            }

            var contractor = PrepareContractorToSave();
            await _contractorService.SaveContractorAsync(contractor);

            Close();
            await _gridContractorForm.SetDataGrid();
        }

        private ContractorViewModel PrepareContractorToSave()
        {
            int contractorId = _contractorViewModel != null ? _contractorViewModel.Id : 0;
            int addressId = _contractorViewModel != null ? _contractorViewModel.Addresses.First().Id : 0;

            var addresses = new List<ContractorAddress>
            {
                ContractorAddress.Create(addressId, textBoxCountry.Text, textBoxCity.Text, textBoxPostalCode.Text,
                    textBoxStreetAndNumber.Text)
            };

            return ContractorViewModel.Create(contractorId, textBoxName.Text, textBoxNip.Text, textBoxRegon.Text, addresses);
        }

        private void buttonClose_Click(object sender, EventArgs e) => Close();

        private void textBoxName_Validating(object sender, System.ComponentModel.CancelEventArgs e) 
            => ValidateTextBox(textBoxName, 100);

        private void textBoxRegon_Validating(object sender, System.ComponentModel.CancelEventArgs e)
            => ValidateTextBox(textBoxRegon, 15);

        private void textBoxNip_Validating(object sender, System.ComponentModel.CancelEventArgs e)
            => ValidateTextBox(textBoxNip, 15);

        private void textBoxCountry_Validated(object sender, EventArgs e)
            => ValidateTextBox(textBoxCountry, 50);

        private void textBoxCity_Validating(object sender, System.ComponentModel.CancelEventArgs e)
            => ValidateTextBox(textBoxCity, 50);

        private void textBoxStreetAndNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
            => ValidateTextBox(textBoxStreetAndNumber, 50);

        private void textBoxPostalCode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
            => ValidateTextBox(textBoxPostalCode, 50);

        private bool ValidateTextBox(TextBox textBox, int maxLenght)
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider1.SetError(textBox, "Required");
                isValid = false;
            }
            else if (textBox.Text.Length > maxLenght)
            {
                isValid = false;
                errorProvider1.SetError(textBox, $"Max length is {maxLenght}");
            }
            else
            {
                errorProvider1.SetError(textBox, "");
            }

            return isValid;
        }

        private bool ValidateForm()
        {
            bool nameValid = ValidateTextBox(textBoxName, 100);
            bool regonValid = ValidateTextBox(textBoxRegon, 15);
            bool nipValid = ValidateTextBox(textBoxNip, 15);
            bool countryValid = ValidateTextBox(textBoxCountry, 50);
            bool cityValid = ValidateTextBox(textBoxCity, 50);
            bool streetAndNumberValid = ValidateTextBox(textBoxStreetAndNumber, 50);
            bool postalCodeValid = ValidateTextBox(textBoxPostalCode, 50);

            return nameValid && regonValid && nipValid && countryValid && cityValid && streetAndNumberValid && 
                postalCodeValid;
        }
    }
}
