using EntryLevel6Database.DatabaseProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net.NetworkInformation;

namespace EntryLevel6Database
{
    public partial class Customer_Processing : Form

        
    {
        public SqlConnection connection = new SqlConnection();
        DBProfile db2 = new DBProfile();
      

        public Customer_Processing()
        {
            InitializeComponent();
        }

        private void Uploadbtn_Click(object sender, EventArgs e)
        {
            string Read = textMeterRead.Text;
            string AccBal = AtxtBalances.Text;
            string AccCurrent = AtxtCurrentCharge.Text;
            string AccPay = Atxtpayments.Text;
            string Premise = APremisetxt.Text;
            string Holder = AHoldertxt.Text;
            string residence = AtxtAddress.Text;
            string acc = AccNotxt.Text;
            string state = AtxtStatement.Text;
            string datepay = AtxtPayDate.Text;
            string datemustpay = AtxtDueDate.Text;
            string AccDue = AtxtAmountDue.Text;


            SqlCommand insertCommand = new SqlCommand("INSERT INTO Profile(AccountHolder,HolderAddress,PremiseNo,Balance,CurrentUsage,CurrentCharges,Amountdue,PaymentDate,DueDate) values('" + AccNotxt.Text + "','" + AtxtAddress.Text + "','" + APremisetxt.Text + "','" + AtxtBalances.Text + "','" + textMeterRead.Text + "','" + AtxtCurrentCharge.Text + "','" + AtxtAmountDue.Text + "','" + AtxtPayDate.Text + "','" + datemustpay + "')", connection);

            insertCommand.Parameters.AddWithValue("@AccountHolder", AccNotxt.Text);
            insertCommand.Parameters.AddWithValue("@HolderAddress", residence);
            insertCommand.Parameters.AddWithValue("@PremiseNo", Premise);
            insertCommand.Parameters.AddWithValue("@Balance", AccBal);
            insertCommand.Parameters.AddWithValue("@CurrentUsage", Read);
            insertCommand.Parameters.AddWithValue("@CurretCharges", AccCurrent);
            insertCommand.Parameters.AddWithValue("@AmountDue", AccDue);
            insertCommand.Parameters.AddWithValue("@PaymentDate", datepay);
            insertCommand.Parameters.AddWithValue("@DueDate", datemustpay);

            int row = db2.executeQuery(insertCommand);
            if (row.Equals(1))
            {
                MessageBox.Show("Uploaded Successfully");
                this.Hide();
                SignIn sign = new SignIn();
                sign.Show();
            }
            else
            {
                MessageBox.Show("Error Occurred, Try Again");
            }
        }







        public static Boolean Fixed, Non;
        public static double AccBalance, AccTotal, AccCharge, AccDueAmount;
        public static string AccCurrent, AccPay, AccBal, Read, Premise, Holder, residence, acc, state, datepay, datemustpay,AccDue,Accprevious;
        public static string AccName;
        public static string AccNo;
        public static string AccAddress ;
        public static string AccPrevBalance;
        public static string AccPayments;
        public static string AccCurrentCharges;
        public static string AccAmount;
        public static string AccStatement;
        public static string AccDuedate;
        public static string accPayDate;

        
        private void ProUploadBackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomersProfile PP = new CustomersProfile();
            PP.Show();
        }

        private void AHoldertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void APremisetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccNotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AtxtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void AtxtStatement_TextChanged(object sender, EventArgs e)
        {

        }

        private void AtxtPrevbalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void Atxtpayments_TextChanged(object sender, EventArgs e)
        {

        }

        private void AtxtBalances_TextChanged(object sender, EventArgs e)
        {

        }

        private void AtxtCurrentCharge_TextChanged(object sender, EventArgs e)
        {

        }

        private void AtxtAmountDue_TextChanged(object sender, EventArgs e)
        {

        }

        private void AtxtDueDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string SName = txtProcessingSearch.Text;
            

            try
            {
                db2.createConn();

                SqlCommand cmm = new SqlCommand("Select * From [Profile] WHERE(AccountHolder = '"+ SName +"')", connection);
                SqlDataReader reader = cmm.ExecuteReader();
                while (reader.Read())
                {
                    AHoldertxt.Text = reader.GetValue(0).ToString();
                    AccNotxt.Text = reader.GetValue(0).ToString();
                    AtxtAddress.Text = reader.GetValue(0).ToString();
                    AtxtPrevbalance.Text = reader.GetValue(0).ToString();
                    Atxtpayments.Text = reader.GetValue(0).ToString();
                    AtxtCurrentCharge.Text = reader.GetValue(0).ToString();
                    AtxtAmountDue.Text = reader.GetValue(0).ToString();
                    AtxtStatement.Text = reader.GetValue(0).ToString();
                    AtxtDueDate.Text = reader.GetValue(0).ToString();
                    AtxtPayDate.Text = reader.GetValue(0).ToString();
                }
                db2.closeConn();

            }

