using EntryLevel6Database.DatabaseProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace EntryLevel6Database
{
    public partial class Customer_Profile : Form
    {
        public static string ProName;
        public static double Kwatt;
        public static double kwh;
        public static double TCharge;
        public static double TBeforetax;
        public static double thisamount;
        public static double gct;
        public static double subT;
        public static double ipp;
        public static double feadjust;
        public static double earlyincentive;
        public static double fuel;
        public static double beforegct;
        public static double tTotal;


        SqlConnection con = new SqlConnection();
        DBProfile ddd = new DBProfile();
        Billing_Details bd = new Billing_Details();
        public Customer_Profile()
        {
            InitializeComponent();
            ProName = lblProfile.Text;
            try
            {

                Kwatt = double.Parse(Customer_Processing.Read);
                kwh = Kwatt;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Invalid Format" + ex);
            }

            if (kwh <= 150)
            {
                TCharge = TBeforetax;


            }

            try
            {

                thisamount = double.Parse(Customer_Processing.AccDue);
                gct = (15 / 100) * double.Parse(Customer_Processing.AccDue);
                subT = gct + thisamount;
                TCharge = subT;

                fuel = .17 * kwh;
                ipp = .45 * kwh;

                fuel = fuel + ipp;
                feadjust = subT * (-2.109 / 100);
                //tTotal = TCharge;
            }

            catch(Exception ex)
            {

            }

        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProtxtCurrentCharge_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customer_Profile_Load(object sender, EventArgs e)
        {

            ProtxtCurrentUsage.Text = Customer_Processing.AccCurrent;
            ProtxtReading.Text = Customer_Processing.Read;
            ProtxtBal.Text = Customer_Processing.AccBal;
            ProtxtAccountHolder.Text = Customer_Processing.Holder;
            ProtxtAccountNo.Text = Customer_Processing.acc;
            ProtxtAmountDue.Text = Customer_Processing.AccDue;
            ProtxtHolderAddress.Text = Customer_Processing.residence;
            ProtxtPremiseNo.Text = Customer_Processing.Premise;
            ProtxtDueDate.Text = Customer_Processing.datemustpay;
            ProtxtPayDate.Text = Customer_Processing.datepay;
            lblProfile.Text = UserLogin.Agent;

            ProfileAmountDue.Text = Customer_Processing.AccDue;
            ProfilebeforeTax.Text = subT.ToString();
            ProfileCurrentCharge.Text = Customer_Processing.Read;
            ProfileFEAdjust.Text = feadjust.ToString();
            ProfileFEAdjust.Text = fuel.ToString();
            ProfileGCT.Text = gct.ToString();
            ProfileSubTotal.Text = subT.ToString();
            ProfileIncentive.Text = Billing_Details.discount.ToString();
            ProfileIPP.Text = ipp.ToString();
            bd.calculate(kwh,thisamount);


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ProBackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_Processing P1 = new Customer_Processing();
            P1.Show();
        }

        private void ProUploadbtn_Click(object sender, EventArgs e)
        {
            double unitcost = 220;
            SqlCommand insertCommand = new SqlCommand("INSERT INTO PaymentInfo(MeterReading,BalanceBroughtForward,UnitCost,Total) values('" + ProtxtReading.Text + "','" + ProtxtBal.Text + "','" + unitcost + "','" + ProtxtAmountDue.Text + "')", con);

            string Meter = ProtxtReading.Text;
            string Bal = ProtxtBal.Text;
            string UnitCost = unitcost.ToString();
            string Tot = ProtxtAmountDue.Text;

            insertCommand.Parameters.AddWithValue("@MeterReading", Meter );
            insertCommand.Parameters.AddWithValue("@BlanceBroughtForward", Bal );
            insertCommand.Parameters.AddWithValue("@UnitCost", unitcost);
            insertCommand.Parameters.AddWithValue("@Total", Tot);
            

            int row = ddd.executeQuery(insertCommand);
            if (row.Equals(1))
            {
                MessageBox.Show("Uploaded Successfully");
                this.Hide();
                Billing_Details BB1 = new Billing_Details();
                BB1.Show();
            }
            else
            {
                MessageBox.Show("Error Occurred, Try Again");
            }
        }

          
    private void lblProfile_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void lblProfile_Click_1(object sender, EventArgs e)
        {

        }

        private void Finishbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Billing_Details bb = new Billing_Details();
            bb.Show();
        }
    }
}

           
           
            
           
            
            
            
           