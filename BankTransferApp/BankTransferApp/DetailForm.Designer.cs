namespace BankTransferApp
{
    partial class DetailForm
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
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.AccountLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.IdentityLabel = new System.Windows.Forms.Label();
            this.FirstNameResponseLabel = new System.Windows.Forms.Label();
            this.LastNameResponseLabel = new System.Windows.Forms.Label();
            this.AccountResponseLabel = new System.Windows.Forms.Label();
            this.IdentityResponseLabel = new System.Windows.Forms.Label();
            this.PhoneResponseLabel = new System.Windows.Forms.Label();
            this.TransferGroupBox = new System.Windows.Forms.GroupBox();
            this.Sendbutton = new System.Windows.Forms.Button();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.MskAccountNo = new System.Windows.Forms.MaskedTextBox();
            this.ReceiverAccountNoLabel = new System.Windows.Forms.Label();
            this.TransferGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(62, 54);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(90, 20);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // AccountLabel
            // 
            this.AccountLabel.AutoSize = true;
            this.AccountLabel.Location = new System.Drawing.Point(56, 129);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(96, 20);
            this.AccountLabel.TabIndex = 1;
            this.AccountLabel.Text = "Account No:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(69, 194);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(83, 20);
            this.PhoneLabel.TabIndex = 2;
            this.PhoneLabel.Text = "Phone No:";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(62, 92);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(90, 20);
            this.LastNameLabel.TabIndex = 3;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // IdentityLabel
            // 
            this.IdentityLabel.AutoSize = true;
            this.IdentityLabel.Location = new System.Drawing.Point(63, 161);
            this.IdentityLabel.Name = "IdentityLabel";
            this.IdentityLabel.Size = new System.Drawing.Size(89, 20);
            this.IdentityLabel.TabIndex = 4;
            this.IdentityLabel.Text = "Identity No:";
            // 
            // FirstNameResponseLabel
            // 
            this.FirstNameResponseLabel.AutoSize = true;
            this.FirstNameResponseLabel.Location = new System.Drawing.Point(174, 54);
            this.FirstNameResponseLabel.Name = "FirstNameResponseLabel";
            this.FirstNameResponseLabel.Size = new System.Drawing.Size(54, 20);
            this.FirstNameResponseLabel.TabIndex = 5;
            this.FirstNameResponseLabel.Text = "Özlem";
            // 
            // LastNameResponseLabel
            // 
            this.LastNameResponseLabel.AutoSize = true;
            this.LastNameResponseLabel.Location = new System.Drawing.Point(174, 92);
            this.LastNameResponseLabel.Name = "LastNameResponseLabel";
            this.LastNameResponseLabel.Size = new System.Drawing.Size(94, 20);
            this.LastNameResponseLabel.TabIndex = 6;
            this.LastNameResponseLabel.Text = "Belörenoğlu";
            // 
            // AccountResponseLabel
            // 
            this.AccountResponseLabel.AutoSize = true;
            this.AccountResponseLabel.Location = new System.Drawing.Point(174, 129);
            this.AccountResponseLabel.Name = "AccountResponseLabel";
            this.AccountResponseLabel.Size = new System.Drawing.Size(63, 20);
            this.AccountResponseLabel.TabIndex = 7;
            this.AccountResponseLabel.Text = "123456";
            // 
            // IdentityResponseLabel
            // 
            this.IdentityResponseLabel.AutoSize = true;
            this.IdentityResponseLabel.Location = new System.Drawing.Point(174, 161);
            this.IdentityResponseLabel.Name = "IdentityResponseLabel";
            this.IdentityResponseLabel.Size = new System.Drawing.Size(108, 20);
            this.IdentityResponseLabel.TabIndex = 8;
            this.IdentityResponseLabel.Text = "12345678910";
            // 
            // PhoneResponseLabel
            // 
            this.PhoneResponseLabel.AutoSize = true;
            this.PhoneResponseLabel.Location = new System.Drawing.Point(174, 194);
            this.PhoneResponseLabel.Name = "PhoneResponseLabel";
            this.PhoneResponseLabel.Size = new System.Drawing.Size(99, 20);
            this.PhoneResponseLabel.TabIndex = 9;
            this.PhoneResponseLabel.Text = "2122222222";
            // 
            // TransferGroupBox
            // 
            this.TransferGroupBox.Controls.Add(this.Sendbutton);
            this.TransferGroupBox.Controls.Add(this.AmountLabel);
            this.TransferGroupBox.Controls.Add(this.PasswordTextBox);
            this.TransferGroupBox.Controls.Add(this.MskAccountNo);
            this.TransferGroupBox.Controls.Add(this.ReceiverAccountNoLabel);
            this.TransferGroupBox.Location = new System.Drawing.Point(26, 232);
            this.TransferGroupBox.Name = "TransferGroupBox";
            this.TransferGroupBox.Size = new System.Drawing.Size(481, 228);
            this.TransferGroupBox.TabIndex = 10;
            this.TransferGroupBox.TabStop = false;
            this.TransferGroupBox.Text = "Transfer";
            // 
            // Sendbutton
            // 
            this.Sendbutton.Location = new System.Drawing.Point(150, 119);
            this.Sendbutton.Name = "Sendbutton";
            this.Sendbutton.Size = new System.Drawing.Size(197, 29);
            this.Sendbutton.TabIndex = 5;
            this.Sendbutton.Text = "Send";
            this.Sendbutton.UseVisualStyleBackColor = true;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(43, 81);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(69, 20);
            this.AmountLabel.TabIndex = 4;
            this.AmountLabel.Text = "Amount:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(150, 75);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(197, 26);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // MskAccountNo
            // 
            this.MskAccountNo.Location = new System.Drawing.Point(150, 30);
            this.MskAccountNo.Mask = "000000";
            this.MskAccountNo.Name = "MskAccountNo";
            this.MskAccountNo.Size = new System.Drawing.Size(197, 26);
            this.MskAccountNo.TabIndex = 2;
            this.MskAccountNo.ValidatingType = typeof(int);
            // 
            // ReceiverAccountNoLabel
            // 
            this.ReceiverAccountNoLabel.AutoSize = true;
            this.ReceiverAccountNoLabel.Location = new System.Drawing.Point(16, 33);
            this.ReceiverAccountNoLabel.Name = "ReceiverAccountNoLabel";
            this.ReceiverAccountNoLabel.Size = new System.Drawing.Size(96, 20);
            this.ReceiverAccountNoLabel.TabIndex = 0;
            this.ReceiverAccountNoLabel.Text = "Account No:";
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(532, 472);
            this.Controls.Add(this.TransferGroupBox);
            this.Controls.Add(this.PhoneResponseLabel);
            this.Controls.Add(this.IdentityResponseLabel);
            this.Controls.Add(this.AccountResponseLabel);
            this.Controls.Add(this.LastNameResponseLabel);
            this.Controls.Add(this.FirstNameResponseLabel);
            this.Controls.Add(this.IdentityLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.AccountLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DetailForm";
            this.Text = "Form2";
            this.TransferGroupBox.ResumeLayout(false);
            this.TransferGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label AccountLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label IdentityLabel;
        private System.Windows.Forms.Label FirstNameResponseLabel;
        private System.Windows.Forms.Label LastNameResponseLabel;
        private System.Windows.Forms.Label AccountResponseLabel;
        private System.Windows.Forms.Label IdentityResponseLabel;
        private System.Windows.Forms.Label PhoneResponseLabel;
        private System.Windows.Forms.GroupBox TransferGroupBox;
        private System.Windows.Forms.Label ReceiverAccountNoLabel;
        private System.Windows.Forms.MaskedTextBox MskAccountNo;
        private System.Windows.Forms.Button Sendbutton;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
    }
}