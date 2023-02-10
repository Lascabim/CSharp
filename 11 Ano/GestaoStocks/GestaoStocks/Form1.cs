using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace GestaoStocks
{
    public partial class Stocks : Form
    {
        static string tempPath = System.IO.Path.GetTempPath();
        static string filepathSH = tempPath + "/SMhistoryM.txt";

        static StockClass sc = new StockClass();

        public Stocks()
        {
            InitializeComponent();

            int countLine = File.ReadAllLines(filepathSH).Length;

            if(countLine <= 3)
            {
                sc.RemoveHistory();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var AddP = new AddProduct();
            AddP.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Historico = new ProductHistory();
            Historico.Show();
        }

        private void Stocks_Load(object sender, EventArgs e)
        {

        }
    }
}
