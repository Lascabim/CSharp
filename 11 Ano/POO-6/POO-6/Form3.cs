using System.Windows.Forms;
using System.IO;

namespace POO_6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            string tempPath = System.IO.Path.GetTempPath();

            if (!Directory.Exists(tempPath))
            {
                Directory.CreateDirectory(tempPath);
            }

            string filepath = tempPath + "/salarios.txt";

            using (StreamReader sr = new StreamReader(filepath))
            {
                while (sr.Peek() > -1)
                {
                    string nome, hextra, sbruto, descontotal, sliquido;
                    int indexPause = 0, indexPause2 = 0,indexPause3 = 0, indexPause4 = 0, indexPause5 = 0;
                    string rawline = sr.ReadLine();

                    indexPause = rawline.IndexOf('|', indexPause);
                    indexPause2 = rawline.IndexOf('|', indexPause + 1);
                    indexPause3 = rawline.IndexOf('|', indexPause2 + 1);
                    indexPause4 = rawline.IndexOf('|', indexPause3 + 1);
                    indexPause5 = rawline.IndexOf('|', indexPause4 + 1);

                    nome = rawline.Substring(0, indexPause);
                    hextra = rawline.Substring(indexPause + 1, (indexPause2 - nome.Length) - 1);
                    sbruto = rawline.Substring(indexPause2 + 1, (indexPause3 - nome.Length - hextra.Length) - 2 );
                    descontotal = rawline.Substring(indexPause3 + 1, (indexPause4 - nome.Length - hextra.Length - sbruto.Length) - 3);
                    sliquido = rawline.Substring(indexPause4 + 1, (indexPause5 - nome.Length - hextra.Length - sbruto.Length - descontotal.Length) - 4);
                    
                    dataGridView1.Rows.Add(nome, hextra + "€", sbruto + "€", descontotal + "€", sliquido + "€");
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
