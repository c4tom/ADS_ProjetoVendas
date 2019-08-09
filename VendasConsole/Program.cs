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
                        ListarClientes();
                        break;
                    case 3:
                        Cabecalho("Cadastro de Vendedores");
                        VendedorCadastro();
                        break;
                    case 4:
                        Cabecalho("Listar Vendedores");
                        ListarVendedor();
                        break;
                    case 5:
                        Cabecalho("Cadastro de Produtos");
                        ProdutoCadastro();
                        break;
                    case 6:
                        Cabecalho("Listar Produtos");
                        ListaProduto();
                        break;
                    case 7:
                        Cabecalho("Registrar Vendas");
                        VendaCadastro();
                        break;
                    case 8:
                        Cabecalho("Listar Vendas");
                        ListarVendas();
                        break;
                    case 9:
                        Cabecalho("Listar Vendas Por Clientes");
                        ListarVendasPorClientes();
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;

                }

                Console.ReadKey();

            } while (true);
        }

        private static void ListarVendasPorClientes()
        {

        }

        private static void ListarVendas()
        {
 
        }

        private static void VendaCadastro()
        {

        }

        private static void ListaProduto()
        {

        }

        private static void ProdutoCadastro()
        {
 
        }

        private static void ListarVendedor()
        {
 
        }

        private static void VendedorCadastro()
        {
            
        }

        private static void ListarClientes()
        {
            
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
            Console.WriteLine("3 - Cadastro de Vendedores");
            Console.WriteLine("4 - Listar Vendedores");
            Console.WriteLine("5 - Cadastro de Produtos");
            Console.WriteLine("6 - Lista de Produtos");
            Console.WriteLine("7 - Registrar Vendas");
            Console.WriteLine("8 - Listar Vendas");
            Console.WriteLine("9 - Listar Vendas Por Clientes");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Digite a opção desejada?");
            Console.WriteLine("====================================================");
        }

        static void Cabecalho(String cab)
        {
            Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine(cab.ToUpper());
            Console.WriteLine("====================================================");
        }
    }

}
