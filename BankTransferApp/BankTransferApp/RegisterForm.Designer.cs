namespace BankTransferApp
{
    partial class RegisterForm
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
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.IdentityLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.AccountNoLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.AccountNoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.IdentityMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.RandomButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(124, 98);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(75, 16);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(124, 137);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(75, 16);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // IdentityLabel
            // 
            this.IdentityLabel.AutoSize = true;
            this.IdentityLabel.Location = new System.Drawing.Point(124, 173);
            this.IdentityLabel.Name = "IdentityLabel";
            this.IdentityLabel.Size = new System.Drawing.Size(73, 16);
            this.IdentityLabel.TabIndex = 2;
            this.IdentityLabel.Text = "Identity No:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(148, 203);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(49, 16);
            this.PhoneLabel.TabIndex = 3;
            this.PhoneLabel.Text = "Phone:";
            // 
            // AccountNoLabel
            // 
            this.AccountNoLabel.AutoSize = true;
            this.AccountNoLabel.Location = new System.Drawing.Point(118, 233);
            this.AccountNoLabel.Name = "AccountNoLabel";
            this.AccountNoLabel.Size = new System.Drawing.Size(79, 16);
            this.AccountNoLabel.TabIndex = 4;
            this.AccountNoLabel.Text = "Account No:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(129, 263);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(70, 16);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password:";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(227, 95);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(197, 22);
            this.FirstNameTextBox.TabIndex = 1;
            // 
            // AccountNoMaskedTextBox
            // 
            this.AccountNoMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNoMaskedTextBox.Location = new System.Drawing.Point(227, 227);
            this.AccountNoMaskedTextBox.Mask = "000000";
            this.AccountNoMaskedTextBox.Name = "AccountNoMaskedTextBox";
            this.AccountNoMaskedTextBox.Size = new System.Drawing.Size(197, 22);
            this.AccountNoMaskedTextBox.TabIndex = 5;
            this.AccountNoMaskedTextBox.ValidatingType = typeof(int);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.Location = new System.Drawing.Point(227, 131);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(197, 22);
            this.LastNameTextBox.TabIndex = 2;
            // 
            // IdentityMaskedTextBox
            // 
            this.IdentityMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdentityMaskedTextBox.Location = new System.Drawing.Point(227, 167);
            this.IdentityMaskedTextBox.Mask = "00000000000";
            this.IdentityMaskedTextBox.Name = "IdentityMaskedTextBox";
            this.IdentityMaskedTextBox.Size = new System.Drawing.Size(197, 22);
            this.IdentityMaskedTextBox.TabIndex = 3;
            this.IdentityMaskedTextBox.ValidatingType = typeof(int);
            // 
            // PhoneMaskedTextBox
            // 
            this.PhoneMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneMaskedTextBox.Location = new System.Drawing.Point(227, 197);
            this.PhoneMaskedTextBox.Mask = "(999) 000-0000";
            this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
            this.PhoneMaskedTextBox.Size = new System.Drawing.Size(197, 22);
            this.PhoneMaskedTextBox.TabIndex = 4;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(227, 255);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(197, 22);
            this.PasswordTextBox.TabIndex = 6;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(254, 308);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(145, 30);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // RandomButton
            // 
            this.RandomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomButton.Location = new System.Drawing.Point(430, 227);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(37, 24);
            this.RandomButton.TabIndex = 13;
            this.RandomButton.Text = "...";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(600, 435);
            this.Controls.Add(this.RandomButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PhoneMaskedTextBox);
            this.Controls.Add(this.IdentityMaskedTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.AccountNoMaskedTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.AccountNoLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.IdentityLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label IdentityLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label AccountNoLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.MaskedTextBox AccountNoMaskedTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.MaskedTextBox IdentityMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button RandomButton;
    }
}