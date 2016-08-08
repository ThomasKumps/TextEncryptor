namespace TextEncryptorPasswordGenerator
{
    partial class Form1
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
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDecrypt = new System.Windows.Forms.RadioButton();
            this.rdbEncrypt = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbOneTimePad = new System.Windows.Forms.RadioButton();
            this.rdbVigenere = new System.Windows.Forms.RadioButton();
            this.rdbCaesar = new System.Windows.Forms.RadioButton();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nmrPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.txtEncryptedText = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPasswordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(86, 65);
            this.txtUserInput.Multiline = true;
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(1010, 283);
            this.txtUserInput.TabIndex = 0;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(1102, 65);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(21, 283);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt / decrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDecrypt);
            this.groupBox1.Controls.Add(this.rdbEncrypt);
            this.groupBox1.Location = new System.Drawing.Point(89, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 46);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rdbDecrypt
            // 
            this.rdbDecrypt.AutoSize = true;
            this.rdbDecrypt.Location = new System.Drawing.Point(100, 10);
            this.rdbDecrypt.Name = "rdbDecrypt";
            this.rdbDecrypt.Size = new System.Drawing.Size(78, 21);
            this.rdbDecrypt.TabIndex = 1;
            this.rdbDecrypt.Text = "Decrypt";
            this.rdbDecrypt.UseVisualStyleBackColor = true;
            // 
            // rdbEncrypt
            // 
            this.rdbEncrypt.AutoSize = true;
            this.rdbEncrypt.Checked = true;
            this.rdbEncrypt.Location = new System.Drawing.Point(7, 10);
            this.rdbEncrypt.Name = "rdbEncrypt";
            this.rdbEncrypt.Size = new System.Drawing.Size(77, 21);
            this.rdbEncrypt.TabIndex = 0;
            this.rdbEncrypt.TabStop = true;
            this.rdbEncrypt.Text = "Encrypt";
            this.rdbEncrypt.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbOneTimePad);
            this.groupBox2.Controls.Add(this.rdbVigenere);
            this.groupBox2.Controls.Add(this.rdbCaesar);
            this.groupBox2.Location = new System.Drawing.Point(310, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 46);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // rdbOneTimePad
            // 
            this.rdbOneTimePad.AutoSize = true;
            this.rdbOneTimePad.Location = new System.Drawing.Point(189, 10);
            this.rdbOneTimePad.Name = "rdbOneTimePad";
            this.rdbOneTimePad.Size = new System.Drawing.Size(114, 21);
            this.rdbOneTimePad.TabIndex = 2;
            this.rdbOneTimePad.Text = "One time pad";
            this.rdbOneTimePad.UseVisualStyleBackColor = true;
            this.rdbOneTimePad.CheckedChanged += new System.EventHandler(this.rdbOneTimePad_CheckedChanged);
            // 
            // rdbVigenere
            // 
            this.rdbVigenere.AutoSize = true;
            this.rdbVigenere.Location = new System.Drawing.Point(97, 10);
            this.rdbVigenere.Name = "rdbVigenere";
            this.rdbVigenere.Size = new System.Drawing.Size(86, 21);
            this.rdbVigenere.TabIndex = 1;
            this.rdbVigenere.Text = "Vigenere";
            this.rdbVigenere.UseVisualStyleBackColor = true;
            // 
            // rdbCaesar
            // 
            this.rdbCaesar.AutoSize = true;
            this.rdbCaesar.Checked = true;
            this.rdbCaesar.Location = new System.Drawing.Point(17, 10);
            this.rdbCaesar.Name = "rdbCaesar";
            this.rdbCaesar.Size = new System.Drawing.Size(74, 21);
            this.rdbCaesar.TabIndex = 0;
            this.rdbCaesar.TabStop = true;
            this.rdbCaesar.Text = "Caesar";
            this.rdbCaesar.UseVisualStyleBackColor = true;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(653, 37);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(470, 22);
            this.txtKey.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(653, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Key(s)";
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Location = new System.Drawing.Point(2, 565);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(78, 243);
            this.btnGeneratePassword.TabIndex = 7;
            this.btnGeneratePassword.Text = "Generate password";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Length?";
            // 
            // nmrPasswordLength
            // 
            this.nmrPasswordLength.Location = new System.Drawing.Point(12, 537);
            this.nmrPasswordLength.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nmrPasswordLength.Name = "nmrPasswordLength";
            this.nmrPasswordLength.Size = new System.Drawing.Size(68, 22);
            this.nmrPasswordLength.TabIndex = 10;
            this.nmrPasswordLength.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // txtEncryptedText
            // 
            this.txtEncryptedText.Location = new System.Drawing.Point(86, 373);
            this.txtEncryptedText.Multiline = true;
            this.txtEncryptedText.Name = "txtEncryptedText";
            this.txtEncryptedText.Size = new System.Drawing.Size(1010, 459);
            this.txtEncryptedText.TabIndex = 11;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(794, 7);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "Clear";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 844);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.txtEncryptedText);
            this.Controls.Add(this.nmrPasswordLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtUserInput);
            this.Name = "Form1";
            this.Text = "Encryptor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPasswordLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDecrypt;
        private System.Windows.Forms.RadioButton rdbEncrypt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbOneTimePad;
        private System.Windows.Forms.RadioButton rdbVigenere;
        private System.Windows.Forms.RadioButton rdbCaesar;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmrPasswordLength;
        private System.Windows.Forms.TextBox txtEncryptedText;
        private System.Windows.Forms.Button btnDel;
    }
}

