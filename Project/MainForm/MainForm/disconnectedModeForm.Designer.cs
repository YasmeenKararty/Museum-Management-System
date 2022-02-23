namespace MainForm
{
    partial class disconnectedModeForm
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
            this.exhibtsGridView = new System.Windows.Forms.DataGridView();
            this.exhibtSectionToShow = new System.Windows.Forms.Label();
            this.sectionToViewExhibtsComboBox = new System.Windows.Forms.ComboBox();
            this.showExhibtsButton = new System.Windows.Forms.Button();
            this.saveChangesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.exhibtsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // exhibtsGridView
            // 
            this.exhibtsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.exhibtsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exhibtsGridView.Location = new System.Drawing.Point(45, 121);
            this.exhibtsGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exhibtsGridView.Name = "exhibtsGridView";
            this.exhibtsGridView.RowTemplate.Height = 24;
            this.exhibtsGridView.Size = new System.Drawing.Size(747, 182);
            this.exhibtsGridView.TabIndex = 0;
            // 
            // exhibtSectionToShow
            // 
            this.exhibtSectionToShow.AutoSize = true;
            this.exhibtSectionToShow.Location = new System.Drawing.Point(197, 46);
            this.exhibtSectionToShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.exhibtSectionToShow.Name = "exhibtSectionToShow";
            this.exhibtSectionToShow.Size = new System.Drawing.Size(184, 13);
            this.exhibtSectionToShow.TabIndex = 1;
            this.exhibtSectionToShow.Text = "Choose A Section To View its Exhibts";
            // 
            // sectionToViewExhibtsComboBox
            // 
            this.sectionToViewExhibtsComboBox.FormattingEnabled = true;
            this.sectionToViewExhibtsComboBox.Location = new System.Drawing.Point(486, 46);
            this.sectionToViewExhibtsComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sectionToViewExhibtsComboBox.Name = "sectionToViewExhibtsComboBox";
            this.sectionToViewExhibtsComboBox.Size = new System.Drawing.Size(146, 21);
            this.sectionToViewExhibtsComboBox.TabIndex = 2;
            // 
            // showExhibtsButton
            // 
            this.showExhibtsButton.Location = new System.Drawing.Point(388, 80);
            this.showExhibtsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showExhibtsButton.Name = "showExhibtsButton";
            this.showExhibtsButton.Size = new System.Drawing.Size(76, 26);
            this.showExhibtsButton.TabIndex = 3;
            this.showExhibtsButton.Text = "Show Exhibts";
            this.showExhibtsButton.UseVisualStyleBackColor = true;
            this.showExhibtsButton.Click += new System.EventHandler(this.showExhibtsButton_Click);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(369, 322);
            this.saveChangesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(106, 34);
            this.saveChangesButton.TabIndex = 4;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // disconnectedModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 366);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.showExhibtsButton);
            this.Controls.Add(this.sectionToViewExhibtsComboBox);
            this.Controls.Add(this.exhibtSectionToShow);
            this.Controls.Add(this.exhibtsGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "disconnectedModeForm";
            this.Text = "disconnectedModeForm";
            this.Load += new System.EventHandler(this.disconnectedModeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exhibtsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView exhibtsGridView;
        private System.Windows.Forms.Label exhibtSectionToShow;
        private System.Windows.Forms.ComboBox sectionToViewExhibtsComboBox;
        private System.Windows.Forms.Button showExhibtsButton;
        private System.Windows.Forms.Button saveChangesButton;
    }
}