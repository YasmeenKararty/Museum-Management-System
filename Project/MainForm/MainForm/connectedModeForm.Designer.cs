namespace MainForm
{
    partial class connectedModeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.sectionsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.visitorNameTextBox = new System.Windows.Forms.TextBox();
            this.buyTicketButton = new System.Windows.Forms.Button();
            this.searchByExhibitLabel = new System.Windows.Forms.Label();
            this.searchByExhibitComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.arrivalDateTextBox = new System.Windows.Forms.TextBox();
            this.materialTextBox = new System.Windows.Forms.TextBox();
            this.historicalPeriodTextBox = new System.Windows.Forms.TextBox();
            this.countryOfFoundationTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.exhibitDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numberOfTicketsTextBox = new System.Windows.Forms.TextBox();
            this.numberOfTicketsLabel = new System.Windows.Forms.Label();
            this.anotherVisitorButton = new System.Windows.Forms.Button();
            this.dateOfVisitPicker = new System.Windows.Forms.DateTimePicker();
            this.searchChoices = new System.Windows.Forms.GroupBox();
            this.searchByExhibtRadioButton = new System.Windows.Forms.RadioButton();
            this.searchBySectionRadioButton = new System.Windows.Forms.RadioButton();
            this.backToMainMenuButton = new System.Windows.Forms.Button();
            this.exhibitDetailsGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.searchChoices.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Section";
            // 
            // sectionsComboBox
            // 
            this.sectionsComboBox.Enabled = false;
            this.sectionsComboBox.FormattingEnabled = true;
            this.sectionsComboBox.Location = new System.Drawing.Point(148, 66);
            this.sectionsComboBox.Name = "sectionsComboBox";
            this.sectionsComboBox.Size = new System.Drawing.Size(121, 24);
            this.sectionsComboBox.TabIndex = 1;
            this.sectionsComboBox.SelectedIndexChanged += new System.EventHandler(this.sectionsComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Enabled = false;
            this.priceTextBox.Location = new System.Drawing.Point(148, 137);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(121, 22);
            this.priceTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter your Name";
            // 
            // visitorNameTextBox
            // 
            this.visitorNameTextBox.Location = new System.Drawing.Point(145, 29);
            this.visitorNameTextBox.Name = "visitorNameTextBox";
            this.visitorNameTextBox.Size = new System.Drawing.Size(165, 22);
            this.visitorNameTextBox.TabIndex = 5;
            this.visitorNameTextBox.TextChanged += new System.EventHandler(this.visitorNameTextBox_TextChanged);
            this.visitorNameTextBox.Leave += new System.EventHandler(this.visitorNameTextBox_Leave);
            // 
            // buyTicketButton
            // 
            this.buyTicketButton.Location = new System.Drawing.Point(76, 372);
            this.buyTicketButton.Name = "buyTicketButton";
            this.buyTicketButton.Size = new System.Drawing.Size(132, 40);
            this.buyTicketButton.TabIndex = 6;
            this.buyTicketButton.Text = "Buy Ticket";
            this.buyTicketButton.UseVisualStyleBackColor = true;
            this.buyTicketButton.Click += new System.EventHandler(this.buyTicketButton_Click);
            // 
            // searchByExhibitLabel
            // 
            this.searchByExhibitLabel.AutoSize = true;
            this.searchByExhibitLabel.Location = new System.Drawing.Point(647, 73);
            this.searchByExhibitLabel.Name = "searchByExhibitLabel";
            this.searchByExhibitLabel.Size = new System.Drawing.Size(115, 17);
            this.searchByExhibitLabel.TabIndex = 7;
            this.searchByExhibitLabel.Text = "Search By Exhibt";
            // 
            // searchByExhibitComboBox
            // 
            this.searchByExhibitComboBox.Enabled = false;
            this.searchByExhibitComboBox.FormattingEnabled = true;
            this.searchByExhibitComboBox.Location = new System.Drawing.Point(828, 70);
            this.searchByExhibitComboBox.Name = "searchByExhibitComboBox";
            this.searchByExhibitComboBox.Size = new System.Drawing.Size(121, 24);
            this.searchByExhibitComboBox.TabIndex = 8;
            this.searchByExhibitComboBox.SelectedIndexChanged += new System.EventHandler(this.searchByExhibitComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Arrival Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Material";
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(208, 34);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(132, 22);
            this.typeTextBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Historical Period";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Country Of Foundation";
            // 
            // arrivalDateTextBox
            // 
            this.arrivalDateTextBox.Location = new System.Drawing.Point(208, 80);
            this.arrivalDateTextBox.Name = "arrivalDateTextBox";
            this.arrivalDateTextBox.Size = new System.Drawing.Size(132, 22);
            this.arrivalDateTextBox.TabIndex = 15;
            // 
            // materialTextBox
            // 
            this.materialTextBox.Location = new System.Drawing.Point(208, 127);
            this.materialTextBox.Name = "materialTextBox";
            this.materialTextBox.Size = new System.Drawing.Size(132, 22);
            this.materialTextBox.TabIndex = 16;
            // 
            // historicalPeriodTextBox
            // 
            this.historicalPeriodTextBox.Location = new System.Drawing.Point(208, 168);
            this.historicalPeriodTextBox.Name = "historicalPeriodTextBox";
            this.historicalPeriodTextBox.Size = new System.Drawing.Size(132, 22);
            this.historicalPeriodTextBox.TabIndex = 17;
            // 
            // countryOfFoundationTextBox
            // 
            this.countryOfFoundationTextBox.Location = new System.Drawing.Point(208, 211);
            this.countryOfFoundationTextBox.Name = "countryOfFoundationTextBox";
            this.countryOfFoundationTextBox.Size = new System.Drawing.Size(132, 22);
            this.countryOfFoundationTextBox.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Date";
            // 
            // exhibitDetailsGroupBox
            // 
            this.exhibitDetailsGroupBox.Controls.Add(this.arrivalDateTextBox);
            this.exhibitDetailsGroupBox.Controls.Add(this.label5);
            this.exhibitDetailsGroupBox.Controls.Add(this.typeTextBox);
            this.exhibitDetailsGroupBox.Controls.Add(this.countryOfFoundationTextBox);
            this.exhibitDetailsGroupBox.Controls.Add(this.label6);
            this.exhibitDetailsGroupBox.Controls.Add(this.label9);
            this.exhibitDetailsGroupBox.Controls.Add(this.historicalPeriodTextBox);
            this.exhibitDetailsGroupBox.Controls.Add(this.label7);
            this.exhibitDetailsGroupBox.Controls.Add(this.materialTextBox);
            this.exhibitDetailsGroupBox.Controls.Add(this.label8);
            this.exhibitDetailsGroupBox.Location = new System.Drawing.Point(576, 168);
            this.exhibitDetailsGroupBox.Name = "exhibitDetailsGroupBox";
            this.exhibitDetailsGroupBox.Size = new System.Drawing.Size(404, 253);
            this.exhibitDetailsGroupBox.TabIndex = 21;
            this.exhibitDetailsGroupBox.TabStop = false;
            this.exhibitDetailsGroupBox.Text = "Exhibit Details";
            this.exhibitDetailsGroupBox.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numberOfTicketsTextBox);
            this.groupBox2.Controls.Add(this.numberOfTicketsLabel);
            this.groupBox2.Controls.Add(this.anotherVisitorButton);
            this.groupBox2.Controls.Add(this.dateOfVisitPicker);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.visitorNameTextBox);
            this.groupBox2.Location = new System.Drawing.Point(26, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 172);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visitor Data";
            // 
            // numberOfTicketsTextBox
            // 
            this.numberOfTicketsTextBox.Location = new System.Drawing.Point(187, 127);
            this.numberOfTicketsTextBox.Name = "numberOfTicketsTextBox";
            this.numberOfTicketsTextBox.Size = new System.Drawing.Size(69, 22);
            this.numberOfTicketsTextBox.TabIndex = 24;
            // 
            // numberOfTicketsLabel
            // 
            this.numberOfTicketsLabel.AutoSize = true;
            this.numberOfTicketsLabel.Location = new System.Drawing.Point(24, 127);
            this.numberOfTicketsLabel.Name = "numberOfTicketsLabel";
            this.numberOfTicketsLabel.Size = new System.Drawing.Size(126, 17);
            this.numberOfTicketsLabel.TabIndex = 23;
            this.numberOfTicketsLabel.Text = "Number Of Tickets";
            // 
            // anotherVisitorButton
            // 
            this.anotherVisitorButton.Enabled = false;
            this.anotherVisitorButton.Location = new System.Drawing.Point(366, 29);
            this.anotherVisitorButton.Name = "anotherVisitorButton";
            this.anotherVisitorButton.Size = new System.Drawing.Size(114, 30);
            this.anotherVisitorButton.TabIndex = 22;
            this.anotherVisitorButton.Text = "Another Visitor";
            this.anotherVisitorButton.UseVisualStyleBackColor = true;
            this.anotherVisitorButton.Click += new System.EventHandler(this.anotherVisitorButton_Click);
            // 
            // dateOfVisitPicker
            // 
            this.dateOfVisitPicker.Location = new System.Drawing.Point(122, 78);
            this.dateOfVisitPicker.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateOfVisitPicker.MinDate = new System.DateTime(2021, 6, 10, 13, 59, 46, 0);
            this.dateOfVisitPicker.Name = "dateOfVisitPicker";
            this.dateOfVisitPicker.Size = new System.Drawing.Size(200, 22);
            this.dateOfVisitPicker.TabIndex = 21;
            this.dateOfVisitPicker.Value = new System.DateTime(2021, 6, 10, 13, 59, 46, 0);
            // 
            // searchChoices
            // 
            this.searchChoices.Controls.Add(this.searchByExhibtRadioButton);
            this.searchChoices.Controls.Add(this.searchBySectionRadioButton);
            this.searchChoices.Location = new System.Drawing.Point(373, 35);
            this.searchChoices.Name = "searchChoices";
            this.searchChoices.Size = new System.Drawing.Size(200, 100);
            this.searchChoices.TabIndex = 23;
            this.searchChoices.TabStop = false;
            // 
            // searchByExhibtRadioButton
            // 
            this.searchByExhibtRadioButton.AutoSize = true;
            this.searchByExhibtRadioButton.Location = new System.Drawing.Point(37, 62);
            this.searchByExhibtRadioButton.Name = "searchByExhibtRadioButton";
            this.searchByExhibtRadioButton.Size = new System.Drawing.Size(136, 21);
            this.searchByExhibtRadioButton.TabIndex = 1;
            this.searchByExhibtRadioButton.TabStop = true;
            this.searchByExhibtRadioButton.Text = "Search By Exhibt";
            this.searchByExhibtRadioButton.UseVisualStyleBackColor = true;
            this.searchByExhibtRadioButton.CheckedChanged += new System.EventHandler(this.searchByExhibtRadioButton_CheckedChanged);
            // 
            // searchBySectionRadioButton
            // 
            this.searchBySectionRadioButton.AutoSize = true;
            this.searchBySectionRadioButton.Location = new System.Drawing.Point(37, 35);
            this.searchBySectionRadioButton.Name = "searchBySectionRadioButton";
            this.searchBySectionRadioButton.Size = new System.Drawing.Size(145, 21);
            this.searchBySectionRadioButton.TabIndex = 0;
            this.searchBySectionRadioButton.TabStop = true;
            this.searchBySectionRadioButton.Text = "Search By Section";
            this.searchBySectionRadioButton.UseVisualStyleBackColor = true;
            this.searchBySectionRadioButton.CheckedChanged += new System.EventHandler(this.searchBySectionRadioButton_CheckedChanged);
            // 
            // backToMainMenuButton
            // 
            this.backToMainMenuButton.Location = new System.Drawing.Point(26, 12);
            this.backToMainMenuButton.Name = "backToMainMenuButton";
            this.backToMainMenuButton.Size = new System.Drawing.Size(165, 30);
            this.backToMainMenuButton.TabIndex = 24;
            this.backToMainMenuButton.Text = "Back To Main Menu";
            this.backToMainMenuButton.UseVisualStyleBackColor = true;
            this.backToMainMenuButton.Click += new System.EventHandler(this.backToMainMenuButton_Click);
            // 
            // connectedModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 451);
            this.Controls.Add(this.backToMainMenuButton);
            this.Controls.Add(this.searchChoices);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.exhibitDetailsGroupBox);
            this.Controls.Add(this.searchByExhibitComboBox);
            this.Controls.Add(this.searchByExhibitLabel);
            this.Controls.Add(this.buyTicketButton);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sectionsComboBox);
            this.Controls.Add(this.label1);
            this.Name = "connectedModeForm";
            this.Text = "connectedModeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.connectedModeForm_FormClosing);
            this.Load += new System.EventHandler(this.connectedModeForm_Load);
            this.exhibitDetailsGroupBox.ResumeLayout(false);
            this.exhibitDetailsGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.searchChoices.ResumeLayout(false);
            this.searchChoices.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sectionsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox visitorNameTextBox;
        private System.Windows.Forms.Button buyTicketButton;
        private System.Windows.Forms.Label searchByExhibitLabel;
        private System.Windows.Forms.ComboBox searchByExhibitComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox arrivalDateTextBox;
        private System.Windows.Forms.TextBox materialTextBox;
        private System.Windows.Forms.TextBox historicalPeriodTextBox;
        private System.Windows.Forms.TextBox countryOfFoundationTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox exhibitDetailsGroupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox searchChoices;
        private System.Windows.Forms.RadioButton searchByExhibtRadioButton;
        private System.Windows.Forms.RadioButton searchBySectionRadioButton;
        private System.Windows.Forms.Button backToMainMenuButton;
        private System.Windows.Forms.DateTimePicker dateOfVisitPicker;
        private System.Windows.Forms.Button anotherVisitorButton;
        private System.Windows.Forms.TextBox numberOfTicketsTextBox;
        private System.Windows.Forms.Label numberOfTicketsLabel;
    }
}