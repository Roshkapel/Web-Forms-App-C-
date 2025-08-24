using EntryLevel6Database.DatabaseProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntryLevel6Database
{
    public partial class Commmand_Build_Form : Form
    {

        
        DBProfile db1 = new DBProfile();
        DataTable DtUsers = new DataTable();
        DataTable DtCustomers = new DataTable();
        DataTable SelectCustomers = new DataTable();
        public static string CustomerName, CustomerID, CustomerAddress, CustomerEmail;
        public Commmand_Build_Form()
        {
            InitializeComponent();
        }

        private void Commmand_Build_Form_Load(object sender, EventArgs e)
        {
            string query = "Select * from Profile";
            db1.readDatathroughAdapter(query, DtUsers);
            dataGridView1.DataSource = DtUsers;
            db1.closeConn();
        }

        private void Operationbtn_Click(object sender, EventArgs e)
        {
           
            string query = "Select * from Users";
            int changes = db1.executeDataAdapter(DtUsers, query);

            MessageBox.Show(changes + " " + "operations were performed");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Select_Click_1(object sender, EventArgs e)
        {
            CustomerName = listBox1.Text;
            MessageBox.Show($"{CustomerName}customer name");
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            listBox1.Items.Add(dataGridView1.SelectedCells[0].Value.ToString());
        }
    }
}
