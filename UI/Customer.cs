using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;
using DO;

namespace UI
{
    public partial class Customer : Form
    {
        static readonly BlApi.IBl c_bl = BlApi.Factory.Get();

        public Customer()
        {
            InitializeComponent();
        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // בודק אם התו שהמשתמש מנסה להקליד הוא מספר או תו רווח
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // אם לא, מונע את ההקלדה
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            BO.Customer customer = new BO.Customer(
                int.Parse(textBoxId.Text), textBoxName.Text, textBoxPhone.Text, textBoxAddress.Text);

            c_bl.Customer.Create(customer);

            // ריקון ה-TextBox לאחר הוספת הלקוח
            textBoxId.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxPhone.Text = string.Empty;
            textBoxAddress.Text = string.Empty;
        }

        private void update_Click(object sender, EventArgs e)
        {
            BO.Customer customer = new BO.Customer(
                int.Parse(textBox4.Text), textBox3.Text, textBox2.Text, textBox1.Text);

            c_bl.Customer.Update(customer);

            // ריקון ה-TextBox לאחר הוספת הלקוח
            textBox4.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox1.Text = string.Empty;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox5.Text);

            c_bl.Customer.Delete(id);

            textBox5.Text = string.Empty;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            List<BO.Customer?> list = c_bl.Customer.ReadAll();

            foreach (var customer in list)
            {
                if (customer != null)
                {
                    costomersList.Items.Add($"id: {customer.Id}");
                    costomersList.Items.Add($"name: {customer.CustomerName}");
                    costomersList.Items.Add($"phone: {customer.CustomerPhone}");
                    costomersList.Items.Add($"address: {customer.CustomerAddress}");
                    costomersList.Items.Add("");
                    costomersList.Items.Add("----------------------  ");
                    costomersList.Items.Add("");
                }
            }
        }

    }
}
