using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEncryptorPasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            txtUserInput.Text = Generator.NewPassword((byte)nmrPasswordLength.Value).ToString();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (rdbEncrypt.Checked == true)
            {
                if (rdbCaesar.Checked == true)
                {
                    int x = 0;
                    if(int.TryParse(txtKey.Text,out x))
                    {
                        txtEncryptedText.Text = Encryptor.Encrypt(EncryptionMethod.Caesar, txtUserInput.Text, txtKey.Text);
                    }                  
                }
                else if(rdbVigenere.Checked == true)
                {
                    txtEncryptedText.Text = Encryptor.Encrypt(EncryptionMethod.Vigenere, txtUserInput.Text, txtKey.Text);
                }
                else
                {
                    txtEncryptedText.Text = Encryptor.Encrypt(EncryptionMethod.Vigenere, txtUserInput.Text, txtKey.Text);
                }
            }
            else
            {
                if (rdbCaesar.Checked == true)
                {
                    int x = 0;
                    if (int.TryParse(txtKey.Text, out x))
                    {
                        txtEncryptedText.Text = Encryptor.Decrypt(EncryptionMethod.Caesar, txtUserInput.Text, txtKey.Text);
                    }
                }
                else if (rdbVigenere.Checked == true)
                {
                    txtEncryptedText.Text = Encryptor.Decrypt(EncryptionMethod.Vigenere, txtUserInput.Text, txtKey.Text);
                }
                else
                {
                    txtEncryptedText.Text = Encryptor.Decrypt(EncryptionMethod.Vigenere, txtUserInput.Text, txtKey.Text);
                }
            }
        }

        private void rdbOneTimePad_CheckedChanged(object sender, EventArgs e)
        {
            txtKey.Text = Generator.OneTimePad(txtUserInput.Text.Length);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtKey.Text = "";
        }
        
    }
}
