using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_5
{
    internal class Program
    {
        public class Verificacao
        {
            public bool aproved;
            public string nome;
            public double nota1, nota2, nota3, final, left;

            public double GetAproved()
            {
                final = (nota1 * 0.3) + (nota2 * 0.35) + (nota3 * 0.35);
                return final;
            }

            public bool ItsAproved()
            {
                if (final > 11.9)
                {
                    aproved = true;
                }
                else
                {
                    aproved = false;
                }

                return aproved;
            }

            public double LeftToBe()
            {
                if (aproved == false)
                {
                    left = 12 - final;
                }

                return left;
            }
        }

        static void Main(string[] args)
        {
            int x = 0;

            while (x == 0)
            {
                Verificacao ver = new Verificacao();

                Console.Clear();

                Console.WriteLine("Verificação das aprovações dos alunos!\n");

                Console.Write("Nome: ");
                ver.nome = Console.ReadLine();

                Console.Write("Nota do 1º período: ");
                ver.nota1 = Convert.ToDouble(Console.ReadLine());

                if (ver.nota1 > -1 && ver.nota1 < 21)
                {
                    Console.Write("Nota do 2º período: ");
                    ver.nota2 = Convert.ToDouble(Console.ReadLine());

                    if (ver.nota2 > -1 && ver.nota2 < 21)
                    {
                        Console.Write("Nota do 3º período: ");
                        ver.nota3 = Convert.ToDouble(Console.ReadLine());

                        if (ver.nota3 > -1 && ver.nota3 < 21)
                        {
                            double notafinal = ver.GetAproved();
                            bool aproved = ver.ItsAproved();

                            if (!aproved)
                            {
                                double left = ver.LeftToBe();
                                Console.WriteLine("O aluno {0} foi reprovado, pois teve {1} valores quando precisava de 12, faltavam {2} apenas pontos.", ver.nome, notafinal, left);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("O aluno {0} foi aprovado, com {1} valores !", ver.nome, notafinal);
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nota inválida, pressiona ENTER e repete o formulário.");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nota inválida, pressiona ENTER e repete o formulário.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Nota inválida, pressiona ENTER e repete o formulário.");
                    Console.ReadKey();
                }

            }

            Console.ReadKey();
        }
    }
}
