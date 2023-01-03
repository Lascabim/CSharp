using System;

namespace POO_1
{
    class Triangulo
    {
        public double Tlado1, Tlado2, Tlado3;

        public double GArea()
        {
            double Tperimetro = (Tlado1 + Tlado2 + Tlado3) / 2;
            double Tarea = Math.Sqrt(Tperimetro * (Tperimetro - Tlado1) * (Tperimetro - Tlado2) * (Tperimetro - Tlado3));
            return Tarea;
        }
    }

    internal class Program
    {
        // PROGRAMAÇÃO ESTRUTURADA

        static public double GetArea(double lado1, double lado2, double lado3)
        {
            double perimetro = (lado1 + lado2 + lado3) / 2;
            double area = Math.Sqrt(perimetro * (perimetro - lado1) * (perimetro - lado2) * (perimetro - lado3));

            return area;
        }


        static void Main(string[] args)
        {
            // PROGRAMAÇÃO ESTRUTURADA

            double lado1,lado2, lado3;

            Console.Write("Lado 1 = ");
            lado1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lado 2 = ");
            lado2 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Lado 3 = ");
            lado3 = Convert.ToDouble(Console.ReadLine());
            
            double area = GetArea(lado1, lado2, lado3);
            Console.WriteLine("(PET) A aréa do triangulo é de " + area + " m2\n");

            // PROGRAMAÇÃO OO

            Triangulo triangulo = new Triangulo();

            Console.Write("Lado 1 = ");
            triangulo.Tlado1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lado 2 = ");
            triangulo.Tlado2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lado 3 = ");
            triangulo.Tlado3 = Convert.ToDouble(Console.ReadLine());

            double areaX = triangulo.GArea();
            Console.WriteLine("(POO) A aréa do triangulo é de " + areaX + " m2\n");

            if (area > areaX)
            {
                Console.WriteLine("A área do 1º triângulo é a maior!");
            }
            else if (area == areaX)
            {
                Console.WriteLine("A áreas dos triângulos são iguais!");
            }
            else
            {
                Console.WriteLine("A área do 2º triângulo é a maior!");
            }

            Console.ReadKey();
        }
    }
}
