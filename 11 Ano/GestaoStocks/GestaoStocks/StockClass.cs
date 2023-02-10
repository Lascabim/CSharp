﻿using System;
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
        static string filepathSH = tempPath + "/SMhistoryM.txt";

        public void AddProducts(string nome, string preco, string quantidade)
        {
            bool AllDigits = false;

            bool PrecoDigit = true, QuantidadeDigit = true;

            foreach (char c in preco)
            {
                if (c < '0' || c > '9')
                {
                    PrecoDigit = false;
                }
            }

            foreach (char c in quantidade)
            {
                if (c < '0' || c > '9')
                {
                    QuantidadeDigit = false;
                }
            }

            if(PrecoDigit && QuantidadeDigit)
            {
                AllDigits = true;
            }

            if (AllDigits)
            {
               FileStream file = new FileStream(filepathPM, FileMode.Append, FileAccess.Write);

               using (StreamWriter writetext = new StreamWriter(file))
               {
                   writetext.WriteLine(nome + "|" + preco + "|" + quantidade + "|");
               }
            }
            else
            {
                MessageBox.Show("Tens que introduzir apenas números na quantia e no preço!");
            }
        }

        public void EditProduct(string newPrice, string newQuantity, string Name)
        {
            int countLine = File.ReadAllLines(filepathPM).Length;

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

                    // GET PRECO
                    precoF = rawline.Substring(indexPause + 1, indexPause2 - nomeL - 1);
                    int precoL = precoF.Length;

                    // GET QUANTIDADE
                    quantidadeF = rawline.Substring(indexPause + 1, indexPause2 - nomeL - precoL);
                    int quantidadeL = quantidadeF.Length;

                    if (nomeF == Name)
                    {
                        string FullString = Name + "|" + newPrice + "|" + newQuantity + "|";
                        linhasAGuardar[x] = FullString;
                    }
                    else
                    {
                        linhasAGuardar[x] = rawline;
                    }

                    x++;
                }
            }

            sr.Close();

            File.Delete(filepathPM);

            foreach (string Linha in linhasAGuardar)
            {
                if (Linha != null)
                {
                    FileStream file = new FileStream(filepathPM, FileMode.Append, FileAccess.Write);

                    using (StreamWriter writetext = new StreamWriter(file))
                    {
                        writetext.WriteLine(Linha);
                    }
                }
            }

            MessageBox.Show("O produto '" + Name + "' foi editado!");
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


        /////////////////////////// HISTORY PART CLASS

        public void RemoveHistory()
        {
            string[] defaultHistoryLines = new string[3] { "Colar Ouro|online|-25|", "Anel de Rubi|online|+3|", "Relogio Rolex|online|-2|" };

            File.Delete(filepathSH);

            foreach (string Linha in defaultHistoryLines)
            {
                if (Linha != null)
                {
                    FileStream file = new FileStream(filepathSH, FileMode.Append, FileAccess.Write);

                    using (StreamWriter writetext = new StreamWriter(file))
                    {
                        writetext.WriteLine(Linha);
                    }
                }
            }
        }

        public void UpdateHistory(double newQuantity, string Name)
        {
            string Linha = Convert.ToString(Name) + "|offline|" + Convert.ToString(newQuantity) + "|";
            FileStream file = new FileStream(filepathSH, FileMode.Append, FileAccess.Write);

            using (StreamWriter writetext = new StreamWriter(file))
            {
                writetext.WriteLine(Linha);
            }

        }
    }
}
