using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_Online
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            this.Hide();

            var Forms2 = new Form2();
            Forms2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            var Forms1 = new Form1();
            Forms1.Show();
        }
    }
}
