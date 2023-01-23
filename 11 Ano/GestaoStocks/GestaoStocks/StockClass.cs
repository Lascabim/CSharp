using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection.Emit;

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

        public void RemoveProduct(string productName)
        {
            if(File.Exists(filepathPM))
            {
                int countLine = File.ReadAllLines(filepathPM).Length;
                //MessageBox.Show(countLine.ToString());

                string[] linhasAGuardar = new string[countLine];

                StreamReader sr = new StreamReader(filepathPM);

                int x = 0;

                using (sr)
                {
                    while (sr.Peek() > -1)
                    {
                        string nomeF = "", precoF = "", quantidadeF = "";

                        int indexPause = 0;
                        int indexPause2 = 0;
                        int indexPause3 = 0;

                        string rawline = sr.ReadLine();

                        //GET

                        indexPause = rawline.IndexOf('|', indexPause);
                        indexPause2 = rawline.IndexOf('|', indexPause + 1);
                        indexPause3 = rawline.IndexOf('|', indexPause2 + 1);

                        // GET NOME
                        nomeF = rawline.Substring(0, indexPause);
                        int nomeL = nomeF.Length;
                        //MessageBox.Show(nomeF);


                        // GET PRECO
                        precoF = rawline.Substring(indexPause + 1, indexPause2 - nomeL - 1);
                        int precoL = precoF.Length;
                        //MessageBox.Show(precoF);

                        // GET QUANTIDADE
                        quantidadeF = rawline.Substring(indexPause + 1, indexPause2 - nomeL - precoL);
                        int quantidadeL = quantidadeF.Length;
                        //MessageBox.Show(quantidadeF);

                        if(nomeF != productName)
                        {
                            linhasAGuardar[x] = rawline;
                            x++;
                        }

                    }
                }

                sr.Close();

                File.Delete(filepathPM);

                foreach(string Linha in linhasAGuardar)
                {
                    if(Linha != null)
                    {
                        FileStream file = new FileStream(filepathPM, FileMode.Append, FileAccess.Write);

                        using (StreamWriter writetext = new StreamWriter(file))
                        {
                            writetext.WriteLine(Linha);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Não há produtos a remover!");
            }
        }


        public bool ProductManager()
        {
            bool ready = false;

            if (File.Exists(filepathPM))
            {
                int countLine = File.ReadAllLines(filepathPM).Length;
                if(countLine > 0)
                {
                    ready = true;
                }
            }

            return ready;
        }
    }
}
