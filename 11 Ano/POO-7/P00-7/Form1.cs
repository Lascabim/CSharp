using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P00_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            label2.Text = "Lado"; 

            textBox2.Visible = true;
            label2.Visible = true;

            textBox3.Visible = false;
            label3.Visible = false;

            textBox4.Visible = false;
            label4.Visible = false;
        }
        public class Areas
        {
            public double dado1, dado2, dado3;
            public double resultado;
            public void CalcArea(string tipo, string AV)
            {
                if(AV == "A")
                {
                    if (tipo == "quadrado")
                    {
                        resultado = dado1 * dado1;
                    }
                    else if (tipo == "retangulo")
                    {
                        resultado = dado1 * dado2;
                    }
                    else if (tipo == "triangulo")
                    {
                        resultado = (dado1 * dado2) / 2;
                    }
                    else if (tipo == "trapezio")
                    {
                        resultado = ((dado1 + dado2) * dado3) / 2;
                    }
                    else if (tipo == "circulo")
                    {
                        resultado = (dado1 * dado1) * 3.14;
                    }
                    else if (tipo == "losango")
                    {
                        resultado = (dado1 * dado2) / 2;
                    }
                }
                else if(AV == "V")
                {
                    if (tipo == "quadrado")
                    {
                        resultado = dado1 * dado1 * dado1;
                    }
                    else if (tipo == "retangulo")
                    {
                        resultado = dado1 * dado2 * dado3;
                    }
                    else if (tipo == "triangulo")
                    {
                        resultado = (dado1 * dado2) / 3;
                    }
                    else if (tipo == "trapezio")
                    {
                        resultado = (dado1 + dado2) * dado3 * 0.5;
                    }
                    else if (tipo == "circulo")
                    {
                        resultado = (4/3) * 3.14 * (dado1 * dado1 * dado1);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Areas cA = new Areas();

            if (radioButton1.Checked == true)
            {
                if (textBox2.Text != "")
                {
                    if(checkBox1.Checked == true)
                    {
                        cA.dado1 = Convert.ToDouble(textBox2.Text);
                        cA.CalcArea("quadrado", "V");
                        textBox5.Text = cA.resultado.ToString() + " m3";
                    }
                    else
                    {
                        cA.dado1 = Convert.ToDouble(textBox2.Text);
                        cA.CalcArea("quadrado", "A");
                        textBox5.Text = cA.resultado.ToString() + " m2";
                    }
                }
                else
                {
                    textBox5.Text = "Lado Inválido";
                }
            }
            else if (radioButton2.Checked == true)
            {
                if (textBox2.Text != "")
                {
                    if (textBox3.Text != "")
                    {
                        if (checkBox1.Checked == true)
                        {
                            cA.dado1 = Convert.ToDouble(textBox2.Text);
                            cA.dado2 = Convert.ToDouble(textBox3.Text);
                            cA.dado3 = Convert.ToDouble(textBox4.Text);

                            cA.CalcArea("retangulo", "V");
                            textBox5.Text = cA.resultado.ToString() + " m3";
                        }
                        else
                        {
                            cA.dado1 = Convert.ToDouble(textBox2.Text);
                            cA.dado2 = Convert.ToDouble(textBox3.Text);

                            cA.CalcArea("retangulo", "A");
                            textBox5.Text = cA.resultado.ToString() + " m2";
                        }
                    }
                    else
                    {
                        textBox5.Text = "Largura Inválida";
                    }
                }
                else
                {
                    textBox5.Text = "Comprimento Inválido";
                }
            }
            else if (radioButton4.Checked == true)
            {
                if (textBox2.Text != "")
                {
                    if (textBox3.Text != "")
                    {
                        if (checkBox1.Checked == true)
                        {
                            cA.dado1 = Convert.ToDouble(textBox2.Text);
                            cA.dado2 = Convert.ToDouble(textBox3.Text);

                            cA.CalcArea("triangulo", "V");
                            textBox5.Text = cA.resultado.ToString() + " m3";
                        }
                        else
                        { 
                            cA.dado1 = Convert.ToDouble(textBox2.Text);
                            cA.dado2 = Convert.ToDouble(textBox3.Text);

                            cA.CalcArea("triangulo", "A");
                            textBox5.Text = cA.resultado.ToString() + " m2";
                        }
                    }
                    else
                    {
                        textBox5.Text = "Altura Inválida";
                    }
                }
                else
                {
                    textBox5.Text = "Base Inválida";
                }
            }
            else if (radioButton3.Checked == true)
            {
                if (textBox2.Text != "")
                {
                    if (textBox3.Text != "")
                    {
                        if (textBox4.Text != "")
                        {

                            if (checkBox1.Checked == true)
                            {
                                cA.dado1 = Convert.ToDouble(textBox2.Text);
                                cA.dado2 = Convert.ToDouble(textBox3.Text);
                                cA.dado3 = Convert.ToDouble(textBox4.Text);

                                cA.CalcArea("trapezio", "V");
                                textBox5.Text = cA.resultado.ToString() + " m3";
                            }
                            else
                            {
                                cA.dado1 = Convert.ToDouble(textBox2.Text);
                                cA.dado2 = Convert.ToDouble(textBox3.Text);
                                cA.dado3 = Convert.ToDouble(textBox4.Text);

                                cA.CalcArea("trapezio", "A");
                                textBox5.Text = cA.resultado.ToString() + " m2";
                            }
                        }
                        else
                        {
                            textBox5.Text = "Altura Inválida";
                        }
                    }
                    else
                    {
                        textBox5.Text = "Base Menor Inválida";
                    }
                }
                else
                {
                    textBox5.Text = "Base Maior Inválida";
                }
            }
            else if (radioButton6.Checked == true)
            {
                if (textBox2.Text != "")
                {

                    if (checkBox1.Checked == true)
                    {
                        cA.dado1 = Convert.ToDouble(textBox2.Text);
                        cA.CalcArea("circulo", "V");
                        textBox5.Text = cA.resultado.ToString() + " m3";
                    }
                    else
                    {
                        cA.dado1 = Convert.ToDouble(textBox2.Text);
                        cA.CalcArea("circulo", "A");
                        textBox5.Text = cA.resultado.ToString() + " m2";
                    }

                }
                else
                {
                    textBox5.Text = "Raio Inválido";

                }
            }
            else if (radioButton5.Checked == true)
            {
                if (textBox2.Text != "")
                {
                    if (textBox3.Text != "")
                    {
                            cA.dado1 = Convert.ToDouble(textBox2.Text);
                            cA.dado2 = Convert.ToDouble(textBox3.Text);

                            cA.CalcArea("losango", "A");
                            textBox5.Text = cA.resultado.ToString() + " m2";
                    }
                    else
                    {
                        textBox5.Text = "Diagonal 2 Inválida";
                    }
                }
                else
                {
                    textBox5.Text = "Diagonal 1 Inválida";
                }
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                radioButton1.Text = "Cubo";
                radioButton2.Text = "Paralelepípedo";
                radioButton4.Text = "Pirâmide";
                radioButton6.Text = "Esfera";
            }
            else
            {
                radioButton1.Text = "Quadrado";
                radioButton2.Text = "Retângulo";
                radioButton4.Text = "Triângulo";
                radioButton3.Text = "Trapézio";
                radioButton6.Text = "Círculo";
                radioButton5.Text = "Losango";

            }

            //RETANGULO 

            if (checkBox1.Checked == true && radioButton2.Checked == true)
            {
                label4.Visible = true;
                textBox4.Visible = true;
                label4.Text = "Altura";
            }
            else if (checkBox1.Checked == false && radioButton2.Checked == true)
            {
                label4.Visible = false;
                textBox4.Visible = false;
            }

            //TRIANGULO
            else if (checkBox1.Checked == true && radioButton4.Checked == true)
            {
                label2.Text = "Area da Base";
            }
            else if (checkBox1.Checked == false && radioButton4.Checked == true)
            {
                label2.Text = "Base";
            }

            //LOSANGO
            else if (checkBox1.Checked == true && radioButton5.Checked == true)
            {
                textBox5.Text = "O Losango não é uma figura tridimensional";
            }
            else
            {
                textBox5.Text = "";
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            label2.Text = "Comprimento";
            label3.Text = "Largura";
            textBox5.Text = "";


            textBox2.Visible = true;
            label2.Visible = true;

            textBox3.Visible = true;
            label3.Visible = true;

            textBox4.Visible = false;
            label4.Visible = false;
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            label2.Text = "Base";
            label3.Text = "Altura";
            textBox5.Text = "";

            textBox2.Visible = true;
            label2.Visible = true;

            textBox3.Visible = true;
            label3.Visible = true;

            textBox4.Visible = false;
            label4.Visible = false;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            label2.Text = "Base Maior";
            label3.Text = "Base Menor";
            label4.Text = "Altura";
            textBox5.Text = "";

            textBox2.Visible = true;
            label2.Visible = true;

            textBox3.Visible = true;
            label3.Visible = true;

            textBox4.Visible = true;
            label4.Visible = true;
        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            label2.Text = "Raio";
            textBox5.Text = "";

            textBox2.Visible = true;
            label2.Visible = true;

            textBox3.Visible = false;
            label3.Visible = false;

            textBox4.Visible = false;
            label4.Visible = false;
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            label2.Text = "Diagonal 1";
            label3.Text = "Diagonal 2";
            textBox5.Text = "";

            textBox2.Visible = true;
            label2.Visible = true;

            textBox3.Visible = true;
            label3.Visible = true;

            textBox4.Visible = false;
            label4.Visible = false;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
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

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
