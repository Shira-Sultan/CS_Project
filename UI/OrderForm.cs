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
    public partial class OrderForm : Form
    {
        static readonly BlApi.IBl o_bl = BlApi.Factory.Get();
        BO.Order order = new BO.Order();

        public OrderForm(int id)
        {
            InitializeComponent();

            if (o_bl.Customer.IsExist(id))
                order.IfClub = true;
            order.IfClub = false;
        }

        //private void btnAddToOrder_Click(object sender, EventArgs e)
        //{
        //    string name = textBoxName.Text;
        //    int quantity = (int)numericUpDownQuantity.Value;

        //    // קבלת המוצר לפי השם
        //    BO.Product? product = o_bl.Product.Read(p => p.ProductName == name);

        //    if (product != null)
        //    {
        //        bool isExists;
        //        if (order.ListProductInOrder == null)
        //            isExists = false;
        //        else
        //            isExists = order.ListProductInOrder.Any(p => p.Id == product.Id);

        //        // הוספת המוצר להזמנה
        //        List<BO.SaleInProduct> listSalesInProduct = o_bl.Order.AddProductToOrder(order, product.Id, quantity);

        //        // חיפוש המוצר בהזמנה כדי לקבל את TotalPrice
        //        var productInOrder = order.ListProductInOrder.FirstOrDefault(p => p.Id == product.Id);

        //        if (productInOrder != null)
        //        {
        //            // קבלת המחיר הכולל מהמוצר בהזמנה
        //            double totalPrice = productInOrder.TotalPrice;

        //            if (!isExists)
        //            {
        //                dataGridViewOrder.Rows.Add(name, productInOrder.Quantity, listSalesInProduct, totalPrice);
        //            }
        //            else
        //            {
        //                foreach (DataGridViewRow row in dataGridViewOrder.Rows)
        //                {
        //                    if (row.Cells["Column1"].Value.ToString() == name)
        //                    {
        //                        row.Cells["Column2"].Value = productInOrder.Quantity;
        //                        row.Cells["Column4"].Value = productInOrder.TotalPrice;
        //                        break;
        //                    }
        //                }
        //            }

        //            totalP.Text = order.TotalPriceForOrder.ToString();
        //        }
        //        else
        //        {
        //            MessageBox.Show("המוצר לא נמצא בהזמנה.");
        //        }
        //    }
        //    else
        //    {
        //        // טיפול במקרה שלא נמצא מוצר
        //        MessageBox.Show("המוצר לא נמצא.");
        //    }
        //    textBoxName.Clear();
        //    numericUpDownQuantity.Value = numericUpDownQuantity.Minimum;
        //}

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            int quantity = (int)numericUpDownQuantity.Value;

            // קבלת המוצר לפי השם
            BO.Product? product = o_bl.Product.Read(p => p.ProductName == name);

            if (product != null)
            {
                bool isExists;
                if (order.ListProductInOrder == null)
                    isExists = false;
                else
                    isExists = order.ListProductInOrder.Any(p => p.Id == product.Id);

                // הוספת המוצר להזמנה
                List<BO.SaleInProduct> listSalesInProduct = o_bl.Order.AddProductToOrder(order, product.Id, quantity);

                // חיפוש המוצר בהזמנה כדי לקבל את TotalPrice
                var productInOrder = order.ListProductInOrder.FirstOrDefault(p => p.Id == product.Id);

                if (productInOrder != null)
                {
                    // קבלת המחיר הכולל מהמוצר בהזמנה
                    double totalPrice = productInOrder.TotalPrice;

                    if (!isExists)
                    {
                        // הוספת שורה חדשה עם רשימת המבצעים
                        int rowIndex = dataGridViewOrder.Rows.Add(name, productInOrder.Quantity, null, totalPrice);

                        // קבלת ה-ComboBoxCell מהשורה החדשה
                        var comboBoxCell = dataGridViewOrder.Rows[rowIndex].Cells["Column3"] as DataGridViewComboBoxCell;
                        foreach (var sale in listSalesInProduct)
                        {
                            comboBoxCell.Items.Add(sale); // הוספת מבצעים ל-ComboBox
                        }
                    }
                    else
                    {
                        foreach (DataGridViewRow row in dataGridViewOrder.Rows)
                        {
                            if (row.Cells["Column1"].Value.ToString() == name)
                            {
                                row.Cells["Column2"].Value = productInOrder.Quantity;
                                row.Cells["Column4"].Value = productInOrder.TotalPrice;

                                // עדכון ComboBox עם רשימת המבצעים
                                var comboBoxCell = row.Cells["Column3"] as DataGridViewComboBoxCell;
                                comboBoxCell.Items.Clear(); // ניקוי הרשימה הקודמת
                                foreach (var sale in listSalesInProduct)
                                {
                                    comboBoxCell.Items.Add(sale); // הוספת מבצעים חדשים
                                }

                                break;
                            }
                        }
                    }

                    totalP.Text = order.TotalPriceForOrder.ToString();
                }
                else
                {
                    MessageBox.Show("המוצר לא נמצא בהזמנה.");
                }
            }
            else
            {
                // טיפול במקרה שלא נמצא מוצר
                MessageBox.Show("המוצר לא נמצא.");
            }
            textBoxName.Clear();
            numericUpDownQuantity.Value = numericUpDownQuantity.Minimum;
        }


        private void bntCloseOrder_Click(object sender, EventArgs e)
        {
            o_bl.Order.DoOrder(order);
            MessageBox.Show("הההזמה נקלטה בהצלחה!");
        }
    }
}
