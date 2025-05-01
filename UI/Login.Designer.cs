namespace UI
{
    partial class Login
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
            loginTitle = new Label();
            idProductToSale = new Label();
            textBoxLogin = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // loginTitle
            // 
            loginTitle.AutoSize = true;
            loginTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginTitle.Location = new Point(375, 42);
            loginTitle.Name = "loginTitle";
            loginTitle.Size = new Size(79, 28);
            loginTitle.TabIndex = 5;
            loginTitle.Text = "הזדהות";
            // 
            // idProductToSale
            // 
            idProductToSale.AutoSize = true;
            idProductToSale.Location = new Point(375, 139);
            idProductToSale.Name = "idProductToSale";
            idProductToSale.Size = new Size(88, 20);
            idProductToSale.TabIndex = 6;
            idProductToSale.Text = "תעודת זהות:";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(325, 176);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.RightToLeft = RightToLeft.No;
            textBoxLogin.Size = new Size(181, 27);
            textBoxLogin.TabIndex = 8;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(369, 247);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "המשך";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(textBoxLogin);
            Controls.Add(idProductToSale);
            Controls.Add(loginTitle);
            Name = "Login";
            RightToLeft = RightToLeft.Yes;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginTitle;
        private Label idProductToSale;
        private TextBox textBoxLogin;
        private Button btnLogin;
    }
}