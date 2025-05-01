namespace UI
{
    partial class Sale
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
            customerCrud = new TabControl();
            createCustomer = new TabPage();
            dateTimePickerFinish = new DateTimePicker();
            dateTimePickerStart = new DateTimePicker();
            comboBoxIfClub = new ComboBox();
            numericUpDownPToSale = new NumericUpDown();
            numericUpDownID = new NumericUpDown();
            numericUpDownQToSale = new NumericUpDown();
            add = new Button();
            finishDate = new Label();
            startDate = new Label();
            isClub = new Label();
            priceToSale = new Label();
            quantityToSale = new Label();
            idProductToSale = new Label();
            updateCustomer = new TabPage();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            comboBox1 = new ComboBox();
            numericUpCode = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            updateSale = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            saleCode = new Label();
            deletedCustomer = new TabPage();
            delete = new Button();
            textBoxDelete = new TextBox();
            labelTםDeleteSale = new Label();
            displayCustomer = new TabPage();
            salesList = new ListBox();
            saleTitle = new Label();
            customerCrud.SuspendLayout();
            createCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPToSale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQToSale).BeginInit();
            updateCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            deletedCustomer.SuspendLayout();
            displayCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // customerCrud
            // 
            customerCrud.Controls.Add(createCustomer);
            customerCrud.Controls.Add(updateCustomer);
            customerCrud.Controls.Add(deletedCustomer);
            customerCrud.Controls.Add(displayCustomer);
            customerCrud.Location = new Point(57, 50);
            customerCrud.Name = "customerCrud";
            customerCrud.RightToLeft = RightToLeft.Yes;
            customerCrud.RightToLeftLayout = true;
            customerCrud.SelectedIndex = 0;
            customerCrud.Size = new Size(682, 380);
            customerCrud.TabIndex = 5;
            // 
            // createCustomer
            // 
            createCustomer.Controls.Add(dateTimePickerFinish);
            createCustomer.Controls.Add(dateTimePickerStart);
            createCustomer.Controls.Add(comboBoxIfClub);
            createCustomer.Controls.Add(numericUpDownPToSale);
            createCustomer.Controls.Add(numericUpDownID);
            createCustomer.Controls.Add(numericUpDownQToSale);
            createCustomer.Controls.Add(add);
            createCustomer.Controls.Add(finishDate);
            createCustomer.Controls.Add(startDate);
            createCustomer.Controls.Add(isClub);
            createCustomer.Controls.Add(priceToSale);
            createCustomer.Controls.Add(quantityToSale);
            createCustomer.Controls.Add(idProductToSale);
            createCustomer.Location = new Point(4, 29);
            createCustomer.Name = "createCustomer";
            createCustomer.Padding = new Padding(3);
            createCustomer.RightToLeft = RightToLeft.Yes;
            createCustomer.Size = new Size(674, 347);
            createCustomer.TabIndex = 0;
            createCustomer.Text = "הוספה";
            createCustomer.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerFinish
            // 
            dateTimePickerFinish.Location = new Point(237, 282);
            dateTimePickerFinish.Name = "dateTimePickerFinish";
            dateTimePickerFinish.Size = new Size(223, 27);
            dateTimePickerFinish.TabIndex = 5;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(237, 233);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(223, 27);
            dateTimePickerStart.TabIndex = 5;
            // 
            // comboBoxIfClub
            // 
            comboBoxIfClub.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxIfClub.FormattingEnabled = true;
            comboBoxIfClub.Items.AddRange(new object[] { "true", "false" });
            comboBoxIfClub.Location = new Point(335, 182);
            comboBoxIfClub.Name = "comboBoxIfClub";
            comboBoxIfClub.RightToLeft = RightToLeft.No;
            comboBoxIfClub.Size = new Size(125, 28);
            comboBoxIfClub.TabIndex = 4;
            // 
            // numericUpDownPToSale
            // 
            numericUpDownPToSale.Location = new Point(335, 132);
            numericUpDownPToSale.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownPToSale.Name = "numericUpDownPToSale";
            numericUpDownPToSale.Size = new Size(125, 27);
            numericUpDownPToSale.TabIndex = 3;
            // 
            // numericUpDownID
            // 
            numericUpDownID.Location = new Point(335, 31);
            numericUpDownID.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownID.Name = "numericUpDownID";
            numericUpDownID.Size = new Size(125, 27);
            numericUpDownID.TabIndex = 3;
            // 
            // numericUpDownQToSale
            // 
            numericUpDownQToSale.Location = new Point(335, 80);
            numericUpDownQToSale.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownQToSale.Name = "numericUpDownQToSale";
            numericUpDownQToSale.Size = new Size(125, 27);
            numericUpDownQToSale.TabIndex = 3;
            // 
            // add
            // 
            add.Location = new Point(24, 295);
            add.Name = "add";
            add.Size = new Size(94, 29);
            add.TabIndex = 2;
            add.Text = "הוסף";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // finishDate
            // 
            finishDate.AutoSize = true;
            finishDate.Location = new Point(504, 287);
            finishDate.Name = "finishDate";
            finishDate.Size = new Size(136, 20);
            finishDate.TabIndex = 0;
            finishDate.Text = "תאריך סיום המבצע:";
            // 
            // startDate
            // 
            startDate.AutoSize = true;
            startDate.Location = new Point(488, 240);
            startDate.Name = "startDate";
            startDate.Size = new Size(152, 20);
            startDate.TabIndex = 0;
            startDate.Text = "תאריך תחילת המבצע:";
            // 
            // isClub
            // 
            isClub.AutoSize = true;
            isClub.Location = new Point(548, 190);
            isClub.Name = "isClub";
            isClub.Size = new Size(92, 20);
            isClub.TabIndex = 0;
            isClub.Text = "צורך במועדון:";
            // 
            // priceToSale
            // 
            priceToSale.AutoSize = true;
            priceToSale.Location = new Point(515, 139);
            priceToSale.Name = "priceToSale";
            priceToSale.Size = new Size(125, 20);
            priceToSale.TabIndex = 0;
            priceToSale.Text = "מחיר כולל למבצע:";
            // 
            // quantityToSale
            // 
            quantityToSale.AutoSize = true;
            quantityToSale.Location = new Point(494, 87);
            quantityToSale.Name = "quantityToSale";
            quantityToSale.Size = new Size(146, 20);
            quantityToSale.TabIndex = 0;
            quantityToSale.Text = "כמות לקבלת המבצע:";
            // 
            // idProductToSale
            // 
            idProductToSale.AutoSize = true;
            idProductToSale.Location = new Point(470, 38);
            idProductToSale.Name = "idProductToSale";
            idProductToSale.Size = new Size(170, 20);
            idProductToSale.TabIndex = 0;
            idProductToSale.Text = "קוד המוצר שעליו המבצע:";
            // 
            // updateCustomer
            // 
            updateCustomer.Controls.Add(dateTimePicker1);
            updateCustomer.Controls.Add(dateTimePicker2);
            updateCustomer.Controls.Add(comboBox1);
            updateCustomer.Controls.Add(numericUpCode);
            updateCustomer.Controls.Add(numericUpDown1);
            updateCustomer.Controls.Add(numericUpDown2);
            updateCustomer.Controls.Add(numericUpDown3);
            updateCustomer.Controls.Add(updateSale);
            updateCustomer.Controls.Add(label1);
            updateCustomer.Controls.Add(label2);
            updateCustomer.Controls.Add(label3);
            updateCustomer.Controls.Add(label4);
            updateCustomer.Controls.Add(label5);
            updateCustomer.Controls.Add(label6);
            updateCustomer.Controls.Add(saleCode);
            updateCustomer.Location = new Point(4, 29);
            updateCustomer.Name = "updateCustomer";
            updateCustomer.Padding = new Padding(3);
            updateCustomer.RightToLeft = RightToLeft.Yes;
            updateCustomer.Size = new Size(674, 347);
            updateCustomer.TabIndex = 1;
            updateCustomer.Text = "עדכון";
            updateCustomer.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(237, 256);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(223, 27);
            dateTimePicker1.TabIndex = 21;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(237, 303);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(223, 27);
            dateTimePicker2.TabIndex = 22;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "true", "false" });
            comboBox1.Location = new Point(335, 207);
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.No;
            comboBox1.Size = new Size(125, 28);
            comboBox1.TabIndex = 20;
            // 
            // numericUpCode
            // 
            numericUpCode.Location = new Point(335, 15);
            numericUpCode.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpCode.Name = "numericUpCode";
            numericUpCode.Size = new Size(125, 27);
            numericUpCode.TabIndex = 17;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(335, 59);
            numericUpDown1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(125, 27);
            numericUpDown1.TabIndex = 17;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(335, 106);
            numericUpDown2.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(125, 27);
            numericUpDown2.TabIndex = 18;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(335, 158);
            numericUpDown3.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(125, 27);
            numericUpDown3.TabIndex = 19;
            // 
            // updateSale
            // 
            updateSale.Location = new Point(27, 299);
            updateSale.Name = "updateSale";
            updateSale.Size = new Size(94, 29);
            updateSale.TabIndex = 16;
            updateSale.Text = "עדכן";
            updateSale.UseVisualStyleBackColor = true;
            updateSale.Click += update_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(505, 310);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 10;
            label1.Text = "תאריך סיום המבצע:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(489, 263);
            label2.Name = "label2";
            label2.Size = new Size(152, 20);
            label2.TabIndex = 11;
            label2.Text = "תאריך תחילת המבצע:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(549, 215);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 12;
            label3.Text = "צורך במועדון:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(516, 165);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 13;
            label4.Text = "מחיר כולל למבצע:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(495, 113);
            label5.Name = "label5";
            label5.Size = new Size(146, 20);
            label5.TabIndex = 14;
            label5.Text = "כמות לקבלת המבצע:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(471, 61);
            label6.Name = "label6";
            label6.Size = new Size(170, 20);
            label6.TabIndex = 15;
            label6.Text = "קוד המוצר שעליו המבצע:";
            // 
            // saleCode
            // 
            saleCode.AutoSize = true;
            saleCode.Location = new Point(567, 22);
            saleCode.Name = "saleCode";
            saleCode.Size = new Size(74, 20);
            saleCode.TabIndex = 8;
            saleCode.Text = "קוד מבצע:";
            // 
            // deletedCustomer
            // 
            deletedCustomer.Controls.Add(delete);
            deletedCustomer.Controls.Add(textBoxDelete);
            deletedCustomer.Controls.Add(labelTםDeleteSale);
            deletedCustomer.Location = new Point(4, 29);
            deletedCustomer.Name = "deletedCustomer";
            deletedCustomer.Padding = new Padding(3);
            deletedCustomer.Size = new Size(674, 347);
            deletedCustomer.TabIndex = 2;
            deletedCustomer.Text = "מחיקה";
            deletedCustomer.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            delete.Location = new Point(45, 277);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 13;
            delete.Text = "מחיקה";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // textBoxDelete
            // 
            textBoxDelete.Location = new Point(412, 39);
            textBoxDelete.Name = "textBoxDelete";
            textBoxDelete.Size = new Size(125, 27);
            textBoxDelete.TabIndex = 12;
            // 
            // labelTםDeleteSale
            // 
            labelTםDeleteSale.AutoSize = true;
            labelTםDeleteSale.Location = new Point(559, 46);
            labelTםDeleteSale.Name = "labelTםDeleteSale";
            labelTםDeleteSale.Size = new Size(74, 20);
            labelTםDeleteSale.TabIndex = 11;
            labelTםDeleteSale.Text = "קוד מבצע:";
            // 
            // displayCustomer
            // 
            displayCustomer.Controls.Add(salesList);
            displayCustomer.Location = new Point(4, 29);
            displayCustomer.Name = "displayCustomer";
            displayCustomer.Padding = new Padding(3);
            displayCustomer.Size = new Size(674, 347);
            displayCustomer.TabIndex = 3;
            displayCustomer.Text = "תצוגה";
            displayCustomer.UseVisualStyleBackColor = true;
            // 
            // salesList
            // 
            salesList.FormattingEnabled = true;
            salesList.ItemHeight = 20;
            salesList.Location = new Point(20, 24);
            salesList.Name = "salesList";
            salesList.RightToLeft = RightToLeft.No;
            salesList.Size = new Size(445, 304);
            salesList.TabIndex = 0;
            // 
            // saleTitle
            // 
            saleTitle.AutoSize = true;
            saleTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            saleTitle.Location = new Point(374, 19);
            saleTitle.Name = "saleTitle";
            saleTitle.Size = new Size(84, 28);
            saleTitle.TabIndex = 4;
            saleTitle.Text = "מבצעים";
            // 
            // Sale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(customerCrud);
            Controls.Add(saleTitle);
            Name = "Sale";
            Text = "Sale";
            Load += Sale_Load;
            customerCrud.ResumeLayout(false);
            createCustomer.ResumeLayout(false);
            createCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPToSale).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownID).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQToSale).EndInit();
            updateCustomer.ResumeLayout(false);
            updateCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            deletedCustomer.ResumeLayout(false);
            deletedCustomer.PerformLayout();
            displayCustomer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl customerCrud;
        private TabPage createCustomer;
        private ComboBox comboBoxIfClub;
        private NumericUpDown numericUpDownPToSale;
        private NumericUpDown numericUpDownQToSale;
        private Button add;
        private Label isClub;
        private Label priceToSale;
        private Label quantityToSale;
        private Label idProductToSale;
        private TabPage updateCustomer;
        private ComboBox comboBoxCat;
        private Button update;
        private Label saleCode;
        private TextBox textBox1;
        private TabPage deletedCustomer;
        private Button delete;
        private TextBox textBoxDelete;
        private Label labelTםDeleteSale;
        private TabPage displayCustomer;
        private ListBox salesList;
        private Label saleTitle;
        private DateTimePicker dateTimePickerFinish;
        private DateTimePicker dateTimePickerStart;
        private Label finishDate;
        private Label startDate;
        private NumericUpDown numericUpDownID;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Button updateSale;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown numericUpCode;
    }
}