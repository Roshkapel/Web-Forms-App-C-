using EntryLevel6Database.DatabaseProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;

namespace EntryLevel6Database
{
    public partial class Homepage : Form
    {

        DBAccess db1 = new DBAccess();
        public Homepage()
        {
            InitializeComponent();
        }

        private void txtPW_TextChanged(object sender, EventArgs e)
        {

        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            HpageName.Text =  SignIn.name;
            txtHName.Text = SignIn.name;
            txtHEmail.Text = SignIn.email;
            txtHPW.Text = SignIn.password;
            txtHCountry.Text = SignIn.country;
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
           
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Account Information Will be Permanently Lost", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                string query = "DELETE from Users Where ID = '" + SignIn.id + "'";

                SqlCommand DeleteCommand = new SqlCommand( query );
                int row = db1.executeQuery(DeleteCommand);

                if (row == 1)
                {
                    MessageBox.Show("Account Removed Sucessfully");

                    this.Hide();
                    SignIn sign = new SignIn();
                    sign.Show();

                }
                else
                {

                    MessageBox.Show("Error Occured, Try Again");


                }

            }
        }

        private void Setbtn_Click(object sender, EventArgs e)
        {

            Customer_Profile.ProName = txtHName.Text;
            this.Hide();
            Customer_Profile p2 = new Customer_Profile();
            p2.Show();
            
        }

        private void txtHName_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
    
    
}
