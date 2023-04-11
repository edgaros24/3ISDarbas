using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using System.Numerics;

namespace WinFormsApp1
{
    public partial class WithoutLib : Form
    {
        public WithoutLib()
        {
            InitializeComponent();
            label8.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            int p = int.Parse(txt_p.Text);
            int q = int.Parse(txt_q.Text);

            int n = p * q;
            int phi = (p - 1) * (q - 1);

            int c = FindE(phi);
            int d = FindD(c, phi);

            txt_publicKey.Text = c.ToString();
            txt_privateKey.Text = d.ToString();

            string message = txt_tekstas.Text;

            string encryptedMessage = Encrypt(message, c, n);
            txt_Uzsifruotas.Text = encryptedMessage;
           
            using (StreamWriter sw = new StreamWriter("encryptedMessage.txt"))
            {
                sw.Write(encryptedMessage);
            }
            label8.Visible = true;
            label8.Text = "Issaugota faile";
            string decryptedMessage = Decrypt("encryptedMessage.txt", d, n);
            txt_Desifruotas.Text = decryptedMessage;
        }
        static int FindE(int phi)
        {
            for (int e = 2; e < phi; e++)
            {
                if (GCD(e, phi) == 1)
                {
                    return e;
                }
            }

            return -1;
        }

        static int FindD(int e, int phi)
        {
            int d = 0;
            int k = 1;

            while (true)
            {
                d = ((k * phi) + 1) / e;

                if (IsValidD(d, e, phi))
                {
                    return d;
                }

                k++;
            }
        }
        static bool IsValidD(int d, int e, int phi)
        {
            return (d != e) && ((d * e) % phi == 1);
        }

        static int GCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }

            return GCD(b, a % b);
        }

        static string Encrypt(string message, int e, int n)
        {
            string encryptedMessage = "";

            foreach (char c in message)
            {
                int m = c;
                int crypted = ModExp(m, e, n);
                encryptedMessage += crypted.ToString("D3");
            }

            return encryptedMessage;
        }
        static string Decrypt(string filePath, int d, int n)
        {
            string encryptedMessage = File.ReadAllText(filePath);
            string decryptedMessage = "";

            for (int i = 0; i < encryptedMessage.Length; i += 3)
            {
                string strNum = encryptedMessage.Substring(i, 3);
                int crypted = int.Parse(strNum);
                int decrypted = ModExp(crypted, d, n);
                decryptedMessage += (char)decrypted;
            }

            return decryptedMessage;
        }
        static int ModExp(int b, int e, int m)
        {
            int result = 1;

            while (e > 0)
            {
                if ((e & 1) == 1)
                {
                    result = (result * b) % m;
                }

                e >>= 1;
                b = (b * b) % m;
            }

            return result;
        }
    }
}




    
    

