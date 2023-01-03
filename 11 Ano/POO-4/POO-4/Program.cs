using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_4
{
    internal class Program
    {

        class Funcionario
        {
            public string nome;
            public double SalarioBruto, desconto;
        
            public double salarioLiquido()
            {
                double SalarioLiquido = (SalarioBruto - desconto); 
                return SalarioLiquido;   
            }
        }

        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Nome do funcionário: ");
            funcionario.nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            funcionario.SalarioBruto = Convert.ToDouble(Console.ReadLine());

            Console.Write("Desconto: ");
            funcionario.desconto = Convert.ToDouble(Console.ReadLine());

            double sLiquido = funcionario.salarioLiquido();

            Console.WriteLine("Salário líquido: " + sLiquido + "E");

            Console.ReadKey();
        }
    }


}
