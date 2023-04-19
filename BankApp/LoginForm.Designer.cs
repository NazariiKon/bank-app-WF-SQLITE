namespace BankApp
{
    partial class LoginForm
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
            label1 = new Label();
            textBoxPhone = new TextBox();
            label2 = new Label();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Verdana", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 40, 0, 0);
            label1.Size = new Size(482, 253);
            label1.TabIndex = 0;
            label1.Text = "Вітаємо";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPhone.Location = new Point(154, 178);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(179, 26);
            textBoxPhone.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(154, 159);
            label2.Name = "label2";
            label2.Size = new Size(73, 16);
            label2.TabIndex = 2;
            label2.Text = "Телефон:";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(154, 211);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(179, 29);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Увійти";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 253);
            Controls.Add(buttonLogin);
            Controls.Add(label2);
            Controls.Add(textBoxPhone);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Банк";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxPhone;
        private Label label2;
        private Button buttonLogin;
    }
}