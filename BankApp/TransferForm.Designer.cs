namespace BankApp
{
    partial class TransferForm
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
            numericUpDownSum = new NumericUpDown();
            label2 = new Label();
            buttonPay = new Button();
            phoneLabel = new Label();
            textBoxNumber = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSum).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownSum
            // 
            numericUpDownSum.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownSum.Location = new Point(12, 103);
            numericUpDownSum.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownSum.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownSum.Name = "numericUpDownSum";
            numericUpDownSum.Size = new Size(458, 26);
            numericUpDownSum.TabIndex = 32;
            numericUpDownSum.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(458, 28);
            label2.TabIndex = 31;
            label2.Text = "Введіть суму для перерахування:";
            // 
            // buttonPay
            // 
            buttonPay.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPay.Location = new Point(12, 201);
            buttonPay.Name = "buttonPay";
            buttonPay.Size = new Size(458, 38);
            buttonPay.TabIndex = 30;
            buttonPay.Text = "Оплатити";
            buttonPay.UseVisualStyleBackColor = true;
            buttonPay.Click += buttonPay_Click;
            // 
            // phoneLabel
            // 
            phoneLabel.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            phoneLabel.Location = new Point(12, 14);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(139, 42);
            phoneLabel.TabIndex = 28;
            phoneLabel.Text = "Введіть номер рахунка:";
            // 
            // textBoxNumber
            // 
            textBoxNumber.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumber.Location = new Point(157, 29);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(313, 26);
            textBoxNumber.TabIndex = 29;
            // 
            // TransferForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 253);
            Controls.Add(numericUpDownSum);
            Controls.Add(label2);
            Controls.Add(buttonPay);
            Controls.Add(phoneLabel);
            Controls.Add(textBoxNumber);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TransferForm";
            Text = "Переказання коштів";
            ((System.ComponentModel.ISupportInitialize)numericUpDownSum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownSum;
        private Label label2;
        private Button buttonPay;
        private Label phoneLabel;
        private TextBox textBoxNumber;
    }
}