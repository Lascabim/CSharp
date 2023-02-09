using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Tecla_2
{
    internal class Program
    {
        static void Main()
        {
            int numero = Convert.ToInt32(Console.ReadLine());
            int numDivisores = 2;
            if (numero == 0 || numero == 1)
            {
                numDivisores = 1;
            }
            else
            {
                for (int i = 2; i < numero; i++)
                {
                    int resto = (numero % i);

                    if (resto == 0)
                    {
                        numDivisores++;
                        break;
                    }
                }
            }
            if (numDivisores == 2)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }

            Console.ReadLine();
        }
    }
}
