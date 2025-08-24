using EntryLevel6Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntryLevel6Database
{
    internal class Class1
    {
    }
}
/*string Read = textMeterRead.Text;
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


SqlCommand insertCommand = new SqlCommand("INSERT INTO Customers(AccountHolder,HolderAddress,PremiseNo,Balance,CurrentUsage,CurrentCharges,Amountdue,PaymentDate,DueDate) values(AccNotxt.Text,,Atxtaddress.Text,APremisetxt.Text,AtxtBalances.Text,textMeterRead.Text,AtxtCurrentCharge.Text,AtxtAmountDue.Text,AtxtPaydate.Text,,@datemustpay)");

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
}*/

/*try
{
    conn.Open();
    SqlCommand insertCommand = new SqlCommand("INSERT INTO Customers(AccountHolder,HolderAddress,PremiseNo,Balance,CurrentUsage,CurrentCharges,Amountdue,PaymentDate,DueDate) values('" + AccNotxt.Text + "','" + AtxtAddress.Text + "','" + APremisetxt.Text + "','" + AtxtBalances.Text + "','" + textMeterRead.Text + "','" + AtxtCurrentCharge.Text + "','" + AtxtAmountDue.Text + "','" + AtxtPayDate.Text + "','" + datemustpay + "')", conn);
    insertCommand.Parameters.AddWithValue("@AccountHolder", AccNotxt.Text);
    insertCommand.Parameters.AddWithValue("@HolderAddress", residence);
    insertCommand.Parameters.AddWithValue("@PremiseNo", Premise);
    insertCommand.Parameters.AddWithValue("@Balance", AccBal);
    insertCommand.Parameters.AddWithValue("@CurrentUsage", Read);
    insertCommand.Parameters.AddWithValue("@CurretCharges", AccCurrent);
    insertCommand.Parameters.AddWithValue("@AmountDue", AccDue);
    insertCommand.Parameters.AddWithValue("@PaymentDate", datepay);
    insertCommand.Parameters.AddWithValue("@DueDate", datemustpay);
    insertCommand.ExecuteNonQuery();
    MessageBox.Show("Uploaded Successfully");
}
catch (Exception ex)
{

}

//thus is how we manually create data tables

private void CustomersTable()
        {
            DtCustomers.Columns.Add("AccountNo", typeof(int));
            DtCustomers.Columns.Add("AccountHolder");
            DtCustomers.Columns.Add("HolderAddress");
            DtCustomers.Columns.Add("PremiseNo");
            DtCustomers.Columns.Add("Balance");
            DtCustomers.Columns.Add("CurrentUsage");
            DtCustomers.Columns.Add("CurrentCharges");
            DtCustomers.Columns.Add("PaymentDate");
            DtCustomers.Columns.Add("DueDate");
            DtCustomers.Columns.Add("AmountDue");


            DtCustomers.Rows.Add(1, "Donte Johnson", "5768", "brooklyn 99 ave", "", "", "", "", "", "");
            DtCustomers.Rows.Add(2, "Sherill Hamilton", "7487", "Trealwny Falls", "", "", "", "", "", "");
            DtCustomers.Rows.Add(3, "Maxwell Brando", "435", "Olando Road NF676", "", "", "", "", "", "");
            DtCustomers.Rows.Add(4, "Asia bell", " 345", "Boston District 35MT", "", "", "", "", "", "");
            DtCustomers.Rows.Add(5, "DBrian Anthony", "3345", "Virgina Avenue Lot 5", "", "", "", "", "", "");
            DtCustomers.Rows.Add(6, "Mark Jacobs", "324", "Rohmampton Close", "", "", "", "", "", "");
            DtCustomers.Rows.Add(7, "Lucas Lewis", "454", "Gotham City Putlock 5th St", "", "", "", "", "", "");
            DtCustomers.Rows.Add(8, "Brian James", "6776", " Disticnion Boulevard", "", "", "", "", "", "");
            DtCustomers.Rows.Add(9, "Anthony Hopkins", "768", "Old Town Road 78GH", "", "", "", "", "", "");


        }


  private void SelectCustomers()
        {

            SelCustomers.Columns.Add("AccountNo", typeof(int));
            SelCustomers.Columns.Add("AccountHolder");
            SelCustomers.Columns.Add("Holder Address");

        }       

var item == dataGridView1.Rows[e.RowIndex].Cells[0].Value;
Nitem = var item

        

        
        private void CustomersProfile_Load(object sender, EventArgs e)
        {

                CustomersTable();
                SelectCustomers();
                listBox1.DataSource = DtCustomers;
                listBox1.DisplayMember = "AccountHolder";

                listBox2.DataSource = SelCustomers;
                listBox2.DisplayMember = "AccountHolder";
            



        }
*/