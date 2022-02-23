using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;


namespace MainForm
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void connectedModeFormRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buyATicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void showExhibitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            disconnectedModeForm disconnectedMode = new disconnectedModeForm();
            disconnectedMode.Show();

        }

        private void visitorsToolStrip_Click(object sender, EventArgs e)
        {

        }

        private void sectionDetailsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sectionDetailsReportForm sectiondetails = new sectionDetailsReportForm();
            sectiondetails.Show();
            

        }

        private void viewVistiorsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewDetailsReportform viewDetails = new viewDetailsReportform();
            viewDetails.Show();
        }

        private void buyATicketToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            connectedModeForm connectedMode = new connectedModeForm();
            connectedMode.Show();
        }
    }
}
