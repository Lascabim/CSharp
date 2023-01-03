using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2
{
    internal class Program
    {

        class Retangulo
        {
            public double largura, altura;

            public double GetArea()
            {
                double area = largura * altura;
                return area;
            }

            public double GetPerimetro()
            {
                double perimetro = (largura+largura) + (altura+altura);
                return perimetro;
            }

            public double GetDiagonal()
            {
                double diagonal = Math.Sqrt((largura * largura) + (altura * altura));
                return diagonal;
            }

        }

        static void Main(string[] args)
        {
            Retangulo R = new Retangulo();

            Console.Write("Altura = ");
            R.altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Largura = ");
            R.largura = Convert.ToDouble(Console.ReadLine());

            double area = R.GetArea();
            double perimetro = R.GetPerimetro();
            double diagonal = R.GetDiagonal();


            Console.WriteLine(
                "\nArea = {0}\n" +
                "Perímetro = {1}\n" +
                "Diagonal = {2}\n"
                , area, perimetro, diagonal);

            Console.ReadKey();
        }
    }
}
