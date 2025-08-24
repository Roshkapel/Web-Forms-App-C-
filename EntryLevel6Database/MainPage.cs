using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntryLevel6Database
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void EmployeesLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
          
            UserLogin UL = new UserLogin();
            UL.Show();  
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            SignIn SG = new SignIn();
            SG.Show();
        }

        private void ExitMainBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
