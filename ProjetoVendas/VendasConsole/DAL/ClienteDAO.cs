﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.Models;

namespace VendasConsole.DAL
{
    class ClienteDAO
    {
        private ClienteDAO() { }

        private static List<Cliente> clientes = new List<Cliente>();
        public static bool CadastrarCliente(Cliente c)
        {
            foreach (Cliente clienteCadastrado in clientes)
            {
                if (clienteCadastrado.Cpf.Equals(c.Cpf))
                {
                    return false;
                }
            }
            clientes.Add(c);
            return true;
        }
        public static List<Cliente> ListarClientes()
        {
            return clientes;
        }
    }
}