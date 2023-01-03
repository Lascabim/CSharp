using System;
using System.Linq;
using System.Windows.Forms;

namespace Ficheiros2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string box1 = textBox1.Text;
            char ch = ' ';

            int count_ESPAÇOS = box1.Count(f => (f == ch));
            int count = count_ESPAÇOS + 1;

            textBox2.Text = count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
