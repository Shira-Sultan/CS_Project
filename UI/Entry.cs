namespace UI
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void management_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.ShowDialog();
        }

        private void cashier_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }
    }
}