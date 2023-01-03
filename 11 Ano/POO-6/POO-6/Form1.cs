using System;
using System.Windows.Forms;
using System.IO;

namespace POO_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            panel1.Visible = true;
            groupBox1.Hide();
            listBox1.Hide();
            button1.Visible = false;
            button2.Visible = false;
            button6.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            MessageBox.Show("Tabela Limpa");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
        }

        private void textBox9_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            textBox8.Clear();
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            textBox9.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }

        private void textBox1_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
    
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
   
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public class Calcular
        {
            public string nome;
            public double sal, HED, HEN, ND, FAL, DE, REF, VAL;
            public double hextra, sfamilia, sbruto;
            public double INAMPS, faltas, meals, vales, descontosEventuais, renda;
            public double descontototal, sliquido;

            public void CalcSal()
            {

                hextra = (HED * sal / 160 + HEN * 1.2 * sal / 160);
                sfamilia = ND * 0.05 * sal;
                sbruto = sal + sfamilia + hextra;

                INAMPS = 0.08 * sal;
                faltas = FAL * sal / 160;
                meals = REF;
                vales = VAL;
                descontosEventuais = DE;
                renda = 0.08 * sal;

                descontototal = INAMPS + faltas + meals + vales + descontosEventuais + renda;
                sliquido = sbruto - descontototal;
            }

            public void SaveFile()
            {
                string tempPath = System.IO.Path.GetTempPath();

                if (!Directory.Exists(tempPath))
                {
                    Directory.CreateDirectory(tempPath);
                }

                string filepath = tempPath + "/salarios.txt";
                
                FileStream file;
                file = new FileStream(filepath, FileMode.Append, FileAccess.Write);

                using (StreamWriter writetext = new StreamWriter(file))
                {
                   writetext.WriteLine(nome + "|" + hextra + "|" + sbruto + "|" + descontototal + "|" + sliquido + "|");
                } 
            }
        }

        public bool CheckMarks()
        {
            bool marked = false;

            if(textBox1.Text != "" && 
                textBox2.Text != "" &&
                textBox3.Text != "" &&
                textBox6.Text != "" &&
                textBox5.Text != "" &&
                textBox4.Text != "" &&
                textBox9.Text != "" &&
                textBox8.Text != "" &&
                textBox7.Text != "")
            {
                if(textBox1.Text != "Nome" &&
                    textBox2.Text != "Salário" &&
                    textBox3.Text != "Horas Extras Diurnas" &&
                    textBox6.Text != "Horas Extras Noturnas" &&
                    textBox5.Text != "Número de Dependentes" &&
                    textBox5.Text != "Faltas em Horas" &&
                    textBox5.Text != "Descontos Eventuais" &&
                    textBox5.Text != "Gastos com Refeições" &&
                    textBox5.Text != "Vales Retidos")
                {
                    marked = true;
                }
            }
            return marked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool allMarked = CheckMarks();

            if (allMarked)
            {
                Calcular calc = new Calcular();
                listBox1.Items.Clear();

                calc.nome = textBox1.Text;
                calc.sal = Convert.ToDouble(textBox2.Text);
                calc.HED = Convert.ToDouble(textBox3.Text);
                calc.HEN = Convert.ToDouble(textBox6.Text);
                calc.ND = Convert.ToDouble(textBox5.Text);
                calc.FAL = Convert.ToDouble(textBox4.Text);
                calc.DE = Convert.ToDouble(textBox9.Text);
                calc.REF = Convert.ToDouble(textBox8.Text);
                calc.VAL = Convert.ToDouble(textBox7.Text);

                calc.CalcSal();
                calc.SaveFile();

                listBox1.Items.Add("Nome: " + calc.nome);
                listBox1.Items.Add("Horas extras: " + calc.hextra + "€");
                listBox1.Items.Add("Salário Bruto: " + calc.sbruto + "€");
                listBox1.Items.Add("Descontos no Total: " + calc.descontototal.ToString() + "€");
                listBox1.Items.Add("Salário Líquido: " + calc.sliquido + "€");
            }
            else
            {
                MessageBox.Show("Tens que preencher todos os campos corretamente!");
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string tempPath = System.IO.Path.GetTempPath();

            if (!Directory.Exists(tempPath))
            {
                Directory.CreateDirectory(tempPath);
            }

            string filepath = tempPath + "/salarios.txt";

            if(!File.Exists(filepath))
            {
                MessageBox.Show("Histórico Vazio");
                return;
            }
            else
            {
                Form3 form = new Form3();
                form.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            groupBox1.Show();
            listBox1.Show();
            button1.Visible = true;
            button2.Visible = true;
            button6.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string tempPath = System.IO.Path.GetTempPath();

            string filepath = tempPath + "/salarios.txt";

            if (File.Exists(filepath))
            {
                File.Delete(filepath);
                MessageBox.Show("Histórico Apagado");
                return;
            }
            else
            {
                Form3 form = new Form3();
                form.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    public class Calcular
    {
        private string nome;

        public void calcular()
        {
            throw new System.NotImplementedException();
        }

        public void savefile()
        {
            throw new System.NotImplementedException();
        }

        public bool checkmarks()
        {
            throw new System.NotImplementedException();
        }
    }
}
