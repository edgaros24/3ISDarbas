using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace WinFormsApp1
{
    public partial class WithLib : Form
    {
        public WithLib()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            RSAParameters publicKey = rsa.ExportParameters(false);
            RSAParameters privateKey = rsa.ExportParameters(true);

            string message = txt_text.Text;

            // Konvertuoja i baitus ir uzsifruoja 
            byte[] messageBytes = Encoding.UTF8.GetBytes(message);
            byte[] encryptedBytes = rsa.Encrypt(messageBytes, false);

            string encryptedString = Convert.ToBase64String(encryptedBytes);
            txt_encrypt.Text = encryptedString;


            // Desifruoja naudojant private key
            byte[] decryptedBytes = rsa.Decrypt(Convert.FromBase64String(encryptedString), false);
            string decryptedMessage = Encoding.UTF8.GetString(decryptedBytes);
            txt_decrypt.Text = decryptedMessage;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
