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

namespace EntryLevel6Database
{
    public partial class Billing_Details : Form
    {

        
        DBProfile ddb = new DBProfile();
        DataTable PayInfo = new DataTable();

        public static string Premise_Num, Account_Num, AccName, AccAddress;
        public static double Prev_Balance, Payments, BalanceBForward, CurrentCharge, TotalDue, StatementDue, DateDue, PaymentDue, TotalCharge;
        public static double EarlyDisc = 0, Taxes = 0, CurrentRead, PrevRead, EnergyUse, CurrentPeriodUse;
        public static double CurrenUsage;
        private void panel25_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel26_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtxtTotal_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtxtCurrentreading_Click(object sender, EventArgs e)
        {

        }

        private void BtxtBalance_Click(object sender, EventArgs e)
        {

        }

        private void BtxtCurrentCharges_Click(object sender, EventArgs e)
        {

        }

        private void BtxtAccNo_Click(object sender, EventArgs e)
        {

        }

        private void BtxtMeterRead_Click(object sender, EventArgs e)
        {

        }

        private void BtxtAddress_Click(object sender, EventArgs e)
        {

        }

        private void BDGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ChartMeter_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        public static double SubTotal, FeAdjust, FuelCharge, IPPCharge, TotalBeforeTax, Nontaxable, Taxable, GCT = 0, TotalCurrent, TotalAmountDue;
        public static double EnergyFirst, EnergySecond, FixedCustomer, KiloWatt, CurrentUsage, Rate, EnergyCharge;
        public static double CurrentPeriod, FuelCosts, discount, KWH, QuickAmount;
        public static double BaseTotal, TaxTotal, Fueltotal, AdjustTotal, PresentTotal, DiscountTotal, GrossTotal, AmountTotal; 
        public Billing_Details()
        {
            InitializeComponent();

            try
            {

                KiloWatt = double.Parse(Customer_Processing.Read);
                KWH = KiloWatt;
            }

            catch(Exception ex)
            {
                MessageBox.Show("Invalid Format" + ex);
            }

            if (KWH <= 150)
            {
                TotalCharge = TotalBeforeTax;

               
            }

            
        }

        private void Billing_Details_Load(object sender, EventArgs e)
        {
            try
            {
                CurrentUsage = double.Parse(Customer_Processing.Read);
                CurrentUsage = CurrentUsage * 86.7;

            }

            catch (FormatException ex)
            {

            }

            string query = "Select * from PaymentInfo";
                ddb.readDatathroughAdapter(query, PayInfo);
                BDGrid.DataSource = PayInfo;

                this.ChartMeter.Series["Usage"].Points.AddXY("Energy Used", Customer_Processing.Read);
                this.ChartMeter.Series["Customers"].Points.AddXY("Payments", Customer_Processing.Accprevious);
                ddb.closeConn();
            

            try
            {
                KiloWatt = double.Parse(Customer_Processing.Read);
                KWH = KiloWatt;
                QuickAmount = double.Parse(Customer_Processing.AccDue);
            }
            catch(Exception ex)
            {

            }

            calculate(QuickAmount, GrossTotal);
            Due();
            EnergyUse = CurrentUsage;
            BtxtTotal.Text = AmountTotal.ToString();
            BtxtCurrentreading.Text = Customer_Processing.Read.ToString();
            BtxtBalance.Text = Customer_Processing.AccBal.ToString();
            BtxtCurrentCharges.Text = Customer_Processing.AccCurrent.ToString();
            BtxtAccNo.Text = Customer_Processing.acc.ToString();
            BtxtMeterRead.Text = Customer_Processing.Read.ToString();
            BtxtCustomerName.Text = Customer_Processing.Holder.ToString();
            BtxtAddress.Text = Customer_Processing.residence.ToString();
            BtxtEnergyUsed.Text = EnergyUse.ToString();
            BtxtYouPaid.Text = Customer_Processing.AccPay.ToString();
            BtxtLastBill.Text = Customer_Processing.Accprevious.ToString();

            DateTime dt = new DateTime();
            BtxtDate.Text = DateTime.UtcNow.AddDays(30).ToString();
         



        }
        
       
        private void CurrentPer()
        {
            if (Customer_Processing.Non)
            {
                
                
                EnergyFirst = 7.390 * KWH;
                EnergySecond = 22.760 * KWH;
                FixedCustomer = 575.72 * KWH;

                if (KWH <= 100)
                {
                    CurrentCharge = EnergyFirst;
                }
                else
                {
                    CurrentCharge = EnergySecond + EnergyFirst;
                }
            }

           
           else if(Customer_Processing.Fixed)
           {
                CurrentCharge = FixedCustomer;
           }
            else
            {
                DialogResult = MessageBox.Show("Enter Customer Billing Details", " Attention",MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                if(DialogResult == DialogResult.Yes)
                {
                    this.Hide();
                    Customer_Processing P1 = new Customer_Processing();
                    P1.Show();

                }
                else if(DialogResult == DialogResult.No) 
                {
                    this.Hide();
                    Customer_Profile CP = new Customer_Profile();
                    CP.Show();
                }
                
            }

            CurrentPeriod = CurrentCharge;
            PresentTotal = CurrentPeriod;
            


        }

        private void FuelCharges()
        {
            FuelCharge = .17 *  KiloWatt;
            IPPCharge = .45 * KiloWatt;

            FuelCosts = FuelCharge + IPPCharge;


            Fueltotal = FuelCosts;
        }

        
        private void Adjustment()
        {

           
            
            SubTotal = FuelCosts + CurrentPeriod;
            FeAdjust =  SubTotal * (-2.109/100);
            TotalBeforeTax = SubTotal + FeAdjust;

            AdjustTotal = TotalBeforeTax;

            
        }

        public static void Taxing()
        {
            GCT = (15 / 100) * SubTotal;
            TotalCharge = SubTotal + GCT;

            TaxTotal = TotalCharge;
        }
        public static double Discount(int a)
        {
         
            double discount = a - 250;
            return discount;

            
        }
        
        private static void Due()
        {
            TotalAmountDue = TotalCharge + discount;
        }
        public double calculate(double a, double b)
        {
            CurrentPer();
            FuelCharges();
            Adjustment();
            Taxing();
            Discount(250);
            DiscountTotal = discount;
            AmountTotal = a + b;
            return AmountTotal;
            EarlyDisc = discount;
        } 

        private void gross()
        {
            GrossTotal = DiscountTotal + TaxTotal + Fueltotal + TotalAmountDue + AdjustTotal;
        }


    }
}
