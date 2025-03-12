namespace Contractors.Forms
{
    partial class EditContractorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxName = new TextBox();
            textBoxNip = new TextBox();
            textBoxRegon = new TextBox();
            textBoxCity = new TextBox();
            textBoxStreetAndNumber = new TextBox();
            textBoxPostalCode = new TextBox();
            buttonClose = new Button();
            btnSave = new Button();
            textBoxCountry = new TextBox();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 23);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Name";
            textBoxName.Size = new Size(213, 27);
            textBoxName.TabIndex = 0;
            // 
            // textBoxNip
            // 
            textBoxNip.Location = new Point(294, 23);
            textBoxNip.Name = "textBoxNip";
            textBoxNip.PlaceholderText = "NIP";
            textBoxNip.Size = new Size(213, 27);
            textBoxNip.TabIndex = 1;
            // 
            // textBoxRegon
            // 
            textBoxRegon.Location = new Point(575, 23);
            textBoxRegon.Name = "textBoxRegon";
            textBoxRegon.PlaceholderText = "REGON";
            textBoxRegon.Size = new Size(213, 27);
            textBoxRegon.TabIndex = 2;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(294, 80);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.PlaceholderText = "City";
            textBoxCity.Size = new Size(213, 27);
            textBoxCity.TabIndex = 4;
            // 
            // textBoxStreetAndNumber
            // 
            textBoxStreetAndNumber.Location = new Point(575, 80);
            textBoxStreetAndNumber.Name = "textBoxStreetAndNumber";
            textBoxStreetAndNumber.PlaceholderText = "Street and number";
            textBoxStreetAndNumber.Size = new Size(213, 27);
            textBoxStreetAndNumber.TabIndex = 5;
            // 
            // textBoxPostalCode
            // 
            textBoxPostalCode.Location = new Point(12, 140);
            textBoxPostalCode.Name = "textBoxPostalCode";
            textBoxPostalCode.PlaceholderText = "Postal code";
            textBoxPostalCode.Size = new Size(213, 27);
            textBoxPostalCode.TabIndex = 6;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(12, 234);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(120, 53);
            buttonClose.TabIndex = 7;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(668, 234);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 53);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(12, 80);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.PlaceholderText = "Country";
            textBoxCountry.Size = new Size(213, 27);
            textBoxCountry.TabIndex = 9;
            // 
            // EditContractorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 297);
            Controls.Add(textBoxCountry);
            Controls.Add(btnSave);
            Controls.Add(buttonClose);
            Controls.Add(textBoxPostalCode);
            Controls.Add(textBoxStreetAndNumber);
            Controls.Add(textBoxCity);
            Controls.Add(textBoxRegon);
            Controls.Add(textBoxNip);
            Controls.Add(textBoxName);
            Name = "EditContractorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditContractorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxNip;
        private TextBox textBoxRegon;
        private TextBox textBoxCountry;
        private TextBox textBoxCity;
        private TextBox textBoxStreetAndNumber;
        private TextBox textBoxPostalCode;
        private ComboBox comboBoxCountry;
        private Button buttonClose;
        private Button btnSave;
    }
}