using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using EntryLevel6Database.DatabaseProject;

namespace EntryLevel6Database
{
    public partial class UserLogin : Form
    {
        
        DBProfile dd = new DBProfile();
        
        DataTable agents = new DataTable();
        public static string agentID, agentName, agentEmail, agentPassword, Agent;

        private void txtEmailLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public UserLogin()
        {
            InitializeComponent();
        }

        private void LogInbtn_Click(object sender, EventArgs e)
        {
            
                string agentLoginEmail = txtagentEmailLogin.Text;
                string agentLoginPW = txtagentPWLogin.Text;
               

                if (agentLoginEmail.Equals(""))
                {
                    MessageBox.Show("Please Enter All Fields");
                }
                else if (agentLoginPW.Equals(""))
                {
                    MessageBox.Show("Please Enter All Fields");
                }
                else
                {

                    string query = "Select * from UserAgents Where UserName = '" + agentLoginEmail + "' AND UserPassword = '" + agentLoginPW + "'";
                    dd.readDatathroughAdapter(query, agents);

                    if (agents.Rows.Count == 1)
                    {


                        agentID = agents.Rows[0]["UserID"].ToString();
                        agentName = agents.Rows[0]["UserName"].ToString();
                        agentPassword = agents.Rows[0]["UserPassword"].ToString();
                        


                        MessageBox.Show("Login Successful");
                        dd.closeConn();

                        this.Hide();
                        CustomersProfile Pfl = new CustomersProfile();
                        Pfl.Show();
                    }
                    else
                    {
                        MessageBox.Show("Password or Email is Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

            string agentLoginEmail = txtagentEmailLogin.Text;
            string agentLoginPW = txtagentPWLogin.Text;


            if (agentLoginEmail.Equals(""))
            {
                MessageBox.Show("Please Enter All Fields");
            }
            else if (agentLoginPW.Equals(""))
            {
                MessageBox.Show("Please Enter All Fields");
            }
            else
            {

                string query = "Select * from UserAgents Where UserName = '" + agentLoginEmail + "' AND UsertPassword = '" + agentLoginPW + "'";
                dd.readDatathroughAdapter(query, agents);

                if (agents.Rows.Count == 1)
                {


                    agentID = agents.Rows[0]["ID"].ToString();
                    agentName = agents.Rows[0]["Name"].ToString();
                    agentEmail = agents.Rows[0]["Email"].ToString();
                    agentPassword = agents.Rows[0]["Password"].ToString();



                    MessageBox.Show("Login Successful");
                    dd.closeConn();

                    this.Hide();
                    CustomersProfile Pfl = new CustomersProfile();
                    Pfl.Show();
                }
                else
                {
                    MessageBox.Show("Password or Email is Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            //Agent = txtagentEmailLogin.Text;
            //this.Close();
            //Customer_Processing p5 = new Customer_Processing();
            //p5.Show();
        }


    }

}
