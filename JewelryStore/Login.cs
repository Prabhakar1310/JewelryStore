using JewelryStore.Dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JewelryStore
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            CustomerData customerData = new CustomerData();
            Customer customer = customerData.GetCustomerData(UserNameTextBox.Text, PasswordTextBox.Text);

            if (customer != null)
            {
                Estimation estimationForm = new Estimation(customer);
                this.Hide();
                estimationForm.Show();
            }
            else
                MessageBox.Show("Invalid UserName or Password");
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            UserNameTextBox.Clear();
            PasswordTextBox.Clear();
        }
    }
}
