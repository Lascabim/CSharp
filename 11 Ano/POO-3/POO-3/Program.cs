using System;

namespace POO_3
{
    internal class Program
    {
        class Produto
        {
            public string nome;
            public double preco;
            public int quantidade;

            public double ValorTotal()
            {
                double vtotal = quantidade * preco;
                return vtotal;
            }

            public void realizarEntrada(int Tquantidade)
            {
                if (Tquantidade > -1)
                {
                    quantidade = Tquantidade;
                }
                else
                {
                    Console.WriteLine("Tens que introduzir uma quantidade válida!");
                }
            }

            public void Lista()
            {
                Console.Clear();
                Console.WriteLine("Produto atual: " + nome);
                Console.WriteLine("Preço atual: " + preco);
                Console.WriteLine("Quantidade atual: " + quantidade);

                Console.ReadKey();
                Start();
            }

            public void Start()
            {
                int go = 0;

                while (go == 0)
                {
                    Console.Clear();
                    Console.WriteLine("-- STOCK -- ");

                    Console.Write("Nome do produto: ");
                    nome = Console.ReadLine();

                    Console.Write("Preço do produto: ");
                    preco = Double.Parse(Console.ReadLine());

                    Console.Write("Quantidade em stock: ");
                    quantidade = int.Parse(Console.ReadLine());

                    double vtotal = ValorTotal();
                    Console.WriteLine("Preço total: " + vtotal + "E");

                    Console.WriteLine("\nPretendes continuar?" +
                        "\nEscreve '1' para adicionares stock!" +
                        "\nEscreve '2' para listares o produto em stock!" +
                        "\nEscreve '3' para fechares o programa!");
                    go = int.Parse(Console.ReadLine());

                    if (go == 1)
                    {
                        while (go == 1)
                        {

                            Console.Clear();

                            Console.Write("Nome do produto a alterar: ");
                            string Tnome = Console.ReadLine();

                            if (Tnome == nome)
                            {
                                Console.WriteLine("Stock atual: " + quantidade + " unidades!");
                                Console.Write("Quantidade em stock a atualizar: ");
                                int Tquantidade = int.Parse(Console.ReadLine());

                                realizarEntrada(Tquantidade);
                                double vtotal2 = ValorTotal();

                                Console.WriteLine("O stock do produto " + nome + " foi atualizado, está agora no valor de " + vtotal2 + " euros com " + quantidade + " unidades!");
                                Console.ReadKey();
                                Lista();
                            }
                            else
                            {
                                Console.WriteLine("\nO nome do produto a alterar não coincide com o produto em stock atual!");
                                Console.ReadKey();
                                go = 0;
                            }
                        }
                    }
                    else if (go == 2)
                    {
                        Lista();
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
            }
        }

        static void Main(string[] args)
        {

            Produto produto = new Produto();

            produto.Start();

            Console.ReadKey();
        }
    }
}
