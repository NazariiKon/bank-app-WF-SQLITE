namespace BankApp
{
    partial class TopUpForm
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
            phoneLabel = new Label();
            textBoxPhone = new TextBox();
            buttonPay = new Button();
            numericUpDownSum = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSum).BeginInit();
            SuspendLayout();
            // 
            // phoneLabel
            // 
            phoneLabel.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            phoneLabel.Location = new Point(12, 16);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(139, 42);
            phoneLabel.TabIndex = 18;
            phoneLabel.Text = "Введіть номер телефона:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPhone.Location = new Point(157, 31);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(313, 26);
            textBoxPhone.TabIndex = 19;
            // 
            // buttonPay
            // 
            buttonPay.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPay.Location = new Point(12, 203);
            buttonPay.Name = "buttonPay";
            buttonPay.Size = new Size(458, 38);
            buttonPay.TabIndex = 20;
            buttonPay.Text = "Оплатити";
            buttonPay.UseVisualStyleBackColor = true;
            buttonPay.Click += buttonPay_Click;
            // 
            // numericUpDownSum
            // 
            numericUpDownSum.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownSum.Location = new Point(12, 105);
            numericUpDownSum.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownSum.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownSum.Name = "numericUpDownSum";
            numericUpDownSum.Size = new Size(458, 26);
            numericUpDownSum.TabIndex = 27;
            numericUpDownSum.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(458, 28);
            label2.TabIndex = 26;
            label2.Text = "Введіть суму для поповнення: ";
            // 
            // TopUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 253);
            Controls.Add(numericUpDownSum);
            Controls.Add(label2);
            Controls.Add(buttonPay);
            Controls.Add(phoneLabel);
            Controls.Add(textBoxPhone);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TopUpForm";
            Text = "Поповнення рахунку";
            ((System.ComponentModel.ISupportInitialize)numericUpDownSum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label phoneLabel;
        private TextBox textBoxPhone;
        private Button buttonPay;
        private NumericUpDown numericUpDownSum;
        private Label label2;
    }
}