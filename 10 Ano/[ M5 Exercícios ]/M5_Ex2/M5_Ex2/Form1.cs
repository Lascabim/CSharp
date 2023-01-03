using System;
using System.Media;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace M5_Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        public struct Dados
        {
            public string num_aluno;
            public string nome;
            public string morada;
            public string num_telemovel;
            public string nascimento;
            public string num_bi;
            public string nome_e;
            public string media;
        }

        static Dados[] dados = new Dados[999999];
        static int x = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        

                    if (comboBox1.Text == "INTRODUZIR NOVOS DADOS")
                    {
                        groupBox1.Visible = false;
                        groupBox2.Visible = true;
                    }
                    else if (comboBox1.Text == "MOSTRAR DADOS")
                    {
                        groupBox1.Visible = false;
                        groupBox2.Visible = false;
                        groupBox3.Visible = true;
                    }
                    else if(comboBox1.Text == "GUARDAR FICHEIRO E SAIR")
                    {
                        Close();
                    }     
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            numerozinho.Clear();
            nomezinho.Clear();
            moradinha.Clear();
            telemovelzinho.Clear();
            nascimentinho.Clear();
            cczinho.Clear();
            encarregadinho.Clear();
            mediazinha.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int veriidade, ano_atual = 2022;

            if (nascimentinho.Text == "")
            {
                MessageBox.Show("Tens que introduzir uma idade!");
            }
            else
            {

                veriidade = ano_atual - int.Parse(nascimentinho.Text);

                if (veriidade >= 15)
                {

                    dados[x].num_aluno = numerozinho.Text;
                    dados[x].nome = nomezinho.Text;
                    dados[x].morada = moradinha.Text;
                    dados[x].num_telemovel = telemovelzinho.Text;
                    dados[x].nascimento = nascimentinho.Text;
                    dados[x].num_bi = cczinho.Text;
                    dados[x].nome_e = encarregadinho.Text;
                    dados[x].media = mediazinha.Text;

                    dataGridView1.Rows.Add(dados[x].num_aluno, dados[x].nome, dados[x].morada, dados[x].num_telemovel, dados[x].nascimento, dados[x].num_bi, dados[x].nome_e, dados[x].media);

                    x = x + 1;

                    MessageBox.Show("Dados Enviados!");
                    numerozinho.Clear();
                    nomezinho.Clear();
                    moradinha.Clear();
                    telemovelzinho.Clear();
                    nascimentinho.Clear();
                    cczinho.Clear();
                    encarregadinho.Clear();
                    mediazinha.Clear();
                }
                else
                {
                    MessageBox.Show("ERRO - Confirme a data de nascimento!", "ERROR");
                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;

            numerozinho.Clear();
            nomezinho.Clear();
            moradinha.Clear();
            telemovelzinho.Clear();
            nascimentinho.Clear();
            cczinho.Clear();
            encarregadinho.Clear();
            mediazinha.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;

            numerozinho.Clear();
            nomezinho.Clear();
            moradinha.Clear();
            telemovelzinho.Clear();
            nascimentinho.Clear();
            cczinho.Clear();
            encarregadinho.Clear();
            mediazinha.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string num_atual, referencia = "N";
            int aviso = 0, i = 0;
            string ano_novo, telemovel_novo;
            num_atual = Interaction.InputBox("Terás que introduzir o número do aluno para procurar pelo mesmo:", "... PROCURAR ...", "Nº do aluno");
    

            while (referencia == "N")
            {
                if (i < x)
                {

                    if (num_atual == dados[i].num_aluno)
                    {
                        referencia = "S";
                        ano_novo = Interaction.InputBox("Ano de nascimento novo:", "... ANO DE NASCIMENTO ...", "Nº do ano");
                        telemovel_novo = Interaction.InputBox("Número de telemóvel novo:", "... TELEMÓVEL ...", "Nº Télemóvel");

                        dados[i].nascimento = ano_novo;
                        dados[i].num_telemovel = telemovel_novo;

                        aviso = 1;
                    }                  
                }
                i++;
            }

            if (aviso == 0)
            {
                MessageBox.Show("Os dados não foram encontrados!");
            }

            int y = 0, Z = x;
            int HA = 0, HI = x;

            while (HA < HI)
            {
                dataGridView1.Rows.Clear();
                HA++;
            }

            while (y < Z)
            {
                dataGridView1.Rows.Add(dados[y].num_aluno, dados[y].nome, dados[y].morada, dados[y].num_telemovel, dados[y].nascimento, dados[y].num_bi, dados[y].nome_e, dados[y].media);
                y++;
            }

        }
    }
}
