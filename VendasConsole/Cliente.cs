using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        public override bool Equals(object obj)
        {
            Cliente o = (Cliente) obj;
            if(o.Nome.Equals(Nome) && o.Cpf.Equals(Cpf))
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            Type objType = this.GetType();
            PropertyInfo[] propertyInfoList = objType.GetProperties();
            StringBuilder result = new StringBuilder();
            foreach (PropertyInfo propertyInfo in propertyInfoList)
                result.AppendFormat("{0}={1} ", propertyInfo.Name, propertyInfo.GetValue(this));

            return result.ToString();
        }
        #endregion


    }
}
