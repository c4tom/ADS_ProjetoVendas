using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasConsole
{
    class Cliente
    {
        #region C#
        public Cliente() {
            CriadoEm = DateTime.Now;
        }

        public Cliente(string cpf)
        {
            CriadoEm = DateTime.Now;
            Cpf = cpf;
        }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime CriadoEm { get; set; }
        #endregion


    }
}
