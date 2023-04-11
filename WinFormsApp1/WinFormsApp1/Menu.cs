using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WithLib wl = new WithLib();
            wl.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WithoutLib wol = new WithoutLib();
            wol.Show();
            this.Hide();
        }
    }
}
