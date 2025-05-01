namespace UI
{
    partial class Product
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
            productsList = new ListBox();
            delete = new Button();
            textBoxDelete = new TextBox();
            label8 = new Label();
            updateCustomer = new TabPage();
            comboBoxCat = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            update = new Button();
            numericUpDown2 = new NumericUpDown();
            productCode = new Label();
            label4 = new Label();
            textBoxCode = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            deletedCustomer = new TabPage();
            displayCustomer = new TabPage();
            customerCrud = new TabControl();
            createCustomer = new TabPage();
            comboBoxCategory = new ComboBox();
            numericUpDownQuantity = new NumericUpDown();
            numericUpDownPrice = new NumericUpDown();
            add = new Button();
            category = new Label();
            quantity = new Label();
            price = new Label();
            textBoxName = new TextBox();
            name = new Label();
            productTitle = new Label();
            updateCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            deletedCustomer.SuspendLayout();
            displayCustomer.SuspendLayout();
            customerCrud.SuspendLayout();
            createCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            SuspendLayout();
            // 
            // productsList
            // 
            productsList.FormattingEnabled = true;
            productsList.ItemHeight = 20;
            productsList.Location = new Point(16, 23);
            productsList.Name = "productsList";
            productsList.RightToLeft = RightToLeft.No;
            productsList.Size = new Size(419, 264);
            productsList.TabIndex = 0;
            // 
            // delete
            // 
            delete.Location = new Point(47, 241);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 13;
            delete.Text = "מחיקה";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // textBoxDelete
            // 
            textBoxDelete.Location = new Point(388, 45);
            textBoxDelete.Name = "textBoxDelete";
            textBoxDelete.Size = new Size(125, 27);
            textBoxDelete.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(531, 51);
            label8.Name = "label8";
            label8.Size = new Size(68, 20);
            label8.TabIndex = 11;
            label8.Text = "קוד מוצר:";
            // 
            // updateCustomer
            // 
            updateCustomer.Controls.Add(comboBoxCat);
            updateCustomer.Controls.Add(numericUpDown1);
            updateCustomer.Controls.Add(update);
            updateCustomer.Controls.Add(numericUpDown2);
            updateCustomer.Controls.Add(productCode);
            updateCustomer.Controls.Add(label4);
            updateCustomer.Controls.Add(textBoxCode);
            updateCustomer.Controls.Add(label1);
            updateCustomer.Controls.Add(textBox1);
            updateCustomer.Controls.Add(label2);
            updateCustomer.Controls.Add(label3);
            updateCustomer.Location = new Point(4, 29);
            updateCustomer.Name = "updateCustomer";
            updateCustomer.Padding = new Padding(3);
            updateCustomer.RightToLeft = RightToLeft.Yes;
            updateCustomer.Size = new Size(647, 312);
            updateCustomer.TabIndex = 1;
            updateCustomer.Text = "עדכון";
            updateCustomer.UseVisualStyleBackColor = true;
            // 
            // comboBoxCat
            // 
            comboBoxCat.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCat.FormattingEnabled = true;
            comboBoxCat.Items.AddRange(new object[] { "Adult_glasses", "Children_glasses", "Sun_glasses", "Lenses", "Accessories" });
            comboBoxCat.Location = new Point(381, 139);
            comboBoxCat.Name = "comboBoxCat";
            comboBoxCat.RightToLeft = RightToLeft.No;
            comboBoxCat.Size = new Size(125, 28);
            comboBoxCat.TabIndex = 12;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(381, 253);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(125, 27);
            numericUpDown1.TabIndex = 10;
            // 
            // update
            // 
            update.Location = new Point(35, 260);
            update.Name = "update";
            update.Size = new Size(94, 29);
            update.TabIndex = 12;
            update.Text = "עדכן";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(381, 198);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(125, 27);
            numericUpDown2.TabIndex = 11;
            // 
            // productCode
            // 
            productCode.AutoSize = true;
            productCode.Location = new Point(539, 39);
            productCode.Name = "productCode";
            productCode.Size = new Size(68, 20);
            productCode.TabIndex = 8;
            productCode.Text = "קוד מוצר:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(539, 91);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 8;
            label4.Text = "שם מוצר:";
            // 
            // textBoxCode
            // 
            textBoxCode.Location = new Point(381, 32);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(125, 27);
            textBoxCode.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(546, 147);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 5;
            label1.Text = "קטגוריה";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(381, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(518, 260);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 6;
            label2.Text = "כמות במלאי:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(564, 205);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 7;
            label3.Text = "מחיר:";
            // 
            // deletedCustomer
            // 
            deletedCustomer.Controls.Add(delete);
            deletedCustomer.Controls.Add(textBoxDelete);
            deletedCustomer.Controls.Add(label8);
            deletedCustomer.Location = new Point(4, 29);
            deletedCustomer.Name = "deletedCustomer";
            deletedCustomer.Padding = new Padding(3);
            deletedCustomer.Size = new Size(647, 312);
            deletedCustomer.TabIndex = 2;
            deletedCustomer.Text = "מחיקה";
            deletedCustomer.UseVisualStyleBackColor = true;
            // 
            // displayCustomer
            // 
            displayCustomer.Controls.Add(productsList);
            displayCustomer.Location = new Point(4, 29);
            displayCustomer.Name = "displayCustomer";
            displayCustomer.Padding = new Padding(3);
            displayCustomer.Size = new Size(647, 312);
            displayCustomer.TabIndex = 3;
            displayCustomer.Text = "תצוגה";
            displayCustomer.UseVisualStyleBackColor = true;
            // 
            // customerCrud
            // 
            customerCrud.Controls.Add(createCustomer);
            customerCrud.Controls.Add(updateCustomer);
            customerCrud.Controls.Add(deletedCustomer);
            customerCrud.Controls.Add(displayCustomer);
            customerCrud.Location = new Point(73, 77);
            customerCrud.Name = "customerCrud";
            customerCrud.RightToLeft = RightToLeft.Yes;
            customerCrud.RightToLeftLayout = true;
            customerCrud.SelectedIndex = 0;
            customerCrud.Size = new Size(655, 345);
            customerCrud.TabIndex = 3;
            // 
            // createCustomer
            // 
            createCustomer.Controls.Add(comboBoxCategory);
            createCustomer.Controls.Add(numericUpDownQuantity);
            createCustomer.Controls.Add(numericUpDownPrice);
            createCustomer.Controls.Add(add);
            createCustomer.Controls.Add(category);
            createCustomer.Controls.Add(quantity);
            createCustomer.Controls.Add(price);
            createCustomer.Controls.Add(textBoxName);
            createCustomer.Controls.Add(name);
            createCustomer.Location = new Point(4, 29);
            createCustomer.Name = "createCustomer";
            createCustomer.Padding = new Padding(3);
            createCustomer.RightToLeft = RightToLeft.Yes;
            createCustomer.Size = new Size(647, 312);
            createCustomer.TabIndex = 0;
            createCustomer.Text = "הוספה";
            createCustomer.UseVisualStyleBackColor = true;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Adult_glasses", "Children_glasses", "Sun_glasses", "Lenses", "Accessories" });
            comboBoxCategory.Location = new Point(381, 110);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.RightToLeft = RightToLeft.No;
            comboBoxCategory.Size = new Size(125, 28);
            comboBoxCategory.TabIndex = 4;
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(381, 233);
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(125, 27);
            numericUpDownQuantity.TabIndex = 3;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Location = new Point(381, 172);
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(125, 27);
            numericUpDownPrice.TabIndex = 3;
            // 
            // add
            // 
            add.Location = new Point(38, 254);
            add.Name = "add";
            add.Size = new Size(94, 29);
            add.TabIndex = 2;
            add.Text = "הוסף";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // category
            // 
            category.AutoSize = true;
            category.Location = new Point(546, 118);
            category.Name = "category";
            category.Size = new Size(62, 20);
            category.TabIndex = 0;
            category.Text = "קטגוריה";
            // 
            // quantity
            // 
            quantity.AutoSize = true;
            quantity.Location = new Point(518, 240);
            quantity.Name = "quantity";
            quantity.Size = new Size(90, 20);
            quantity.TabIndex = 0;
            quantity.Text = "כמות במלאי:";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(564, 179);
            price.Name = "price";
            price.Size = new Size(44, 20);
            price.TabIndex = 0;
            price.Text = "מחיר:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(381, 45);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 1;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(539, 52);
            name.Name = "name";
            name.Size = new Size(69, 20);
            name.TabIndex = 0;
            name.Text = "שם מוצר:";
            // 
            // productTitle
            // 
            productTitle.AutoSize = true;
            productTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            productTitle.Location = new Point(374, 29);
            productTitle.Name = "productTitle";
            productTitle.Size = new Size(77, 28);
            productTitle.TabIndex = 2;
            productTitle.Text = "מוצרים";
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(customerCrud);
            Controls.Add(productTitle);
            Name = "Product";
            Text = "Product";
            Load += Product_Load;
            updateCustomer.ResumeLayout(false);
            updateCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            deletedCustomer.ResumeLayout(false);
            deletedCustomer.PerformLayout();
            displayCustomer.ResumeLayout(false);
            customerCrud.ResumeLayout(false);
            createCustomer.ResumeLayout(false);
            createCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox productsList;
        private Button delete;
        private TextBox textBoxDelete;
        private Label label8;
        private TabPage updateCustomer;
        private TabPage deletedCustomer;
        private TabPage displayCustomer;
        private TabControl customerCrud;
        private TabPage createCustomer;
        private Button add;
        private Label category;
        private Label price;
        private TextBox textBoxName;
        private Label name;
        private Label productTitle;
        private NumericUpDown numericUpDownPrice;
        private NumericUpDown numericUpDownQuantity;
        private Label quantity;
        private ComboBox comboBoxCategory;
        private Button update;
        private ComboBox comboBoxCat;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label4;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label productCode;
        private TextBox textBoxCode;
    }
}