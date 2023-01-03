using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Fila
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string[] fila = new string[10];
        static int[] pos = new int[10];
        static int x = 0;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Atendimento()
        {
            for(int i = 0; i < x ;i++)
            {
                fila[i] = fila[i + 1];
            }

            x = x - 1;

            RefreshData();
        }

        private void RefreshData()
        {
            textBox1.Clear();
            dataGridView1.Rows.Clear();


            for(int i = 0; i < x; i++)
            {
                dataGridView1.Rows.Add(i + 1, fila[i]);
            }


        }

        private void Remover(int pessoa)
        {
            string flag = "S";
            int y = 0;

            while(flag == "S")
            {

                    if(pessoa == pos[y])
                    {
                        flag = "N";

                        for(int i = y; i < x;i++)
                        {
                            fila[i] = fila[i + 1];
                        }

                        x = x - 1;
                        RefreshData();
                    }
                    else
                    {
                        y++;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            { 
                if(x < fila.Length)
                {
                    fila[x] = textBox1.Text;
                    pos[x] = x;
                    x++;
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("A fila está cheia, espera um bocado!");
                }
            }
            else
            {
                MessageBox.Show("Tens que introduzir um nome!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(x != 0 && x < fila.Length)
            {
                int pessoa_rr = int.Parse(Interaction.InputBox("Número da pessoa a remover!", "PESSOA A REMOVER"));
                
                if(pessoa_rr > x)
                {
                    MessageBox.Show("Número Inválido!", "ERRO");
                }
                else
                {
                    int pessoa_r = pessoa_rr - 1;
                    Remover(pessoa_r);
                }

            }
            else
            {
                MessageBox.Show("Ainda não foram introduzidas pessoas!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (x != 0 && x < fila.Length)
            {
                Atendimento();
            }
            else
            {
                MessageBox.Show("Ainda não foram introduzidas pessoas!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
