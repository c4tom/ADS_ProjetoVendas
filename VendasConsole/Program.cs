using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;

            int opcao;
            do
            {
                Menu();
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        Cabecalho("Cadastro de Clientes");
                        ClienteCadastro();
                        break;
                    case 2:
                        Cabecalho("Listar Clientes");
                        break;
                    case 3:
                        Cabecalho("");
                        break;
                    case 4:
                        Cabecalho("");
                        break;
                    case 5:
                        Cabecalho("");
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;

                }

                Console.ReadKey();

            } while (true);
        }

        private static void ClienteCadastro()
        {
            Cliente c = new Cliente();
            c.Nome = "fulano";
            Console.WriteLine(c);
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine("1 - Cadastro de Clientes");
            Console.WriteLine("2 - Listar Clientes");
            Console.WriteLine("3 - ");
            Console.WriteLine("4 - ");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Digite a opção desejada?");
            Console.WriteLine("====================================================");
        }

        static void Cabecalho(String cab)
        {
            Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine(cab);
            Console.WriteLine("====================================================");
        }
    }

}