            catch(Exception ex)
            {
                MessageBox.Show("Error occurred" + ex);
            }
            finally
            {
                db2.closeConn();
            }
        }

        private void txtProcessingSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void AtxtPayDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void Customer_Processing_Load(object sender, EventArgs e)
        {

            AHoldertxt.Text = CustomersProfile.getName;
            //AHoldertxt.Text = String.Format(CustomersProfile.SelCustomers.Rows[0].ToString());
            //String.Format(AHoldertxt.Text, AHoldertxt.Text);

        }

        private void lblCustName_Click(object sender, EventArgs e)
        {
            lblCustName.Text = Commmand_Build_Form.CustomerName;
        }

        private void FixedBtn_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void AccgroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void Customer_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_Profile P1 = new Customer_Profile();
            P1.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Processbtn_Click(object sender, EventArgs e)
        {
            string AccName = AHoldertxt.Text;
            string AccNo = AccNotxt.Text;
            string AccAddress = AtxtAddress.Text;
            string AccPrevBalance = AtxtPrevbalance.Text;
            string AccPayments = Atxtpayments.Text;
            string AccCurrentCharges = AtxtCurrentCharge.Text;
            string AccAmount = AtxtAmountDue.Text;
            string AccStatement = AtxtStatement.Text;
            string AccDuedate = AtxtDueDate.Text;
            string accPayDate = AtxtPayDate.Text;

            try
            {
                
                AccBalance = double.Parse(Atxtpayments.Text) - double.Parse(AtxtPrevbalance.Text);
                AccCharge = double.Parse(AtxtCurrentCharge.Text);
                AccTotal = int.Parse(Atxtpayments.Text) + int.Parse(AtxtPrevbalance.Text);
                AccDueAmount = AccTotal + AccCharge;
                AtxtBalances.Text = AccBalance.ToString();
                AtxtCurrentCharge.Text = AccCharge.ToString();
                AtxtAmountDue.Text = AccDueAmount.ToString();
                
                reading();
                CustType();
            
            }

            catch(Exception ex) 
            {
            
            }


            
            Read = textMeterRead.Text; reading();
            AccBal = AtxtBalances.Text;
            AccCurrent = AtxtCurrentCharge.Text;
            AccPay = Atxtpayments.Text;
            Premise = APremisetxt.Text;
            Holder = AHoldertxt.Text;
            residence = AtxtAddress.Text;
            acc = AccNotxt.Text;
            state = AtxtStatement.Text;
            datepay = AtxtPayDate.Text;
            datemustpay = AtxtDueDate.Text;
            AccDue = AtxtAmountDue.Text;
            Accprevious = AtxtPrevbalance.Text;
            

            DialogResult Dr = new DialogResult();
            Dr = MessageBox.Show("Go To Profile", "Processing",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(Dr == DialogResult.Yes)
            {
                   
                Customer_Profile CP = new Customer_Profile();
                CP.Show();
            }

            else 
            {
                this.Hide();
                Billing_Details b1 = new Billing_Details();
                b1.Show();
            }
          
        }

        private void textMeterRead_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void NonFixedbtn_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void reading()
        {
                try
                {
                    Billing_Details.KiloWatt = double.Parse(textMeterRead.Text);
                }
                catch (Exception e)
            {

            }
              


            
        }
        private void CustType()
        {
            if (NonFixedbtn.Checked)
            {
                Non = true;
            }

            else if (FixedBtn.Checked)
            {
                    Fixed = true;
            }
            else
            {

                DialogResult Dn = new DialogResult();
                Dn = MessageBox.Show("Enter Billing Details", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Dn == DialogResult.Yes)
                {
                    this.Close();
                    Customer_Processing CCP = new Customer_Processing();
                    CCP.Show();
                }
                else
                {
                    this.Hide();
                    CustomersProfile CF = new CustomersProfile();
                    CF.Show();
                }
            }
        }
        
        
    }
}
