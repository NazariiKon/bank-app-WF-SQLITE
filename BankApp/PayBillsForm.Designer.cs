namespace BankApp
{
    partial class PayBillsForm
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
            textBoxAddress = new TextBox();
            label2 = new Label();
            entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            numericUpDownSum = new NumericUpDown();
            buttonPay = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(84, 23);
            label1.TabIndex = 22;
            label1.Text = "Адреса:";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddress.Location = new Point(102, 12);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.ReadOnly = true;
            textBoxAddress.Size = new Size(368, 26);
            textBoxAddress.TabIndex = 23;
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(458, 51);
            label2.TabIndex = 24;
            label2.Text = "Введіть суму на яку ви хочете оплатити комунальні послуги: ";
            // 
            // entityCommand1
            // 
            entityCommand1.CommandTimeout = 0;
            entityCommand1.CommandTree = null;
            entityCommand1.Connection = null;
            entityCommand1.EnablePlanCaching = true;
            entityCommand1.Transaction = null;
            // 
            // numericUpDownSum
            // 
            numericUpDownSum.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownSum.Location = new Point(12, 107);
            numericUpDownSum.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownSum.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownSum.Name = "numericUpDownSum";
            numericUpDownSum.Size = new Size(458, 26);
            numericUpDownSum.TabIndex = 25;
            numericUpDownSum.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // buttonPay
            // 
            buttonPay.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPay.Location = new Point(12, 201);
            buttonPay.Name = "buttonPay";
            buttonPay.Size = new Size(458, 40);
            buttonPay.TabIndex = 26;
            buttonPay.Text = "Оплатити";
            buttonPay.UseVisualStyleBackColor = true;
            buttonPay.Click += buttonPay_Click;
            // 
            // PayBillsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 253);
            Controls.Add(buttonPay);
            Controls.Add(numericUpDownSum);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxAddress);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PayBillsForm";
            Text = "Оплата рахунків";
            ((System.ComponentModel.ISupportInitialize)numericUpDownSum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxAddress;
        private Label label2;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private NumericUpDown numericUpDownSum;
        private Button buttonPay;
    }
}