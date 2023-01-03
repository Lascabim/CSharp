using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace M5_Ex6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct  Dados
        {
            public string codigo;
            public string nome;
            public int stock;
        }

        static Dados[] dados = new Dados[100];
        static int x = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            string codigo_eliminar = Interaction.InputBox("Código do produto a eliminar: ", "ELIMINAÇÃO");

            int y = 0;
            int i = 0;


            while (y == 0)
            {
                if(i < x)
                {

                    if (codigo_eliminar == dados[i].codigo)
                    {

                        for (int z = i; z < x; z++)
                        {
                            dados[z].codigo = dados[z + 1].codigo;
                            dados[z].nome = dados[z + 1].nome;
                            dados[z].stock = dados[z + 1].stock;
                        }

                        dataGridView1.Rows.Clear();

                        for (int o = 0; o < x -1 ; o++)
                        {
                            dataGridView1.Rows.Add(dados[o].codigo, dados[o].nome, dados[o].stock);
                        }

                        x = x - 1;
                        MessageBox.Show("Produto Eliminado!");
                    }
                    else
                    {
                        i++;
                    }

                }
                else
                {
                    y = 1; 
                }
              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigo = Interaction.InputBox("Código do produto: ", "CÓDIGO");
            string nome = Interaction.InputBox("Nome do produto: ", "NOME");
            int stock = int.Parse(Interaction.InputBox("Stock do produto: ", "STOCK"));
            int iniciador = 0;

            if (x != 0)
            {
                for (int i = 0; i < x; i++)
                {
                    if (codigo != dados[i].codigo)
                    {
                        iniciador = 1;
                    } 

                }
            }
            else if (x == 0)
            {
                iniciador = 1;
            }

            if (stock > -1 && codigo != "" && nome != "" && iniciador == 1)
            {
                dados[x].codigo = codigo;
                dados[x].nome = nome;
                dados[x].stock = stock;

                MessageBox.Show("Dados Registados!");
                x++;

                dataGridView1.Rows.Clear();

                for (int i = 0; i<x; i++)
                {
                    dataGridView1.Rows.Add(dados[i].codigo, dados[i].nome, dados[i].stock);
                }

            }
            else
            {
                MessageBox.Show("Tens que introduzir campos válidos e não podes repetir códigos!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (x != 0)
            {

                string pesquisa = Interaction.InputBox("Nome do produto a pesquisar!", "PESQUISA");

                for (int i = 0; i < x; i++)
                {

                    if (pesquisa == dados[i].nome)
                    {
                        MessageBox.Show("Produto encontrado");
                    }
                }
            }
            else
            {
                MessageBox.Show("Não foram introduzidos produtos!");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string codigo_referencia = Interaction.InputBox("Código do stock a diminuir o stock!", "DIMINUIÇÃO");
            int stock_diminuido = int.Parse(Interaction.InputBox("Número do stock diminuido!", "DIMINUIÇÃO"));


            int flag = 0;
            int refe = 0;

            while(flag == 0)
            {
                if(refe < x)
                {

                    if (dados[refe].codigo == codigo_referencia)
                    {
                        flag = 1;

                        if (dados[refe].stock > stock_diminuido)
                        {
                            dados[refe].stock = stock_diminuido;

                            dataGridView1.Rows.Clear();

                            for (int i = 0; i < x; i++)
                            {
                                dataGridView1.Rows.Add(dados[i].codigo, dados[i].nome, dados[i].stock);
                            }

                            MessageBox.Show("Stock Diminuido!");

                        }

                    }
                    else
                    {
              
                        refe++;
                    }
                }
                else
                {
                    MessageBox.Show("Erro!");
                    flag = 1;
                }
                

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string codigo_referencia = Interaction.InputBox("Código do stock a diminuir o stock!", "AUMENTADO");
            int stock_aumentado = int.Parse(Interaction.InputBox("Número do stock aumentado!", "AUMENTADO"));

            int flag = 0;
            int refe = 0;

            while (flag == 0)
            {

                if(refe < x)
                {


                    if (dados[refe].codigo == codigo_referencia)
                    {
                        flag = 1;

                        if (dados[refe].stock < stock_aumentado)
                        {
                            dados[refe].stock = stock_aumentado;

                            dataGridView1.Rows.Clear();

                            for (int i = 0; i < x; i++)
                            {
                                dataGridView1.Rows.Add(dados[i].codigo, dados[i].nome, dados[i].stock);
                            }

                            MessageBox.Show("Stock Aumentado!");

                        }

                    }
                    else
                    {
                        
                        refe++;
                    }

                }
                else
                {
                    MessageBox.Show("Erro!");
                    flag = 1;
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(x != 0)
            {
                for (int i = 0; i < x; i++)
                {
                    if (dados[i].stock < 10)
                    {
                        dataGridView2.Rows.Add(dados[i].nome);
                    }
                }
            }
            else
            {
                MessageBox.Show("Não foram introduzidos produtos!");
            }
           
        }
    }
}
