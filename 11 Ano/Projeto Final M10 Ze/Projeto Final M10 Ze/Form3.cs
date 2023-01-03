using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Projeto_Final_M10_Ze.Gestao;

namespace Projeto_Final_M10_Ze
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ClearRecibos();

            Recibos recibos = new Recibos();
            string rawNames = recibos.GetNames();

            string tempString;

            int lastN = 0;

            for (int i = 0; i < rawNames.Length; i++)
            {
                tempString = rawNames.Substring(i, 1);

                if (tempString == "|")
                {
                    string tempName = rawNames.Substring(lastN, (i - lastN));
                    comboBox2.Items.Add(tempName);

                    lastN = i + 1;
                }
            }
        }

        private void ClearRecibos()
        {
            Resultado.Clear();
            Resultado.Text += "---------------------------------------------------------\n";
            Resultado.Text += "\nRecibo Mensal\n";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Base = new Form1();
            Base.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(Resultado.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10,10));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearRecibos();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Recibos recibos = new Recibos();
            bool Ready = recibos.CheckRecibosInput(comboBox1.Text, comboBox2.Text);

            if(Ready)
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Recibos recibos = new Recibos();
            bool Ready = recibos.CheckRecibosInput(comboBox1.Text, comboBox2.Text);

            if (Ready)
            {
                Resultado.Clear();
                Resultado.Text += "---------------------------------------------------------\n";
                Resultado.Text += "\nRecibo Mensal\n";
                Resultado.Text += "---------------------------------------------------------\n";
                Resultado.Text += "\nNome: " + comboBox2.Text + "\n";
                Resultado.Text += "---------------------------------------------------------\n";
                Resultado.Text += "\nValor: " + comboBox1.Text + "\n";
                Resultado.Text += "---------------------------------------------------------\n";
                Resultado.Text += "Assinatura:";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Recibos recibos = new Recibos();
            bool Ready = recibos.CheckRecibosInput(comboBox1.Text, comboBox2.Text);

            if (Ready)
            {
                printDialog1.Document = printDocument1;
                printDialog1.ShowDialog();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
