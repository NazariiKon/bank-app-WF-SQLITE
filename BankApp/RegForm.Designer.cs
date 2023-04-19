namespace BankApp
{
    partial class RegForm
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
            buttonSave = new Button();
            label1 = new Label();
            textBoxAddress = new TextBox();
            nameLabel = new Label();
            textBoxName = new TextBox();
            phoneLabel = new Label();
            textBoxPhone = new TextBox();
            positionLabel = new Label();
            textBoxWork = new TextBox();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(12, 137);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(403, 29);
            buttonSave.TabIndex = 31;
            buttonSave.Text = "Зареєструватись";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 75);
            label1.Name = "label1";
            label1.Size = new Size(84, 23);
            label1.TabIndex = 29;
            label1.Text = "Адреса:";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(102, 71);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(313, 27);
            textBoxAddress.TabIndex = 30;
            // 
            // nameLabel
            // 
            nameLabel.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(12, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(84, 23);
            nameLabel.TabIndex = 23;
            nameLabel.Text = "ПІБ:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(102, 5);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(313, 27);
            textBoxName.TabIndex = 24;
            // 
            // phoneLabel
            // 
            phoneLabel.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            phoneLabel.Location = new Point(12, 42);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(84, 23);
            phoneLabel.TabIndex = 25;
            phoneLabel.Text = "Телефон:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(102, 38);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(313, 27);
            textBoxPhone.TabIndex = 26;
            // 
            // positionLabel
            // 
            positionLabel.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            positionLabel.Location = new Point(12, 108);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(84, 23);
            positionLabel.TabIndex = 27;
            positionLabel.Text = "Посада:";
            // 
            // textBoxWork
            // 
            textBoxWork.Location = new Point(102, 104);
            textBoxWork.Name = "textBoxWork";
            textBoxWork.Size = new Size(313, 27);
            textBoxWork.TabIndex = 28;
            // 
            // RegForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 180);
            Controls.Add(buttonSave);
            Controls.Add(label1);
            Controls.Add(textBoxAddress);
            Controls.Add(nameLabel);
            Controls.Add(textBoxName);
            Controls.Add(phoneLabel);
            Controls.Add(textBoxPhone);
            Controls.Add(positionLabel);
            Controls.Add(textBoxWork);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegForm";
            Text = "Реєстрація";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Label label1;
        private TextBox textBoxAddress;
        private Label nameLabel;
        private TextBox textBoxName;
        private Label phoneLabel;
        private TextBox textBoxPhone;
        private Label positionLabel;
        private TextBox textBoxWork;
    }
}