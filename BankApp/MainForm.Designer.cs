using System.Windows.Forms;

namespace BankApp
{
    partial class MainForm
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
            textBoxNumber = new TextBox();
            label2 = new Label();
            labelBalance = new Label();
            buttonTransfer = new Button();
            buttonTopUp = new Button();
            buttonPayBills = new Button();
            buttonLoans = new Button();
            buttonHistory = new Button();
            buttonClientInfo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 58);
            label1.Name = "label1";
            label1.Size = new Size(192, 60);
            label1.TabIndex = 0;
            label1.Text = "Номер вашого аккаунта:";
            // 
            // textBoxNumber
            // 
            textBoxNumber.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumber.Location = new Point(210, 89);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.ReadOnly = true;
            textBoxNumber.Size = new Size(263, 29);
            textBoxNumber.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 16);
            label2.Name = "label2";
            label2.Size = new Size(107, 28);
            label2.TabIndex = 2;
            label2.Text = "Баланс:";
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelBalance.ForeColor = Color.ForestGreen;
            labelBalance.Location = new Point(125, 9);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(91, 36);
            labelBalance.TabIndex = 3;
            labelBalance.Text = "8000";
            // 
            // buttonTransfer
            // 
            buttonTransfer.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTransfer.Location = new Point(11, 193);
            buttonTransfer.Name = "buttonTransfer";
            buttonTransfer.Size = new Size(150, 50);
            buttonTransfer.TabIndex = 5;
            buttonTransfer.Text = "Переказ на карту";
            buttonTransfer.UseVisualStyleBackColor = true;
            buttonTransfer.Click += buttonTransfer_Click;
            // 
            // buttonTopUp
            // 
            buttonTopUp.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTopUp.Location = new Point(167, 193);
            buttonTopUp.Name = "buttonTopUp";
            buttonTopUp.Size = new Size(150, 50);
            buttonTopUp.TabIndex = 6;
            buttonTopUp.Text = "Поповнити телефон";
            buttonTopUp.UseVisualStyleBackColor = true;
            buttonTopUp.Click += buttonTopUp_Click;
            // 
            // buttonPayBills
            // 
            buttonPayBills.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPayBills.Location = new Point(323, 193);
            buttonPayBills.Name = "buttonPayBills";
            buttonPayBills.Size = new Size(150, 50);
            buttonPayBills.TabIndex = 7;
            buttonPayBills.Text = "Оплатити рахунок";
            buttonPayBills.UseVisualStyleBackColor = true;
            buttonPayBills.Click += buttonPayBills_Click;
            // 
            // buttonLoans
            // 
            buttonLoans.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLoans.Location = new Point(11, 137);
            buttonLoans.Name = "buttonLoans";
            buttonLoans.Size = new Size(150, 50);
            buttonLoans.TabIndex = 2;
            buttonLoans.Text = "Кредити";
            buttonLoans.UseVisualStyleBackColor = true;
            buttonLoans.Click += buttonLoans_Click;
            // 
            // buttonHistory
            // 
            buttonHistory.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHistory.Location = new Point(167, 137);
            buttonHistory.Name = "buttonHistory";
            buttonHistory.Size = new Size(150, 50);
            buttonHistory.TabIndex = 3;
            buttonHistory.Text = "Транзакції";
            buttonHistory.UseVisualStyleBackColor = true;
            buttonHistory.Click += buttonHistory_Click;
            // 
            // buttonClientInfo
            // 
            buttonClientInfo.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClientInfo.Location = new Point(323, 137);
            buttonClientInfo.Name = "buttonClientInfo";
            buttonClientInfo.Size = new Size(150, 50);
            buttonClientInfo.TabIndex = 1;
            buttonClientInfo.Text = "Ваш профіль";
            buttonClientInfo.UseVisualStyleBackColor = true;
            buttonClientInfo.Click += buttonClientInfo_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 253);
            Controls.Add(buttonClientInfo);
            Controls.Add(buttonHistory);
            Controls.Add(buttonLoans);
            Controls.Add(buttonPayBills);
            Controls.Add(buttonTopUp);
            Controls.Add(buttonTransfer);
            Controls.Add(labelBalance);
            Controls.Add(label2);
            Controls.Add(textBoxNumber);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Головне меню";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNumber;
        private Label label2;
        private Label labelBalance;
        private Button buttonTransfer;
        private Button buttonTopUp;
        private Button buttonPayBills;
        private Button buttonLoans;
        private Button buttonHistory;
        private Button buttonClientInfo;
    }
}