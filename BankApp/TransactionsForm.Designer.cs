namespace BankApp
{
    partial class TransactionsForm
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
            listBoxTransactions = new ListBox();
            SuspendLayout();
            // 
            // listBoxTransactions
            // 
            listBoxTransactions.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxTransactions.FormattingEnabled = true;
            listBoxTransactions.ItemHeight = 18;
            listBoxTransactions.Location = new Point(12, 12);
            listBoxTransactions.Name = "listBoxTransactions";
            listBoxTransactions.Size = new Size(458, 220);
            listBoxTransactions.TabIndex = 0;
            // 
            // TransactionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 253);
            Controls.Add(listBoxTransactions);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TransactionsForm";
            Text = "Ваші транзакції";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxTransactions;
    }
}