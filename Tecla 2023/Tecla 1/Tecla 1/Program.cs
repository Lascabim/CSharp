using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecla_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int horaAtual = Convert.ToInt32(Console.ReadLine());

                if (horaAtual > 4 && horaAtual < 8)
                {
                    Console.WriteLine("madrugada");
                }
                else if (horaAtual > 7 && horaAtual < 13)
                {
                    Console.WriteLine("manha");
                }
                else if (horaAtual > 12 && horaAtual < 20)
                {
                    Console.WriteLine("tarde");
                }
                else if (horaAtual > 19 && horaAtual < 25)
                {
                    Console.WriteLine("noite");
                }
                else 
                    Console.WriteLine("noite");
         
        }
    }
}
