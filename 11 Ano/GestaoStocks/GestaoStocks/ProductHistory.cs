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
    public partial class ProductHistory : Form
    {
        static string tempPath = System.IO.Path.GetTempPath();
        static string filepathPM = tempPath + "/SMprodutosM.txt";
        static string filepathSH = tempPath + "/SMhistoryM.txt";

        static StockClass sc = new StockClass();

        public ProductHistory()
        {
            InitializeComponent();
            //sc.RemoveHistory();
            GetStockHistory();
        }

        public void GetStockHistory()
        {
            dataGridView1.Rows.Clear();
            
            int countLine = File.ReadAllLines(filepathSH).Length;

            if (File.Exists(filepathSH))
            {
                using (StreamReader sr = new StreamReader(filepathSH))
                {

                    while (sr.Peek() > -1)
                    {
                        string nome, preco, quantidade, data, dataTemp;
                        int indexPause = 0, indexPause2 = 0, indexPause3 = 0, indexPause4 = 0;
                        string rawline = sr.ReadLine();

                        indexPause = rawline.IndexOf('|', indexPause);
                        indexPause2 = rawline.IndexOf('|', indexPause + 1);
                        indexPause3 = rawline.IndexOf('|', indexPause2 + 1);
                        indexPause4 = rawline.IndexOf('|', indexPause3 + 1);

                        nome = rawline.Substring(0, indexPause);
                        preco = rawline.Substring(indexPause + 1, (indexPause2 - nome.Length) - 1);
                        quantidade = rawline.Substring(indexPause2 + 1, (indexPause3 - nome.Length - preco.Length) - 2);
                        
                        dataTemp = rawline.Substring(indexPause3 + 1);
                        data = dataTemp.Substring(0, 10);

                        string quantidadeType = quantidade.Substring(0, 1);
                        dataGridView1.Rows.Add(nome, preco, quantidade, data);
                    }
                }
            }
            else 
            {
                sc.RemoveHistory();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f1 = new Stocks();
            f1.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Prentes eliminar o histórico?", "Remover Histórico", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                sc.RemoveHistory();
                GetStockHistory();
            }
        }

        private void ProductHistory_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
