using EntryLevel6Database.DatabaseProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntryLevel6Database
{
    public partial class AccountManagement : Form
    {
        
        DBProfile dd3 = new DBProfile();
        public AccountManagement()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            string newUserName = txtagentHName.Text;
            string newUserEmail = txtagentHEmail.Text;
            string newUserPassword = txtagentHPW.Text;
           

            if (newUserName.Equals(""))
            {
                MessageBox.Show("Please Enter All Fields");
            }

            else if (newUserEmail.Equals(""))
            {
                MessageBox.Show("Please Enter All Fields");
            }
            else if (newUserPassword.Equals(""))
            {
                MessageBox.Show("Please Enter All Fields");
            }
         
            else
            {
                string query = "Update UserAgents SET UserName = '" + newUserName + "', Password = '" + newUserPassword + "', where ID = '" + SignIn.id + "'";
                SqlCommand UpdateCommand = new SqlCommand(query);

                UpdateCommand.Parameters.AddWithValue("@UserName", newUserName);
                UpdateCommand.Parameters.AddWithValue("@UserEmail", newUserEmail);
                UpdateCommand.Parameters.AddWithValue("@UserPassWord", newUserPassword);
                

                int row = dd3.executeQuery(UpdateCommand);

                if (row == 1)
                {
                    MessageBox.Show("Account Created Successfully");

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
            
            this.Close();
            
            //.ProName = txtagentHName.Text;
            //this.Hide();
            //Customer_Profile p2 = new Customer_Profile();
            //p2.Show();
        }

        private void txtAgentHEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccountManagement_Load(object sender, EventArgs e)
        {
            txtagentHEmail.Text = UserLogin.agentEmail;
            txtagentHName.Text = UserLogin.agentName;
            txtagentHPW.Text = UserLogin.agentPassword;
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Account Information Will be Permanently Lost", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                string query = "DELETE from Users Where ID = '" + SignIn.id + "'";

                SqlCommand DeleteCommand = new SqlCommand(query);
                int row = dd3.executeQuery(DeleteCommand);

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
    }
}
