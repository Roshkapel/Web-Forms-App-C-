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
    
    public partial class SignUp : Form
    {
       DBAccess db1 = new DBAccess();
        DBProfile s1 = new DBProfile();
        
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SignUpbtn_Click(object sender, EventArgs e)
        {
            string userName = txtName.Text;
            string userEmail = txtEmail.Text;
            string userPassWord = txtPW.Text;
            string userAddress = txtCountry.Text;
            string userContact =  txtContact.Text;


            if (userName.Equals(""))
            {
                MessageBox.Show("Please Enter all Fields");
            }

            else if (userEmail.Equals(""))
            {
                MessageBox.Show("Please Enter all Fields");
            }

            else if (userPassWord.Equals(""))
            {
                MessageBox.Show("Please Enter all Fields");
            }

            else if (userAddress.Equals(""))
            {
                MessageBox.Show("Please Enter all Fields");
            }
            else if (userContact.Equals(""))
            {
                MessageBox.Show("Please Enter all Fields");
            }

            else 
            {
                SqlCommand insertCommand = new SqlCommand("insert into Signees(Name,Email,ContactNumber,Address,Password) values(@userName, @userEmail, @userContactNumber,@userAddress, @userPassWord)");

                insertCommand.Parameters.AddWithValue("@userName", userName);
                insertCommand.Parameters.AddWithValue("@userEmail", userEmail);
                insertCommand.Parameters.AddWithValue("@userContactNumber", userContact);
                insertCommand.Parameters.AddWithValue("@userAddress", userAddress);
                insertCommand.Parameters.AddWithValue("@userPassWord", userPassWord);
                

                int row = s1.executeQuery(insertCommand);
                if (row.Equals(1))
                {
                    MessageBox.Show("Account Created Successfully, You May Login to Your Account");
                    this.Hide();
                    SignIn sign = new SignIn();
                    sign.Show();
                }
                else
                {
                    MessageBox.Show("Error Occurred, Try Again");
                }
            }
        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPW_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
