using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace M5_Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
        }

        public struct Dados
        {
            public string num_mod;
            public string title_mod;
            public string nota_teste;
            public string nota_mod;
        }

        static int x = 0, y = 0;
        static int soma = 0, cont = 0;
        static float media_notas = 0;
        static Dados[] dados = new Dados[7];

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Visible = true;

            if(x < 8)
            {
                groupBox1.Visible=false;
                groupBox2.Visible=true;
            }
            else
            {
                MessageBox.Show("Já tens 7 Módulos registrados!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int contador = 1, zz = 0;
            string pesquisa = Interaction.InputBox("Introduz o título do modo a pesquisar:");
       
            while(contador != 0 && contador < 8)
            {
                    if (pesquisa == dados[zz].title_mod)
                    {
                        MessageBox.Show("Dados encontrados e introduzidos na tabela para verificação!");
                        dataGridView2.Rows.Add(dados[zz].title_mod, dados[zz].nota_teste, dados[zz].nota_mod);
                        contador = 0;
                    }
                    else
                    {
                    contador++;
                    }   
                    zz++;
            }
            

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (x < 8)
            {

                for(int i = 0; i < x; i++)
                {
                    if (textBox1.Text != dados[i].num_mod && textBox2.Text != dados[i].title_mod && int.Parse(textBox3.Text) < 21 && int.Parse(textBox3.Text) > -1)
                    {
                            y = 0;
                    }
                    else
                    {
                        y = 1;
                    }
                }

                if (y == 0)
                {
                    dados[x].num_mod = textBox1.Text;
                    dados[x].title_mod = textBox2.Text;
                    dados[x].nota_teste = textBox3.Text;
                    dados[x].nota_mod = textBox4.Text;

                    soma = soma + int.Parse(textBox3.Text);
                    cont++;

                    MessageBox.Show("Módulo registrado!");
                    x++;
                }
                else
                {
                    MessageBox.Show("Estás a repetir módulos!", "ERROR");
                }
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (soma == 0)
            {
                MessageBox.Show("Ainda não foram introduzidos módulos!");
            }
            else
            {
                media_notas = soma / cont;
                dataGridView1.Rows.Add(media_notas);

                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
            }
        }
    }
}
