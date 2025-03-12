




namespace Contractors.Forms
{
    partial class GridContractorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contractorGridView = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            label1 = new Label();
            comboBoxPageSize = new ComboBox();
            btnPrev = new Button();
            btnNext = new Button();
            lblPageDescription = new Label();
            textBoxName = new TextBox();
            textBoxNip = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)contractorGridView).BeginInit();
            SuspendLayout();
            // 
            // contractorGridView
            // 
            contractorGridView.AllowUserToAddRows = false;
            contractorGridView.AllowUserToDeleteRows = false;
            contractorGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            contractorGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            contractorGridView.Location = new Point(28, 130);
            contractorGridView.MultiSelect = false;
            contractorGridView.Name = "contractorGridView";
            contractorGridView.ReadOnly = true;
            contractorGridView.RowHeadersWidth = 51;
            contractorGridView.Size = new Size(994, 368);
            contractorGridView.TabIndex = 0;
            contractorGridView.SelectionChanged += contractorGridView_SelectionChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(903, 71);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(119, 40);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(766, 71);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(119, 40);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(629, 71);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(119, 40);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 526);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 4;
            label1.Text = "Page size:";
            // 
            // comboBoxPageSize
            // 
            comboBoxPageSize.FormattingEnabled = true;
            comboBoxPageSize.Location = new Point(107, 523);
            comboBoxPageSize.Name = "comboBoxPageSize";
            comboBoxPageSize.Size = new Size(46, 28);
            comboBoxPageSize.TabIndex = 5;
            comboBoxPageSize.SelectionChangeCommitted += comboBoxPageSize_SelectionChangeCommitted;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(168, 522);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(31, 29);
            btnPrev.TabIndex = 6;
            btnPrev.Text = "<";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(316, 522);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(31, 29);
            btnNext.TabIndex = 7;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblPageDescription
            // 
            lblPageDescription.AutoSize = true;
            lblPageDescription.BorderStyle = BorderStyle.Fixed3D;
            lblPageDescription.Location = new Point(216, 526);
            lblPageDescription.Name = "lblPageDescription";
            lblPageDescription.Padding = new Padding(25, 0, 25, 0);
            lblPageDescription.Size = new Size(83, 22);
            lblPageDescription.TabIndex = 8;
            lblPageDescription.Text = "0/0";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(28, 32);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Name";
            textBoxName.Size = new Size(203, 27);
            textBoxName.TabIndex = 9;
            // 
            // textBoxNip
            // 
            textBoxNip.Location = new Point(28, 84);
            textBoxNip.Name = "textBoxNip";
            textBoxNip.PlaceholderText = "NIP";
            textBoxNip.Size = new Size(203, 27);
            textBoxNip.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(261, 52);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(119, 40);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // GridContractorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 572);
            Controls.Add(btnSearch);
            Controls.Add(textBoxNip);
            Controls.Add(textBoxName);
            Controls.Add(lblPageDescription);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(comboBoxPageSize);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(contractorGridView);
            Name = "GridContractorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contractors manager";
            Load += MainForm_Load_2;
            ((System.ComponentModel.ISupportInitialize)contractorGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView contractorGridView;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Label label1;
        private ComboBox comboBoxPageSize;
        private Button btnPrev;
        private Button btnNext;
        private Label lblPageDescription;
        private TextBox textBoxName;
        private TextBox textBoxNip;
        private Button btnSearch;
    }
}
