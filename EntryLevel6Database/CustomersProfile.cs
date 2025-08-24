using EntryLevel6Database.DatabaseProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntryLevel6Database
{
    public partial class CustomersProfile : Form
    {


        DBProfile db1 = new DBProfile();
        DBAccess db3 = new DBAccess();
        public static string yup;

        public static DataTable DtCustomers = new DataTable();
        public static DataTable SelCustomers = new DataTable();
        public static DataTable NewCustomers = new DataTable();
        public static DataTable AddCustomers = new DataTable();
        public static string this1;
        public static string this2;
        public static string getName;

        
        public CustomersProfile()
        {
            InitializeComponent();
        }
        private void CustomersProfile_Load(object sender, EventArgs e)
        {
            // NewListing();

            CustomersTable();
            SelectCustomers();
           
            
            string query = "Select * from Profile";
            db1.readDatathroughAdapter(query, AddCustomers);
            dataGridView1.DataSource = AddCustomers;

            listBox1.DataSource = DtCustomers;
            listBox1.DisplayMember = "AccountHolder";

            listBox2.DataSource = SelCustomers;
            listBox2.DisplayMember = "AccountHolder";






            db1.closeConn();
        }
        private void NewListing ()
        {


            string query = "Select * from Signees ";
            db1.readDatathroughAdapter(query, NewCustomers);
            dataGridView1.DataSource = AddCustomers;

            listBox1.DataSource = DtCustomers;
            listBox1.DisplayMember = "AccountHolder";
            //this1 = listBox1.ToString();

            listBox2.DataSource = NewCustomers;
            listBox2.DisplayMember = "AccountHolder";
            //this2 = listBox2.ToString();

            db1.closeConn();

        }







        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try

            {
                listBox1.DataSource = DtCustomers;
                listBox1.DisplayMember = "AccountHolder";
            }

            catch(Exception ex)
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                listBox1.Items.Add(dataGridView1.SelectedCells[0].Value.ToString());
            }

            catch(Exception ex)
            {

            }





            string yup;
            //this adds data ffro the grid to the listbox, we will not be using this operation.
            //var item = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            //yup = item.ToString();
            //MessageBox.Show(yup);
            

            //listBox1.Items.Add(dataGridView1.SelectedCells[0].Value.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
            private void Addbtn_Click(object sender, EventArgs e)
            {
                if (listBox1.Items.Count > 0)
                {
                    SelCustomers.ImportRow(DtCustomers.Rows[listBox1.SelectedIndex]);
                    DtCustomers.Rows[listBox1.SelectedIndex].Delete();


                }
            }
           
        

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CustomersTable()
        {
            
            try
                { 
            DtCustomers.Columns.Add("AccountNumber", typeof(int));
            DtCustomers.Columns.Add("AccountHolder");
            DtCustomers.Columns.Add("HolderAddress");
            DtCustomers.Columns.Add("PremiseNo");
            DtCustomers.Columns.Add("Balance");
            DtCustomers.Columns.Add("CurrentUsage");
            DtCustomers.Columns.Add("CurrentCharges");
            DtCustomers.Columns.Add("PaymentDate");
            DtCustomers.Columns.Add("DueDate");
            DtCustomers.Columns.Add("AmountDue");


            DtCustomers.Rows.Add(1, "Donte Johnson", "5768", "brooklyn 99 ave", "", "", "", "", "", "");
            DtCustomers.Rows.Add(2, "Sherill Hamilton", "7487", "Trealwny Falls", "", "", "", "", "", "");
            DtCustomers.Rows.Add(3, "Maxwell Brando", "435", "Olando Road NF676", "", "", "", "", "", "");
            DtCustomers.Rows.Add(4, "Asia bell", " 345", "Boston District 35MT", "", "", "", "", "", "");
            DtCustomers.Rows.Add(5, "DBrian Anthony", "3345", "Virgina Avenue Lot 5", "", "", "", "", "", "");
            DtCustomers.Rows.Add(6, "Mark Jacobs", "324", "Rohmampton Close", "", "", "", "", "", "");
            DtCustomers.Rows.Add(7, "Lucas Lewis", "454", "Gotham City Putlock 5th St", "", "", "", "", "", "");
            DtCustomers.Rows.Add(8, "Brian James", "6776", " Disticnion Boulevard", "", "", "", "", "", "");
            DtCustomers.Rows.Add(9, "Anthony Hopkins", "768", "Old Town Road 78GH", "", "", "", "", "", "");
                }

            catch(Exception e)
            {

            }

            

        }
        private void SelectCustomers()
        {
            try
            {

                SelCustomers.Columns.Add("AccountNumber", typeof(int));
                SelCustomers.Columns.Add("AccountHolder");
                SelCustomers.Columns.Add("Holder Address");
            }
            catch(Exception e) 
            { 
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

       

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Removebtn_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count >= 0)
            {


                try
                {
                    DtCustomers.ImportRow(SelCustomers.Rows[listBox2.SelectedIndex]);
                    SelCustomers.Rows[listBox1.SelectedIndex].Delete();

                }

                catch (Exception ex)
                {

                }
            }

        }

        private void Addallbtn_Click_1(object sender, EventArgs e)
        {


            if (listBox1.Items.Count > 0)
            {
                int Count = DtCustomers.Rows.Count;

                for (int i = Count - 1; i >= 0; i++)
                {
                    SelCustomers.ImportRow(DtCustomers.Rows[listBox1.SelectedIndex]);
                    DtCustomers.Rows[listBox1.SelectedIndex].Delete();
                }


            }

        }

        private void removeallbtn_Click(object sender, EventArgs e)
        {

            if (listBox1.Items.Count > 0)
            {
                int Count = SelCustomers.Rows.Count;

                for (int i = Count - 1; i >= 0; i++)

                {

                    DtCustomers.ImportRow(SelCustomers.Rows[listBox2.SelectedIndex]);
                    SelCustomers.Rows[listBox1.SelectedIndex].Delete();
                }

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult Dialog = MessageBox.Show("Confirm Selected Account", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Dialog == DialogResult.Yes)
            {
                dataGridView1.DataSource = SelCustomers;
                dataGridView1.Enabled = false;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[1].Width = 600;
                dataGridView1.Columns[2].Width = 600;
            }

            else
            {
                MessageBox.Show("At least one Customer must be selected before you may proceed", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        private void inforefresh_Click_1(object sender, EventArgs e)
        {
            this.Close();
            CustomersProfile p4 = new CustomersProfile();
            p4.Show();
        }

        private void Finalisebtn_Click_1(object sender, EventArgs e)
        {
            getName = string.Format(listBox1.DisplayMember);
            //Customer_Processing.Holder = DtCustomers.Rows[listBox1.SelectedIndex].ToString();
            NewListing();



            //string query = "Select * from Users";
            //int changes = db1.executeDataAdapter(DtCustomers, query);

            //MessageBox.Show(changes + " " + "operations were performed");


            //dataGridView1.DataSource = dataTable;
            //conn.Close();



            DialogResult D1 = new DialogResult();
            D1 = MessageBox.Show("Data Synced succesfully, Click 'Yes' to Process Customer", "Sync Complete", MessageBoxButtons.YesNo);

            if (D1 == DialogResult.Yes)
            {
                this.Hide();
                Customer_Processing C1 = new Customer_Processing();
                C1.Show();
            }
            else
            {


            }

        }

        private void InfotxtBack_Click_1(object sender, EventArgs e)
        {

            this.Close();
            Customer_Processing P1 = new Customer_Processing();
            P1.Show();
        }

        private void listBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void DBtxtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }






}
