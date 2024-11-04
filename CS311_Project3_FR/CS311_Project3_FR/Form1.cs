using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS311_Project3_FR
{
    public partial class Form1 : Form
    {
        // Prices for pizza and toppings
        private const double SmallPrice = 10.00;
        private const double MediumPrice = 12.00;
        private const double LargePrice = 14.00;
        private const double XLargePrice = 16.00;
        private const double GinormousPrice = 18.00;
        private const double ToppingPrice = 1.50; // for Meat Toppings
        private const double OtherToppingPrice = 1.00; // for all other toppings
        private const double TaxRate = 0.09; // 9% tax

        public Form1()
        {
            InitializeComponent();
            // ComboBox with sizes
            cboSize.Items.AddRange(new object[] { "Small", "Medium", "Large", "X-Large", "Ginormous" });
            cboSize.SelectedIndex = 2; // Default to Large
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Summarize();
        }

        private void Summarize()
        {
            double subtotal = 0.00;

            // Calculate price 
            switch (cboSize.SelectedItem.ToString())
            {
                case "Small":
                    subtotal += SmallPrice;
                    break;
                case "Medium":
                    subtotal += MediumPrice;
                    break;
                case "Large":
                    subtotal += LargePrice;
                    break;
                case "X-Large":
                    subtotal += XLargePrice;
                    break;
                case "Ginormous":
                    subtotal += GinormousPrice;
                    break;
            }
            // Calculate the price for selected toppings
            if (ckbPepperoni.Checked) subtotal += ToppingPrice;
            if (ckbSausage.Checked) subtotal += ToppingPrice;
            if (ckbCanadianBacon.Checked) subtotal += ToppingPrice;
            if (ckbSpicyItalianSausage.Checked) subtotal += ToppingPrice;
            if (ckbMushrooms.Checked) subtotal += OtherToppingPrice;
            if (ckbOnion.Checked) subtotal += OtherToppingPrice;
            if (ckbGreenPepper.Checked) subtotal += OtherToppingPrice;
            if (ckbBlackOlives.Checked) subtotal += OtherToppingPrice;

            // Calculate tax and total
            double tax = subtotal * TaxRate;
            double total = subtotal + tax;

            // Results
            txtSubTotal.Text = subtotal.ToString("C");
            txtTax.Text = tax.ToString("C");
            txtTotal.Text = total.ToString("C");

            // Display order summary in RichTextBox
            rtfOrderSummary.Clear();
            rtfOrderSummary.AppendText("Pizza Order Summary\n");
            rtfOrderSummary.AppendText("---------------------------\n");
            rtfOrderSummary.AppendText($"Size: {cboSize.SelectedItem}\n");
            rtfOrderSummary.AppendText($"Crust: {GetCrustType()}\n");
            rtfOrderSummary.AppendText("Toppings:\n");
            AppendToppingsSummary();
            rtfOrderSummary.AppendText($"Subtotal: {subtotal:C}\n");
            rtfOrderSummary.AppendText($"Tax: {tax:C}\n");
            rtfOrderSummary.AppendText($"Total: {total:C}\n");
        }

        private string GetCrustType()
        {
            if (rdoThin.Checked) return "Thin";
            if (rdoThick.Checked) return "Thick";
            return "Regular"; // Default to Regular
        }

        private void AppendToppingsSummary()
        {
            if (ckbPepperoni.Checked) rtfOrderSummary.AppendText("- Pepperoni\n");
            if (ckbSausage.Checked) rtfOrderSummary.AppendText("- Sausage\n");
            if (ckbCanadianBacon.Checked) rtfOrderSummary.AppendText("- Canadian Bacon\n");
            if (ckbSpicyItalianSausage.Checked) rtfOrderSummary.AppendText("- Spicy Italian Sausage\n");
            if (ckbMushrooms.Checked) rtfOrderSummary.AppendText("- Mushrooms\n");
            if (ckbOnion.Checked) rtfOrderSummary.AppendText("- Onions\n");
            if (ckbGreenPepper.Checked) rtfOrderSummary.AppendText("- Green Peppers\n");
            if (ckbBlackOlives.Checked) rtfOrderSummary.AppendText("- Black Olives\n");
        }
    }
}
