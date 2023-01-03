using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace M5_Ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            voltar.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
   //         groupBox4.Visible = false;
   //         groupBox5.Visible = false;
        }

        public struct Dados
        {
            public string numero;
            public string nome;
            public string morada;
            public string cpostal;
            public string contacto;
        }

        static Dados[] dados = new Dados[20];
        static int x = 0, y = 0;

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            voltar.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            voltar.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
  //          groupBox4.Visible = false;
  //          groupBox5.Visible = false;

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(x != 0)
            {
                string procurar_num = Interaction.InputBox("Introduz o número de telemóvel a procurar");
                string referencia = "N";
                int i = 0;
                int aviso = 0;


                while (referencia == "N")
                {
                    if (i < x)
                    {
                        if (dados[i].numero == procurar_num)
                        {
                            referencia = "S";
                            MessageBox.Show("Dados encontrados!");
                            aviso = 1;
                        }
                        else
                        {
                            i++;
                        }
                    }
                    else
                    {
                        referencia = "S";
                    }
                }

                if (aviso == 0)
                {
                    MessageBox.Show("Dados não encontrados");
                }
            }
            else
            {
                MessageBox.Show("Ainda não foram introduzidos números");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (x != 0)
            {

                int a_flag = 0;
                string numero_novo;
                string contato_alterar = Interaction.InputBox("Introduzo número do contacto que pretendes alterar");


                while (a_flag != 99999999)
                {
                    if (a_flag < x)
                    {
                        if (contato_alterar == dados[a_flag].numero)
                        {

                            numero_novo = Interaction.InputBox("Introduzo o novo número", "DADOS ENCONTRADOS");
                            dados[a_flag].numero = numero_novo;

                            dataGridView1.Rows.Clear();

                            for(int i = 0; i<x; i++)
                            {
                                dataGridView1.Rows.Add(dados[i].numero, dados[i].nome, dados[i].morada, dados[i].cpostal, dados[i].contacto);
                            }

                            a_flag = 99999999;
                        }
                        else
                        {
                            a_flag++;
                        }
                    }
                    else
                    {
                        a_flag = 99999999;
                    }
                   
                }
            }
            else
            {
                MessageBox.Show("Ainda não foram introduzidos números");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (x != 0)
            {
                voltar.Visible = true;
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
            }
            else
            {
                MessageBox.Show("Ainda não foram introduzidos números");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (x != 0)
            {

                string contacto_apagar =  Interaction.InputBox("Introduz o número do contacto a eliminar!", "ELIMINAÇÃO");
                int flag = 0;
                int bandeira = 0;

                while (flag == 0)
                {
                    if(bandeira < x)
                    {
                        if (contacto_apagar == dados[bandeira].numero)
                        {
                            flag = 1;

                            for(int i = bandeira; i<x; i++)
                            {
                                dados[bandeira].numero = dados[bandeira + 1].numero;
                                dados[bandeira].nome = dados[bandeira + 1].nome;
                                dados[bandeira].morada = dados[bandeira + 1].morada;
                                dados[bandeira].cpostal = dados[bandeira + 1].cpostal;
                                dados[bandeira].contacto = dados[bandeira + 1].contacto;
                            }

                            dataGridView1.Rows.Clear();
                            
                            for(int i = 0; i < x-1 ;i++)
                            {
                                dataGridView1.Rows.Add(dados[i].numero, dados[i].nome, dados[i].morada, dados[i].cpostal, dados[i].contacto);
                            }

                            x = x - 1;

                            MessageBox.Show("Contacto removido e atualizado!");

                        }

                        bandeira++;
                    }
                    else
                    {
                        flag = 1;
                    }
                   
                }

            }
            else
            {
                MessageBox.Show("Ainda não foram introduzidos números");
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (x < 20)
            {

                for (int i = 0; i < x; i++)
                {
                    if (dados[x].numero !=  textBox1.Text &&
                        dados[x].nome != textBox2.Text &&
                        dados[x].morada != textBox3.Text &&
                        dados[x].cpostal != textBox4.Text &&
                        dados[x].contacto != textBox5.Text)
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
                    dados[x].numero = textBox1.Text;
                    dados[x].nome = textBox2.Text;
                    dados[x].morada = textBox3.Text;
                    dados[x].cpostal = textBox4.Text;
                    dados[x].contacto = textBox5.Text;

                    dataGridView1.Rows.Add(dados[x].numero, dados[x].nome, dados[x].morada, dados[x].cpostal, dados[x].contacto);


                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();


                    MessageBox.Show("Registado!");
                    x++;
                }
                else
                {
                    MessageBox.Show("Estás a repetir números!", "ERRO");
                }

            }
        }
    }
}
