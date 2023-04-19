namespace BankApp
{
    partial class ApplyLoanForm
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
            label2 = new Label();
            numericUpDownSum = new NumericUpDown();
            label1 = new Label();
            comboBoxTerm = new ComboBox();
            label3 = new Label();
            labelRate = new Label();
            checkBoxTerms = new CheckBox();
            buttonApply = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSum).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 17);
            label2.Name = "label2";
            label2.Size = new Size(278, 20);
            label2.TabIndex = 38;
            label2.Text = "Введіть бажану суму кредиту:";
            // 
            // numericUpDownSum
            // 
            numericUpDownSum.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownSum.Location = new Point(296, 16);
            numericUpDownSum.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownSum.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownSum.Name = "numericUpDownSum";
            numericUpDownSum.Size = new Size(174, 26);
            numericUpDownSum.TabIndex = 39;
            numericUpDownSum.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(230, 20);
            label1.TabIndex = 40;
            label1.Text = "Оберіть бажаний термін:";
            // 
            // comboBoxTerm
            // 
            comboBoxTerm.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTerm.FormattingEnabled = true;
            comboBoxTerm.Location = new Point(296, 48);
            comboBoxTerm.Name = "comboBoxTerm";
            comboBoxTerm.Size = new Size(174, 26);
            comboBoxTerm.TabIndex = 41;
            comboBoxTerm.SelectedIndexChanged += comboBoxTerm_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 81);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 42;
            label3.Text = "Ставка:";
            // 
            // labelRate
            // 
            labelRate.AutoSize = true;
            labelRate.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelRate.Location = new Point(296, 81);
            labelRate.Name = "labelRate";
            labelRate.Size = new Size(49, 20);
            labelRate.TabIndex = 43;
            labelRate.Text = "10%";
            // 
            // checkBoxTerms
            // 
            checkBoxTerms.AutoSize = true;
            checkBoxTerms.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxTerms.Location = new Point(194, 175);
            checkBoxTerms.Name = "checkBoxTerms";
            checkBoxTerms.Size = new Size(276, 22);
            checkBoxTerms.TabIndex = 44;
            checkBoxTerms.Text = "Я погоджуюсь з умовами банку";
            checkBoxTerms.UseVisualStyleBackColor = true;
            // 
            // buttonApply
            // 
            buttonApply.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonApply.Location = new Point(12, 203);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(458, 38);
            buttonApply.TabIndex = 45;
            buttonApply.Text = "Оформити кредит";
            buttonApply.UseVisualStyleBackColor = true;
            buttonApply.Click += buttonApply_Click;
            // 
            // ApplyLoanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 253);
            Controls.Add(buttonApply);
            Controls.Add(checkBoxTerms);
            Controls.Add(labelRate);
            Controls.Add(label3);
            Controls.Add(comboBoxTerm);
            Controls.Add(label1);
            Controls.Add(numericUpDownSum);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ApplyLoanForm";
            Text = "Оформлення кредиту";
            ((System.ComponentModel.ISupportInitialize)numericUpDownSum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private NumericUpDown numericUpDownSum;
        private Label label1;
        private ComboBox comboBoxTerm;
        private Label label3;
        private Label labelRate;
        private CheckBox checkBoxTerms;
        private Button buttonApply;
    }
}