using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDotNet.ConsoleApp
{
    internal class Pessoa
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string numeroContaCorrente { get; set; }

        #region Deposito
        public double EfetuarDeposito(double valorDeposito)
        {
            double saldo = 100.0;
            saldo += valorDeposito;
            return saldo;
        }
        #endregion
    }
}
