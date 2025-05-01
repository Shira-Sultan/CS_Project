namespace UI
{
    partial class home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            management = new Button();
            cashier = new Button();
            SuspendLayout();
            // 
            // management
            // 
            management.Location = new Point(457, 140);
            management.Name = "management";
            management.Size = new Size(201, 78);
            management.TabIndex = 0;
            management.Text = "כניסת מנהל";
            management.UseVisualStyleBackColor = true;
            management.Click += management_Click;
            // 
            // cashier
            // 
            cashier.Location = new Point(170, 140);
            cashier.Name = "cashier";
            cashier.Size = new Size(201, 78);
            cashier.TabIndex = 0;
            cashier.Text = "כניסת לקוחות";
            cashier.UseVisualStyleBackColor = true;
            cashier.Click += cashier_Click;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cashier);
            Controls.Add(management);
            Name = "home";
            Text = "home";
            ResumeLayout(false);
        }

        #endregion

        private Button management;
        private Button cashier;
    }
}