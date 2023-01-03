using System;
using System.Windows.Forms;

namespace BinDec
{
    public partial class Form1 : Form
    {
        static int numD;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void visor1_TextChanged(object sender, EventArgs e)
        {
            numD = int.Parse(visor1.Text);
        }

        private void botao_Click(object sender, EventArgs e)
        {
            int x = 0;

            int lastDiv = numD;
            int[] lastResto = new int[333333];

            if (numD > -1)
            {
                //  ><

                do
                {
                    lastResto[x] = lastDiv % 2;
                    lastDiv = lastDiv / 2;
                    x++;

                    if (lastDiv == 1)
                    {
                        lastResto[x] = lastDiv;
                    }

                } while (lastDiv != 1);
            }
            else
            {
                MessageBox.Show("Introduz um número positivo!", "aviso");
            }

            for (int i = x; i >= 0; i--)
            {
                visor2.Text += lastResto[i];
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
