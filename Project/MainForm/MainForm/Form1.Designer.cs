namespace MainForm
{
    partial class mainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.showExhibitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sectionDetailsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewVistiorsDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.buyATicketToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buyATicketToolStripMenuItem1,
            this.showExhibitsToolStripMenuItem,
            this.sectionDetailsReportToolStripMenuItem,
            this.viewVistiorsDetailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // showExhibitsToolStripMenuItem
            // 
            this.showExhibitsToolStripMenuItem.Name = "showExhibitsToolStripMenuItem";
            this.showExhibitsToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.showExhibitsToolStripMenuItem.Text = "Show Exhibits";
            this.showExhibitsToolStripMenuItem.Click += new System.EventHandler(this.showExhibitsToolStripMenuItem_Click);
            // 
            // sectionDetailsReportToolStripMenuItem
            // 
            this.sectionDetailsReportToolStripMenuItem.Name = "sectionDetailsReportToolStripMenuItem";
            this.sectionDetailsReportToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.sectionDetailsReportToolStripMenuItem.Text = "Section Details Report";
            this.sectionDetailsReportToolStripMenuItem.Click += new System.EventHandler(this.sectionDetailsReportToolStripMenuItem_Click);
            // 
            // viewVistiorsDetailsToolStripMenuItem
            // 
            this.viewVistiorsDetailsToolStripMenuItem.Name = "viewVistiorsDetailsToolStripMenuItem";
            this.viewVistiorsDetailsToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.viewVistiorsDetailsToolStripMenuItem.Text = "View Vistiors Details";
            this.viewVistiorsDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewVistiorsDetailsToolStripMenuItem_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.welcomeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Maroon;
            this.welcomeLabel.Location = new System.Drawing.Point(54, 181);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(502, 31);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome To Musuem Managment System";
            // 
            // buyATicketToolStripMenuItem1
            // 
            this.buyATicketToolStripMenuItem1.Name = "buyATicketToolStripMenuItem1";
            this.buyATicketToolStripMenuItem1.Size = new System.Drawing.Size(85, 20);
            this.buyATicketToolStripMenuItem1.Text = "Buy A Ticket";
            this.buyATicketToolStripMenuItem1.Click += new System.EventHandler(this.buyATicketToolStripMenuItem1_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainForm";
            this.Text = "Main Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.ToolStripMenuItem showExhibitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sectionDetailsReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewVistiorsDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyATicketToolStripMenuItem1;
    }
}

