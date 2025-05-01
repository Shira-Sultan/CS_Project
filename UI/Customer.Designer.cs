namespace UI
{
    partial class Customer
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
            customerTitle = new Label();
            customerCrud = new TabControl();
            createCustomer = new TabPage();
            add = new Button();
            textBoxPhone = new TextBox();
            label3 = new Label();
            textBoxAddress = new TextBox();
            label2 = new Label();
            textBoxName = new TextBox();
            label1 = new Label();
            textBoxId = new TextBox();
            id = new Label();
            updateCustomer = new TabPage();
            update = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            deletedCustomer = new TabPage();
            delete = new Button();
            textBox5 = new TextBox();
            label8 = new Label();
            displayCustomer = new TabPage();
            costomersList = new ListBox();
            customerCrud.SuspendLayout();
            createCustomer.SuspendLayout();
            updateCustomer.SuspendLayout();
            deletedCustomer.SuspendLayout();
            displayCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // customerTitle
            // 
            customerTitle.AutoSize = true;
            customerTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customerTitle.Location = new Point(375, 21);
            customerTitle.Name = "customerTitle";
            customerTitle.Size = new Size(79, 28);
            customerTitle.TabIndex = 0;
            customerTitle.Text = "לקוחות";
            // 
            // customerCrud
            // 
            customerCrud.Controls.Add(createCustomer);
            customerCrud.Controls.Add(updateCustomer);
            customerCrud.Controls.Add(deletedCustomer);
            customerCrud.Controls.Add(displayCustomer);
            customerCrud.Location = new Point(74, 69);
            customerCrud.Name = "customerCrud";
            customerCrud.RightToLeft = RightToLeft.Yes;
            customerCrud.RightToLeftLayout = true;
            customerCrud.SelectedIndex = 0;
            customerCrud.Size = new Size(655, 345);
            customerCrud.TabIndex = 1;
            // 
            // createCustomer
            // 
            createCustomer.Controls.Add(add);
            createCustomer.Controls.Add(textBoxPhone);
            createCustomer.Controls.Add(label3);
            createCustomer.Controls.Add(textBoxAddress);
            createCustomer.Controls.Add(label2);
            createCustomer.Controls.Add(textBoxName);
            createCustomer.Controls.Add(label1);
            createCustomer.Controls.Add(textBoxId);
            createCustomer.Controls.Add(id);
            createCustomer.Location = new Point(4, 29);
            createCustomer.Name = "createCustomer";
            createCustomer.Padding = new Padding(3);
            createCustomer.RightToLeft = RightToLeft.Yes;
            createCustomer.Size = new Size(647, 312);
            createCustomer.TabIndex = 0;
            createCustomer.Text = "הוספה";
            createCustomer.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            add.Location = new Point(48, 247);
            add.Name = "add";
            add.Size = new Size(94, 29);
            add.TabIndex = 2;
            add.Text = "הוסף";
            add.UseVisualStyleBackColor = true;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(396, 221);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(125, 27);
            textBoxPhone.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(536, 173);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 0;
            label3.Text = "מספר טלפון:";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(396, 166);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(125, 27);
            textBoxAddress.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(569, 228);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 0;
            label2.Text = "כתובת:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(396, 105);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(590, 108);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 0;
            label1.Text = "שם:";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(396, 45);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(125, 27);
            textBoxId.TabIndex = 1;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(536, 48);
            id.Name = "id";
            id.Size = new Size(88, 20);
            id.TabIndex = 0;
            id.Text = "תעודת זהות:";
            // 
            // updateCustomer
            // 
            updateCustomer.Controls.Add(update);
            updateCustomer.Controls.Add(textBox1);
            updateCustomer.Controls.Add(label4);
            updateCustomer.Controls.Add(textBox2);
            updateCustomer.Controls.Add(label5);
            updateCustomer.Controls.Add(textBox3);
            updateCustomer.Controls.Add(label6);
            updateCustomer.Controls.Add(textBox4);
            updateCustomer.Controls.Add(label7);
            updateCustomer.Location = new Point(4, 29);
            updateCustomer.Name = "updateCustomer";
            updateCustomer.Padding = new Padding(3);
            updateCustomer.RightToLeft = RightToLeft.Yes;
            updateCustomer.Size = new Size(647, 312);
            updateCustomer.TabIndex = 1;
            updateCustomer.Text = "עדכון";
            updateCustomer.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            update.Location = new Point(40, 245);
            update.Name = "update";
            update.Size = new Size(94, 29);
            update.TabIndex = 11;
            update.Text = "עדכן";
            update.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(393, 219);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(533, 171);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 3;
            label4.Text = "מספר טלפון:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(393, 164);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(566, 226);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 4;
            label5.Text = "כתובת:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(393, 103);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(587, 106);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 5;
            label6.Text = "שם:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(393, 42);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(533, 45);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 6;
            label7.Text = "תעודת זהות:";
            // 
            // deletedCustomer
            // 
            deletedCustomer.Controls.Add(delete);
            deletedCustomer.Controls.Add(textBox5);
            deletedCustomer.Controls.Add(label8);
            deletedCustomer.Location = new Point(4, 29);
            deletedCustomer.Name = "deletedCustomer";
            deletedCustomer.Padding = new Padding(3);
            deletedCustomer.Size = new Size(647, 312);
            deletedCustomer.TabIndex = 2;
            deletedCustomer.Text = "מחיקה";
            deletedCustomer.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            delete.Location = new Point(47, 241);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 13;
            delete.Text = "מחיקה";
            delete.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(388, 45);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(528, 48);
            label8.Name = "label8";
            label8.Size = new Size(88, 20);
            label8.TabIndex = 11;
            label8.Text = "תעודת זהות:";
            // 
            // displayCustomer
            // 
            displayCustomer.Controls.Add(costomersList);
            displayCustomer.Location = new Point(4, 29);
            displayCustomer.Name = "displayCustomer";
            displayCustomer.Padding = new Padding(3);
            displayCustomer.Size = new Size(647, 312);
            displayCustomer.TabIndex = 3;
            displayCustomer.Text = "תצוגה";
            displayCustomer.UseVisualStyleBackColor = true;
            // 
            // costomersList
            // 
            costomersList.FormattingEnabled = true;
            costomersList.ItemHeight = 20;
            costomersList.Location = new Point(16, 23);
            costomersList.Name = "costomersList";
            costomersList.RightToLeft = RightToLeft.No;
            costomersList.Size = new Size(419, 264);
            costomersList.TabIndex = 0;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(customerCrud);
            Controls.Add(customerTitle);
            Name = "Customer";
            Text = "Customer";
            Load += Customer_Load;
            customerCrud.ResumeLayout(false);
            createCustomer.ResumeLayout(false);
            createCustomer.PerformLayout();
            updateCustomer.ResumeLayout(false);
            updateCustomer.PerformLayout();
            deletedCustomer.ResumeLayout(false);
            deletedCustomer.PerformLayout();
            displayCustomer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label customerTitle;
        private TabControl customerCrud;
        private TabPage createCustomer;
        private TabPage updateCustomer;
        private TabPage deletedCustomer;
        private TabPage displayCustomer;
        private Label id;
        private TextBox textBoxId;
        private TextBox textBoxPhone;
        private Label label3;
        private TextBox textBoxAddress;
        private Label label2;
        private TextBox textBoxName;
        private Label label1;
        private Button add;
        private Button update;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox4;
        private Label label7;
        private Button delete;
        private TextBox textBox5;
        private Label label8;
        private ListBox costomersList;
    }
}