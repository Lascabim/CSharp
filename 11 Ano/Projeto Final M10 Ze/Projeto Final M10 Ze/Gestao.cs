using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_Final_M10_Ze
{
    internal class Gestao
    {

        public class Insc
        {
            public bool japraticou;
            public string nome, telemovel, nif, OquePraticou = "";

            public void SaveInsc()
            {
                Gestao g = new Gestao();

                string tempPath = System.IO.Path.GetTempPath();
                string filepath = tempPath + "/MInsc.txt";

                FileStream file;
                file = new FileStream(filepath, FileMode.Append, FileAccess.Write);

                using (StreamWriter writetext = new StreamWriter(file))
                {

                    if (OquePraticou == "")
                    {
                        OquePraticou = "Nulo";
                    }

                    writetext.WriteLine(nome + "|" + telemovel + "|" + nif + "|" + OquePraticou + "|");
                }
            }

            public bool CheckInscInput()
            {
                Gestao g = new Gestao();

                if (nome != "" && telemovel != "" && nif != "")
                {
                    string telemovelCheck = telemovel.Substring(0, 1);

                    if (nome.Length < 8)
                    {   
                        MessageBox.Show("Nome demasiado curto");
                        return false;
                    }

                    if (telemovelCheck != "9")
                    {
                        MessageBox.Show("Número de telemóvel inválido");
                        return false;
                    }
                    else if (telemovel.Length < 9)
                    {
                        MessageBox.Show("Número de telemóvel demasiado curto");
                        return false;
                    }

                    if (nif.Length < 8)
                    {
                        MessageBox.Show("NIF demasiado curto");
                        return false;
                    }

                    if (japraticou)
                    {
                        OquePraticou = Interaction.InputBox("Arte Marcial Já Praticada:");
                    }

                    SaveInsc();

                    return true;

                }
                else
                {
                    MessageBox.Show("Introduções Inválidas");
                    return false;
                }
            }
        }

        public class Recibos
        {
            public string name;

            public string GetNames()
            {
                string tempPath = System.IO.Path.GetTempPath();
                string filepath = tempPath + "/Minsc.txt";
  
                    StreamReader sr;
                    sr = new StreamReader(filepath);

                    using (sr)
                    {
                        while (sr.Peek() > -1)
                        {
                            int itemPause = 0;
                            int indexPause = 0;

                            string rawline = sr.ReadLine();

                            //GET |
                            itemPause = rawline.IndexOf('|', itemPause);
                            indexPause = rawline.IndexOf('|', indexPause);
                            name = name + rawline.Substring(0, indexPause) + "|";
                        }
                    }

                    sr.Close();

                    return name;
            }

            public bool CheckRecibosInput(string In1, String In2)
            {
                if (In2 == "")
                {
                    MessageBox.Show("Introduz um nome válido");
                    return false;
                }
                if (In1 == "25€" || In1 == "30€" || In1 == "45€")
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Introduz um valor válido");
                    return false;
                }
            }
        }
    }
}
