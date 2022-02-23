using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace MainForm
{
    public partial class connectedModeForm : Form
    {

        string ordb = "Data source=orcl;user id=hr;password=hr;";
        OracleConnection conn;
        int visitorID;
        bool alreadyAdded = false;

        public connectedModeForm()
        {
            InitializeComponent();
        }

        private void connectedModeForm_Load(object sender, EventArgs e)
        {

            numberOfTicketsTextBox.Text = "1";

            dateOfVisitPicker.MinDate = DateTime.Now;

            visitorID=getVisitorID();

            conn = new OracleConnection(ordb);
            conn.Open();

         
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "getSectionNames";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("sectionNames", OracleDbType.RefCursor,ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sectionsComboBox.Items.Add(dr[0]);
            }
            dr.Close();
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "getExhibtNames";
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.Add("exhibtNames", OracleDbType.RefCursor, ParameterDirection.Output);
             dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
               searchByExhibitComboBox.Items.Add(dr[0]);
            }
            dr.Close();

        }

        private void connectedModeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
            //this.Dispose();
           // mainForm mainf = new mainForm();
            //mainf.Show();
            
            
        }

        private void sectionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "getSectionData";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("sectionName",sectionsComboBox.SelectedItem.ToString());
            cmd.Parameters.Add("sectionPrice", OracleDbType.Int32,ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            priceTextBox.Text =cmd.Parameters["sectionPrice"].Value.ToString();

        }

        private void searchByExhibitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"Select Typeexhibit, arrivaldate,material,historicalperiod,countryoffoundation,
                                sectionid from exhibts where exhibitname=:name";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("name",searchByExhibitComboBox.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                typeTextBox.Text = dr[0].ToString();
               arrivalDateTextBox.Text = dr[1].ToString();
               materialTextBox.Text = dr[2].ToString();
               historicalPeriodTextBox.Text = dr[3].ToString();
               countryOfFoundationTextBox.Text = dr[4].ToString();
              string sectionID = dr[5].ToString();
                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = "Select price,sectionname from sections where sectionID=:id";
              cmd2.Parameters.Add("id", Convert.ToInt32(sectionID));
                OracleDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    priceTextBox.Text = dr2[0].ToString();
                    sectionsComboBox.Text = dr2[1].ToString();
                }
                dr2.Close();
            }
            dr.Close();
            exhibitDetailsGroupBox.Visible = true;
        }

        private void buyTicketButton_Click(object sender, EventArgs e)
        {

            if (visitorNameTextBox.Text == "" || visitorNameTextBox.Text == null)
            {
                MessageBox.Show("Please Enter A Valid Name!", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (sectionsComboBox.Text == "" || priceTextBox.Text == "")
            {
                MessageBox.Show("You must Choose a section by its name or by a certain exhibt before buying ticket!", "Cannot Buy Ticket", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                int ticketID;

                if (alreadyAdded == false)
                {
                    OracleCommand cmd2 = new OracleCommand();
                    cmd2.Connection = conn;
                    cmd2.CommandText = "insert into visitor values(:id,:name)";
                    cmd2.Parameters.Add("id", visitorID);
                    cmd2.Parameters.Add("name", visitorNameTextBox.Text);

                    cmd2.ExecuteNonQuery();
                    alreadyAdded = true;
                }
                OracleCommand cmd4 = new OracleCommand();
                cmd4.Connection = conn;
                int sectionID = 0;
                cmd4.CommandText = "Select sectionID from sections where sectionname=:name";
                cmd4.Parameters.Add("name", sectionsComboBox.Text);
                OracleDataReader dr = cmd4.ExecuteReader();
                while (dr.Read())
                {
                    sectionID = Convert.ToInt32(dr[0].ToString());
                }
                

                string d = getDateInFormat();

                OracleCommand cmd3 = new OracleCommand();
                cmd3.Connection = conn;
                cmd3.CommandText = "getLastTicketID";
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
                cmd3.ExecuteNonQuery();
                try
                {

                    ticketID = Convert.ToInt32(cmd3.Parameters["id"].Value.ToString()) + 1;
                }
                catch
                {
                    ticketID = 1;

                }
                int numberOfTickets = Convert.ToInt32(numberOfTicketsTextBox.Text.ToString());
                bool reserved = true;

                for (int i = 0; i < numberOfTickets; i++)
                {
                    
                    OracleCommand cmd5 = new OracleCommand();
                    cmd5.Connection = conn;
                    cmd5.CommandText = "insert into ticket (ticketid,ticketdate,sectionid,visitorid) values(:id,:d,:sectionId,:visitorId)";
                    cmd5.Parameters.Add("id", ticketID+i);
                    cmd5.Parameters.Add("d", Convert.ToDateTime(d));
                    cmd5.Parameters.Add("sectionId", sectionID);
                    cmd5.Parameters.Add("visitorId", visitorID);
           
                    int r = cmd5.ExecuteNonQuery();
                    if (r == -1)
                    {
                        reserved = false;
                        break;
                        
                    }
                }
                if (reserved && numberOfTickets>1)
                    MessageBox.Show("Tickets Reserved Successfully!");
                else if (reserved && numberOfTickets == 1)
                    MessageBox.Show("Ticket Reserved Successfully!");
            }
        }
        private int getVisitorID()
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd3 = new OracleCommand();
            cmd3.Connection = conn;

            cmd3.CommandText = "getLastVisitorID";
            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            cmd3.ExecuteNonQuery();
            try
            {

                visitorID = Convert.ToInt32(cmd3.Parameters["id"].Value.ToString()) + 1;
            }
            catch
            {
                visitorID = 1;

            }
            return visitorID;
        }
        private void searchBySectionRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            if (searchBySectionRadioButton.Checked)
            {
                sectionsComboBox.Enabled = true;
                exhibitDetailsGroupBox.Visible = false;
                searchByExhibitComboBox.Enabled = false;
            }
            else
            { sectionsComboBox.Enabled = false;
                searchByExhibitComboBox.Enabled = false;
                exhibitDetailsGroupBox.Visible = false;
            }
        }

        private void searchByExhibtRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (searchByExhibtRadioButton.Checked)
            {
                searchByExhibitComboBox.Enabled = true;
                sectionsComboBox.Enabled = false;
                exhibitDetailsGroupBox.Visible = false;
            }

            else
            { searchByExhibitComboBox.Enabled = false;
                sectionsComboBox.Enabled = false;
                exhibitDetailsGroupBox.Visible = false;
            }
        }


        private void visitorNameTextBox_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void backToMainMenuButton_Click(object sender, EventArgs e)
        {
           

           this.Close();
            
        }

        private string getDateInFormat()
        {

            string d = dateOfVisitPicker.Value.Day.ToString() + "-";
            string month = dateOfVisitPicker.Value.Month.ToString();
            if (month == "1")
                d += "JAN-";
            else if (month == "2")
                d += "FEB-";
            else if (month == "3")
                d += "MAR-";
            else if (month == "4")
                d += "APR-";
            else if (month == "5")
                d += "MAY-";
            else if (month == "6")
                d += "JUN-";
            else if (month == "7")
                d += "JUL-";
            else if (month == "8")
                d += "AUG-";
            else if (month == "9")
                d += "SEP-";
            else if (month == "10")
                d += "OCT-";
            else if (month == "11")
                d += "NOV-";
            else if (month == "12")
                d += "DEC-";

            d += dateOfVisitPicker.Value.Year.ToString();
            return d;
        }

        private void visitorNameTextBox_Leave(object sender, EventArgs e)
        {
            visitorNameTextBox.Enabled = false;
            anotherVisitorButton.Enabled = true;
        }

        private void anotherVisitorButton_Click(object sender, EventArgs e)
        {
            visitorNameTextBox.Text = "";
            numberOfTicketsTextBox.Text = "1";
            anotherVisitorButton.Enabled = false;
            visitorNameTextBox.Enabled = true;
            visitorID = getVisitorID();
            alreadyAdded = false;
        }
    }
}
