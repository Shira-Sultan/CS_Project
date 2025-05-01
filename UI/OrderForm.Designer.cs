namespace UI
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            orderTitle = new Label();
            name = new Label();
            numericUpDownQuantity = new NumericUpDown();
            quantity = new Label();
            bntCloseOrder = new Button();
            btnAddToOrder = new Button();
            dataGridViewOrder = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewComboBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            labelTotalPriceToOrder = new Label();
            textBoxName = new TextBox();
            totalP = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).BeginInit();
            SuspendLayout();
            // 
            // orderTitle
            // 
            orderTitle.AutoSize = true;
            orderTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            orderTitle.Location = new Point(373, 9);
            orderTitle.Name = "orderTitle";
            orderTitle.Size = new Size(94, 28);
            orderTitle.TabIndex = 6;
            orderTitle.Text = "סל קניות";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(720, 89);
            name.Name = "name";
            name.Size = new Size(69, 20);
            name.TabIndex = 7;
            name.Text = "שם מוצר:";
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(581, 135);
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(125, 27);
            numericUpDownQuantity.TabIndex = 10;
            // 
            // quantity
            // 
            quantity.AutoSize = true;
            quantity.Location = new Point(744, 142);
            quantity.Name = "quantity";
            quantity.Size = new Size(45, 20);
            quantity.TabIndex = 9;
            quantity.Text = "כמות:";
            // 
            // bntCloseOrder
            // 
            bntCloseOrder.Location = new Point(12, 408);
            bntCloseOrder.Name = "bntCloseOrder";
            bntCloseOrder.Size = new Size(127, 29);
            bntCloseOrder.TabIndex = 12;
            bntCloseOrder.Text = "סיום הזמנה";
            bntCloseOrder.UseVisualStyleBackColor = true;
            bntCloseOrder.Click += bntCloseOrder_Click;
            // 
            // btnAddToOrder
            // 
            btnAddToOrder.Location = new Point(619, 207);
            btnAddToOrder.Name = "btnAddToOrder";
            btnAddToOrder.Size = new Size(127, 29);
            btnAddToOrder.TabIndex = 12;
            btnAddToOrder.Text = "הוסף להזמנה";
            btnAddToOrder.UseVisualStyleBackColor = true;
            btnAddToOrder.Click += btnAddToOrder_Click;
            // 
            // dataGridViewOrder
            // 
            dataGridViewOrder.BackgroundColor = SystemColors.Control;
            dataGridViewOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrder.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewOrder.Location = new Point(12, 57);
            dataGridViewOrder.Name = "dataGridViewOrder";
            dataGridViewOrder.RowHeadersWidth = 51;
            dataGridViewOrder.RowTemplate.Height = 29;
            dataGridViewOrder.Size = new Size(556, 335);
            dataGridViewOrder.TabIndex = 13;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "שם מוצר";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "כמות";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "מבצעים";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Resizable = DataGridViewTriState.True;
            Column3.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Column4
            // 
            Column4.HeaderText = "מחיר";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // labelTotalPriceToOrder
            // 
            labelTotalPriceToOrder.AutoSize = true;
            labelTotalPriceToOrder.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotalPriceToOrder.Location = new Point(492, 408);
            labelTotalPriceToOrder.Name = "labelTotalPriceToOrder";
            labelTotalPriceToOrder.RightToLeft = RightToLeft.Yes;
            labelTotalPriceToOrder.Size = new Size(76, 23);
            labelTotalPriceToOrder.TabIndex = 14;
            labelTotalPriceToOrder.Text = "לתשלום:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(581, 82);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 8;
            // 
            // totalP
            // 
            totalP.AutoSize = true;
            totalP.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            totalP.ForeColor = SystemColors.ControlText;
            totalP.Location = new Point(445, 408);
            totalP.Name = "totalP";
            totalP.Size = new Size(50, 23);
            totalP.TabIndex = 15;
            totalP.Text = "00.00";
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(totalP);
            Controls.Add(labelTotalPriceToOrder);
            Controls.Add(dataGridViewOrder);
            Controls.Add(btnAddToOrder);
            Controls.Add(bntCloseOrder);
            Controls.Add(numericUpDownQuantity);
            Controls.Add(quantity);
            Controls.Add(textBoxName);
            Controls.Add(name);
            Controls.Add(orderTitle);
            Name = "OrderForm";
            RightToLeft = RightToLeft.Yes;
            Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label orderTitle;
        private Label name;
        private NumericUpDown numericUpDownQuantity;
        private Label quantity;
        private Button bntCloseOrder;
        private Button btnAddToOrder;
        private DataGridView dataGridViewOrder;
        private Label labelTotalPriceToOrder;
        private TextBox textBoxName;
        private Label totalP;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewComboBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}