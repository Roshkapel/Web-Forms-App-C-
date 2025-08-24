using EntryLevel6Database.DatabaseProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EntryLevel6Database
{
    public partial class SignIn : Form
    {

        public static string id, name, email, password, country;
        
        
        DBProfile BP = new DBProfile();
        DataTable DtUsers = new DataTable();
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LogInbtn_Click(object sender, EventArgs e)
        {
            string LoginEmail= txtEmailLogin.Text;
            string LoginPW = txtPWLogin.Text;

            if (LoginEmail.Equals(""))
            {
                MessageBox.Show("Please Enter All Fields");
            }
            else if (LoginPW.Equals(""))
            {
                MessageBox.Show("Please Enter All Fields");
            }
            else
            {

                string query = "Select * from Signees  Where Email  = '" + LoginEmail + "' AND Password = '" + LoginPW + "'";
                BP.readDatathroughAdapter(query, DtUsers);

                if(DtUsers.Rows.Count == 1)
                {
                    
                    
                    //id = DtUsers.Rows[0]["AccountHolder"].ToString();
                   // name = DtUsers.Rows[0]["Name"].ToString();
                    email = DtUsers.Rows[0]["Email"].ToString();
                    password = DtUsers.Rows[0]["Password"].ToString();
                   // country = DtUsers.Rows[0]["Parish"].ToString();


                    MessageBox.Show("Login Successful");
                    BP.closeConn();

                    this.Hide();
                    AccountManagement AC = new AccountManagement();
                    AC.Show();
                }
                else
                {
                    MessageBox.Show("Password or Email is Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp S1 = new SignUp();
            S1.Show();
        }
    }
}
