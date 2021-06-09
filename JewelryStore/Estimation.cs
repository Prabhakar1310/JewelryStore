using JewelryStore.BL;
using JewelryStore.Dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JewelryStore
{
    public partial class Estimation : Form
    {
        private Customer customer;
        public Estimation(Customer customer)
        {
            this.customer = customer;
            InitializeComponent();
            this.WelcomeLbl.Text = "Welcome: " + customer.CustomerType.ToString();
            DiscountTextBox.Visible = DiscountInfo.IsDiscountApplicable(customer.CustomerType);
            DiscountLbl.Visible = DiscountInfo.IsDiscountApplicable(customer.CustomerType);
            DiscountTextBox.Text = DiscountInfo.GetDiscountNumber(customer.CustomerType).ToString();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            decimal goldPrice;
            decimal.TryParse(GoldPriceTextBox.Text, out goldPrice);
            decimal weight;
            decimal.TryParse(WeightTextBox.Text, out weight);
            var discount = DiscountInfo.GetDiscountNumber(customer.CustomerType);
            var total = (goldPrice * weight) * (100 - discount) / 100;
            TotalPriceTextBox.Text = total.ToString();
        }

        private void Estimation_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainForm = Application.OpenForms[0]; // get the Main Form
            mainForm.Show();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintToFileBtn_Click(object sender, EventArgs e)
        {
            var buildDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            PrintToFile print = new PrintToFile(buildDir+Resource.PathToStoreFile);
            var isPrintSuccessFul = print.Print(TotalPriceTextBox.Text);
            if (isPrintSuccessFul)
            { MessageBox.Show("Successfully saved to File"); }
            else
                MessageBox.Show("Error in saving to file");
        }

        private void PrintToScreenBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TotalPriceTextBox.Text);
        }

        private void PrintToPaperBtn_Click(object sender, EventArgs e)
        {
            PrintToPaper printToPaper = new PrintToPaper();
            var isPrintSuccessFul = printToPaper.Print(TotalPriceTextBox.Text);
            if (isPrintSuccessFul)
                MessageBox.Show("Successfully Printed to Paper");
            else
                MessageBox.Show("Error in Printing to paper");
        }
    }
}
