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
    public partial class Sale : Form
    {
        static readonly BlApi.IBl s_bl = BlApi.Factory.Get();

        public Sale()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            BO.Sale sale = new BO.Sale();

            sale.IdProduct = (int)numericUpDownID.Value;
            sale.RequiredQuantity = (int)numericUpDownQToSale.Value;
            sale.TotalPrice = (int)numericUpDownPToSale.Value;

            // המרה לערך בולאני
            if (comboBoxIfClub.SelectedItem != null)
            {
                string selectedItem = comboBoxIfClub.SelectedItem.ToString();
                sale.IfClub = selectedItem.Equals("true", StringComparison.OrdinalIgnoreCase); // המרה ל- bool
            }
            else
            {
                sale.IfClub = false;
            }

            sale.StartDate = dateTimePickerStart.Value;
            sale.FinishDate = dateTimePickerFinish.Value;

            s_bl.Sale.Create(sale);

            // ריקון השדות
            numericUpDownID.Value = 0;
            numericUpDownQToSale.Value = 0;
            numericUpDownPToSale.Value = 0;
            comboBoxIfClub.SelectedIndex = -1; // או 0 אם אתה רוצה לבחור את הפריט הראשון
            dateTimePickerStart.Value = DateTime.Now; // או תאריך ברירת מחדל אחר
            dateTimePickerFinish.Value = DateTime.Now; // או תאריך ברירת מחדל אחר
        }

        private void update_Click(object sender, EventArgs e)
        {
            BO.Sale sale = new BO.Sale(
                                    (int)numericUpCode.Value,
                                    (int)numericUpDown1.Value,
                                    (int)numericUpDown2.Value,
                                    (int)numericUpDown3.Value,
                                    comboBox1.SelectedItem != null && (bool)comboBox1.SelectedItem,
                                    dateTimePicker1.Value,
                                    dateTimePicker2.Value
                                    );

            s_bl.Sale.Update(sale);

            // ריקון השדות
            numericUpCode.Value = 0;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxDelete.Text);

            s_bl.Sale.Delete(id);

            textBoxDelete.Text = string.Empty;
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            List<BO.Sale?> list = s_bl.Sale.ReadAll(null);

            foreach (var sale in list)
            {
                if (sale != null)
                {
                    salesList.Items.Add($"Id: {sale.Id}");
                    salesList.Items.Add($"IdProduct: {sale.IdProduct}");
                    salesList.Items.Add($"RequiredQuantity: {sale.RequiredQuantity}");
                    salesList.Items.Add($"TotalPrice: {sale.TotalPrice}");
                    salesList.Items.Add($"IfClub: {sale.IfClub}");
                    salesList.Items.Add($"StartDate: {sale.StartDate}");
                    salesList.Items.Add($"FinishDate: {sale.FinishDate}");
                    salesList.Items.Add("");
                    salesList.Items.Add("----------------------  ");
                    salesList.Items.Add("");
                }
            }
        }
    }
}
