using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                OrderForm orderForm = new OrderForm(int.Parse(textBoxLogin.Text));
                orderForm.ShowDialog();
            }
            catch (BO.Bl_InValidInput ex)
            {
                throw new BO.Bl_InValidInput("Error! Invalid input.", ex);
            }
        }
    }
}
