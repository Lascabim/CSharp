using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Loja_Online
{
    public partial class Carrinho : Form
    {
        static int PrecoTotal = 0;

        public Carrinho()
        {
            InitializeComponent();

            string tempPath = System.IO.Path.GetTempPath();
            string filepath = tempPath + "/pedidos.txt";

            if (!File.Exists(filepath))
            {

                File.Create(filepath);

            }

            StreamReader sr;
            sr = new StreamReader(filepath);

            using (sr)
            {
                PrecoTotal = 0;

                while (sr.Peek() > -1)
                {
                    string Item = "", Preco, Morada, Date, ID;

                    int ItemL, PrecoL, MoradaL, DateL, IDL;

                    int itemPause = 0;

                    int indexPause = 0;
                    int indexPause2 = 0;
                    int indexPause3 = 0;
                    int indexPause4 = 0;
                    int indexPause5 = 0;

                    string rawline = sr.ReadLine();

                    //GET |
                    itemPause = rawline.IndexOf('|', itemPause) - 6;

                    indexPause = rawline.IndexOf('|', indexPause);
                    indexPause2 = rawline.IndexOf('|', indexPause + 1);
                    indexPause3 = rawline.IndexOf('|', indexPause2 + 1);
                    indexPause4 = rawline.IndexOf('|', indexPause3 + 1);
                    indexPause5 = rawline.IndexOf('|', indexPause4 + 1);

                    // GET ITEM
                    Item = rawline.Substring(6, itemPause);
                    ItemL = Item.Length;

                    //GETPRICE
                    PrecoL = (indexPause2 - indexPause) - 1;

                    if (ItemL < 7)
                    {
                        int tempItem = 7 - ItemL;

                        ItemL = tempItem + ItemL;
                    }

                    Preco = rawline.Substring(itemPause + ItemL, PrecoL);

                    MoradaL = (indexPause3 - indexPause2) - 1;
                    Morada = rawline.Substring(itemPause + ItemL + PrecoL + 1, MoradaL);


                    DateL = (indexPause4 - indexPause3) - 1;
                    Date = rawline.Substring(itemPause + ItemL + PrecoL + 1 + MoradaL + 1, DateL);

                    IDL = (indexPause5 - indexPause4) - 1;
                    ID = rawline.Substring(itemPause + ItemL + PrecoL + 1 + MoradaL + 1 + DateL + 1, IDL);

                    PrecoTotal = PrecoTotal + Convert.ToInt32(Preco);

                    if(PrecoTotal < 70)
                    {
                        label5.Text = Convert.ToString(PrecoTotal / 2) + "€";
                    }
                }
            }

            sr.Close();
            

            label6.Text = Convert.ToString(PrecoTotal) + "€";

            if (radioButton1.Checked)
            {
                FinalPrice(0.04);
            }
            else if (radioButton2.Checked)
            {
                FinalPrice(0.02);
            }
            else
            {
                FinalPrice(0.00);
            }
        }

        private void FinalPrice(double percent)
        {
            label9.Text = Convert.ToString((PrecoTotal * percent)) + "€";
            label7.Text = Convert.ToString((PrecoTotal * percent) + PrecoTotal + (PrecoTotal/2)) + "€";

        }

        private void button1_Click(object sender, EventArgs e)
        {

                if(radioButton1.Checked)
                {
                    string cartaIN = Interaction.InputBox("Introduz o número do cartão: ", "Número do cartão!");
                
                    if(cartaIN.Length == 16 )
                    {
                    
                    }
                    else
                    {
                        MessageBox.Show("Número de cartão inválido");
                        return;
                }
            }
                else if(radioButton2.Checked)
                {
                    string cartaIN = Interaction.InputBox("Introduz o número do cartão: ", "Número do cartão!");

                    if (cartaIN.Length == 16)
                    {
                    
                    }
                    else
                    {
                        MessageBox.Show("Número de cartão inválido");
                        return;
                    }
                }

            string moradaIN = Interaction.InputBox("Introduz a morada: ", "Envio de pedido!");
        
            if(moradaIN.Length > 6)
            {
                MessageBox.Show("Produto enviado com sucesso!");
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                FinalPrice(0.04);
            }
            else if (radioButton2.Checked)
            {
                FinalPrice(0.02);
            }
            else
            {
                FinalPrice(0.00);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            var Forms1 = new Form1();
            Forms1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string tempPath = System.IO.Path.GetTempPath();
            string filepath = tempPath + "/pedidos.txt";


            File.Delete(filepath);

            File.Create(filepath);

            MessageBox.Show("Carrinho Limpo");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Carrinho_Load(object sender, EventArgs e)
        {

        }
    }
}
