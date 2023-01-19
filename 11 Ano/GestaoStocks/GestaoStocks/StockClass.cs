using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace GestaoStocks
{
    internal class StockClass
    {
        static string tempPath = System.IO.Path.GetTempPath();
        static string filepathPM = tempPath + "/SMprodutosM.txt";

        public void AddProducts(string nome, string preco, string quantidade)
        {
            FileStream file = new FileStream(filepathPM, FileMode.Append, FileAccess.Write);

            using (StreamWriter writetext = new StreamWriter(file))
            {
                writetext.WriteLine(nome + "|" + preco + "|" + quantidade+ "|");
            }
        }

        public bool ProductManager()
        {
            bool ready = false;

            if (File.Exists(filepathPM))
            {
                ready = true;
            }

            return ready;
        }
    }
}
