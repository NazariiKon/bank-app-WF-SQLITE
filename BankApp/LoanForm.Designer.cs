namespace BankApp
{
    partial class LoanForm
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
            label1 = new Label();
            buttonPay = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxSum = new TextBox();
            textBoxRate = new TextBox();
            textBoxTermin = new TextBox();
            label5 = new Label();
            textBoxDate = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(237, 26);
            label1.TabIndex = 32;
            label1.Text = "Ваш кредит:";
            // 
            // buttonPay
            // 
            buttonPay.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPay.Location = new Point(12, 203);
            buttonPay.Name = "buttonPay";
            buttonPay.Size = new Size(237, 38);
            buttonPay.TabIndex = 33;
            buttonPay.Text = "Сплатити кредит";
            buttonPay.UseVisualStyleBackColor = true;
            buttonPay.Click += buttonPay_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 34;
            label2.Text = "Сума: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 84);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 35;
            label3.Text = "Відсоток:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 116);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 36;
            label4.Text = "Термін:";
            // 
            // textBoxSum
            // 
            textBoxSum.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSum.Location = new Point(110, 51);
            textBoxSum.Name = "textBoxSum";
            textBoxSum.ReadOnly = true;
            textBoxSum.Size = new Size(139, 26);
            textBoxSum.TabIndex = 37;
            // 
            // textBoxRate
            // 
            textBoxRate.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRate.Location = new Point(110, 83);
            textBoxRate.Name = "textBoxRate";
            textBoxRate.ReadOnly = true;
            textBoxRate.Size = new Size(139, 26);
            textBoxRate.TabIndex = 38;
            // 
            // textBoxTermin
            // 
            textBoxTermin.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTermin.Location = new Point(110, 115);
            textBoxTermin.Name = "textBoxTermin";
            textBoxTermin.ReadOnly = true;
            textBoxTermin.Size = new Size(139, 26);
            textBoxTermin.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 148);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 41;
            label5.Text = "Дата:";
            // 
            // textBoxDate
            // 
            textBoxDate.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDate.Location = new Point(110, 147);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.ReadOnly = true;
            textBoxDate.Size = new Size(139, 26);
            textBoxDate.TabIndex = 42;
            // 
            // LoanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 253);
            Controls.Add(textBoxDate);
            Controls.Add(label5);
            Controls.Add(textBoxTermin);
            Controls.Add(textBoxRate);
            Controls.Add(textBoxSum);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonPay);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoanForm";
            Text = "Кредити";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonPay;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxSum;
        private TextBox textBoxRate;
        private TextBox textBoxTermin;
        private Label label5;
        private TextBox textBoxDate;
    }
}