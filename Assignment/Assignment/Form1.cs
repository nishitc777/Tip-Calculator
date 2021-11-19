using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Assignment
{

    public partial class Form1 : Form 
    // Application Window Class.
    {

        public Form1() 
        // Initialializing the window and the values.
        {
            InitializeComponent();
            Bill_Amount.Text = "0.00";
            Tip_Amount.Value = 0;
            Number_Of_People.Value = 0;
            // Both Tip_Amount and Number_Of_People values are in
            // 0 to 100 range.
            GetZeroOutput();
            // User-defined Function Call.
        }

        private void GetZeroOutput()
        // Function definition.
        {
            Tip_Per_Person.Text = "0.00";
            Total_Per_Person.Text = "0.00";
        }

        private void GetFinalOutput(object sender, EventArgs e)
        // Gets called when the user clicks the "Get Output" button.
        {
       
            try
            // Exception handling.
            {
                Decimal Bill, Tip, Total;
                Bill = Math.Abs(Convert.ToDecimal(Bill_Amount.Text));
                // Negative value will be taken as its positive counterpart
                // for the Bill.
                Decimal PerPerson = Bill / Number_Of_People.Value;
                Tip = PerPerson * Tip_Amount.Value * (decimal)0.01;
                Total = PerPerson + Tip;
                Tip_Per_Person.Text = Tip.ToString("0.00");
                Total_Per_Person.Text = Total.ToString("0.00");
                Bill_Amount.Text = Bill.ToString();
            }
            
            catch (FormatException) 
            // When Bill contains non-numeric values.
            {
                GetZeroOutput();
                MessageBox.Show("Bill must contain numeric values only!");
            }
            
            catch (ArithmeticException) 
            // When dividing by zero (Number of people = 0) or the Bill
            // is out of range.
            {
                GetZeroOutput();
                if (Number_Of_People.Value == 0)
                {
                    MessageBox.Show("Number of people cannot be zero!");
                }
                else
                {
                    MessageBox.Show("The value of Bill is too high!");
                }
            }

        }
    
    }

}
