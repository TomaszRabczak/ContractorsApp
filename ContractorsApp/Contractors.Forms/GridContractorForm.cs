using Contractors.Contracts.Interfaces;
using Contractors.Contracts.Models.Requests;
using Contractors.Contracts.Models.ViewModel;

namespace Contractors.Forms
{
    public partial class GridContractorForm : Form
    {
        private readonly IContractorService _contractorService;

        private int _currentPage = 1;
        private int _defaultPageSize = 10;
        private int _totalItems;
        private List<int> _pageSizes = new List<int> { 5, 10 };

        public GridContractorForm(IContractorService contractorService)
        {
            _contractorService = contractorService;

            InitializeComponent();
        }

        private async void MainForm_Load_2(object sender, EventArgs e)
        {
            InitPageSizeComboBox();
            await FillGridWithData();
            SetPaginationInfo();
            SetGridColumnInfo();
        }

        private void contractorGridView_SelectionChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = contractorGridView.SelectedRows.Count == 1;
            btnEdit.Enabled = contractorGridView.SelectedRows.Count == 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var contractorToDelete = contractorGridView.SelectedRows[0].DataBoundItem as ContractorViewModel;
            if (contractorToDelete != null)
            {

            }
        }

        private async void comboBoxPageSize_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _currentPage = 1;
            await FillGridWithData();
            SetPaginationInfo();
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            _currentPage++;
            await FillGridWithData();
            SetPaginationInfo();
        }

        private async void btnPrev_Click(object sender, EventArgs e)
        {
            _currentPage--;
            await FillGridWithData();
            SetPaginationInfo();
        }

        private void InitPageSizeComboBox()
        {
            comboBoxPageSize.DataSource = _pageSizes;
            comboBoxPageSize.SelectedItem = _defaultPageSize;
        }

        private int GetItemsPerPage()
        {
            return comboBoxPageSize.SelectedValue != null ? (int)comboBoxPageSize.SelectedValue : _defaultPageSize;
        }

        private async Task FillGridWithData()
        {
            var request = new GetContractorsRequest
            {
                Pagination = new Contracts.Models.Utils.Pagination
                {
                    Page = _currentPage,
                    PerPage = GetItemsPerPage()
                },
                Filters = new Contracts.Models.Filters.GetContractorsFilters
                {
                    Name = textBoxName.Text,
                    Nip = textBoxNip.Text,
                }
            };
            var contractors = await _contractorService.GetContractorsAsync(request);
            _totalItems = contractors.Pagination.Total;
            contractorGridView.DataSource = contractors.Items;
        }

        private void SetPaginationInfo()
        {
            decimal totalPages = Math.Ceiling((decimal)_totalItems / GetItemsPerPage());
            decimal displayedTotalPages = totalPages == 0 ? 1 : totalPages;
            lblPageDescription.Text = $"{_currentPage}/{displayedTotalPages}";
            btnPrev.Enabled = _currentPage != 1;
            btnNext.Enabled = totalPages > 1 && _currentPage != totalPages;
        }

        private void SetGridColumnInfo()
        {
            contractorGridView.Columns["Id"].Visible = false;
            contractorGridView.Columns["Addresses"].Visible = false;
            contractorGridView.Columns["DisplayedAddress"].HeaderText = "Address";
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            _currentPage = 1;
            await FillGridWithData();
            SetPaginationInfo();
        }
    }
}
