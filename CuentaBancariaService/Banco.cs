using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CuentaBancariaService
{
    public class Banco
    {
        public List<CuentaBancaria> Cuentas { get; set; }

        public Banco()
        {
            Cuentas = new List<CuentaBancaria>();
        }

        public bool AgregarCuenta(string nombre)
        {
            CuentaBancaria cuentaBancaria = new CuentaBancaria()
            {
                TitularCuenta = nombre
            };

            Cuentas.Add(cuentaBancaria);

            return true;
        }

        public bool Deposito(int nroCuenta, decimal monto)
        {
            CuentaBancaria cuentaBancaria = Cuentas.FirstOrDefault(x => x.NroCuenta == nroCuenta);
            
            if (cuentaBancaria== null) {
                return false;
            }

            return cuentaBancaria.Deposito(monto);

        }

        public decimal Retiro(int nroCuenta, decimal monto)
        {
            CuentaBancaria cuentaBancaria = Cuentas.FirstOrDefault(x => x.NroCuenta == nroCuenta);

            if (cuentaBancaria == null)
            {
                return 0;
            }

            return cuentaBancaria.Retiro(monto);
        }

        public decimal DevolverSaldo(int nroCuenta)
        {
            CuentaBancaria cuentaBancaria = Cuentas.FirstOrDefault(x => x.NroCuenta == nroCuenta);

            if (cuentaBancaria == null)
            {
                return 0;
            }

            return cuentaBancaria.DevolverSaldo();
        }
    }
}
