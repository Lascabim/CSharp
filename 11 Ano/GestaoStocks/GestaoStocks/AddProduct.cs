using Microsoft.VisualBasic;
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

namespace GestaoStocks
{
    public partial class AddProduct : Form
    {
        static string tempPath = System.IO.Path.GetTempPath();
        static string filepathPM = tempPath + "/SMprodutosM.txt";
        static StockClass sc = new StockClass();

        public AddProduct()
        {
            InitializeComponent();
            noProducts.Visible = false;

            bool hasProducts = sc.ProductManager();
            
            if(hasProducts)
            {
                GetProducts();
            }
            else
            {
                dataGridView1.Visible = false;
                noProducts.Visible = true;
            }
        }

        private void GetProducts()
        {
            using (StreamReader sr = new StreamReader(filepathPM))
            {
                while (sr.Peek() > -1)
                {
                    string nome, preco, quantiade;
                    int indexPause = 0, indexPause2 = 0, indexPause3 = 0;
                    string rawline = sr.ReadLine();

                    indexPause = rawline.IndexOf('|', indexPause);
                    indexPause2 = rawline.IndexOf('|', indexPause + 1);
                    indexPause3 = rawline.IndexOf('|', indexPause2 + 1);

                    nome = rawline.Substring(0, indexPause);
                    preco = rawline.Substring(indexPause + 1, (indexPause2 - nome.Length) - 1);
                    quantiade = rawline.Substring(indexPause2 + 1, (indexPause3 - nome.Length - preco.Length) - 2);

                    dataGridView1.Rows.Add(nome, preco + "€ ", quantiade);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeProduto = Interaction.InputBox("Nome do produto a adicionar: ").ToLower();
            string precoProduto = Interaction.InputBox("Preço do " + nomeProduto + ": ").ToLower();
            string quantidadeProduto = Interaction.InputBox("Quantidade do " + nomeProduto + ": ").ToLower();
        }
        private void AddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
