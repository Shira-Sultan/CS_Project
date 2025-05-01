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
    public partial class Product : Form
    {
        static readonly BlApi.IBl p_bl = BlApi.Factory.Get();

        public Product()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            BO.Categories selectedCategory;
            if (!Enum.TryParse(comboBoxCategory.SelectedItem.ToString(), out selectedCategory))
            {
                // טיפול במקרה שבו ההמרה לא הצליחה
                MessageBox.Show("Invalid category selected.");
                return;
            }

            BO.Product product = new BO.Product();

            product.ProductName = textBoxName.Text;
            product.Category = selectedCategory;
            product.Price = (double)numericUpDown2.Value;
            product.Price = (int)numericUpDown1.Value;

            p_bl.Product.Create(product);

            // ריקון השדות לאחר ההוספה
            textBoxName.Clear();
            comboBoxCategory.SelectedIndex = -1; // לא לבחור קטגוריה
            numericUpDownPrice.Value = numericUpDownPrice.Minimum; // להחזיר לערך מינימלי
            numericUpDownQuantity.Value = numericUpDownQuantity.Minimum; // להחזיר לערך מינימלי
        }

        private void update_Click(object sender, EventArgs e)
        {
            BO.Categories selectedCategory;
            if (!Enum.TryParse(comboBoxCat.SelectedItem.ToString(), out selectedCategory))
            {
                // טיפול במקרה שבו ההמרה לא הצליחה
                MessageBox.Show("Invalid category selected.");
                return;
            }

            BO.Product product = new BO.Product(int.Parse(textBoxCode.Text), textBox1.Text,
                selectedCategory, (double)numericUpDown2.Value, (int)numericUpDown1.Value);
            p_bl.Product.Update(product);

            // ריקון השדות לאחר ההוספה
            textBoxCode.Clear();
            textBox1.Clear();
            comboBoxCat.SelectedIndex = -1; // לא לבחור קטגוריה
            numericUpDown2.Value = numericUpDown2.Minimum; // להחזיר לערך מינימלי
            numericUpDown1.Value = numericUpDown2.Minimum; // להחזיר לערך מינימלי
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxDelete.Text);

            p_bl.Product.Delete(id);

            textBoxDelete.Text = string.Empty;
        }

        private void Product_Load(object sender, EventArgs e)
        {
            List<BO.Product?> list = p_bl.Product.ReadAll(null);

            foreach (var product in list)
            {
                if (product != null)
                {
                    productsList.Items.Add($"id: {product.Id}");
                    productsList.Items.Add($"name: {product.ProductName}");
                    productsList.Items.Add($"category: {product.Category}");
                    productsList.Items.Add($"price: {product.Price}");
                    productsList.Items.Add($"quantity: {product.Quantity}");
                    productsList.Items.Add("");
                    productsList.Items.Add("----------------------  ");
                    productsList.Items.Add("");
                }
            }
        }
    }
}
