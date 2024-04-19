namespace CuentaBancariaService
{
    public class CuentaBancaria
    {
        //número de cuenta, saldo, titular de la cuenta
        public int NroCuenta { get; set; }
        public decimal Saldo { get; set; }
        public string  TitularCuenta { get; set; }

        public bool Deposito(decimal monto) {
            Saldo = Saldo + monto;
            return true;
        }

        public decimal Retiro(decimal monto)
        {
            if (Saldo < monto)
                return 0;

            Saldo = Saldo - monto;
            return Saldo;
        }

        public decimal DevolverSaldo() {
            return Saldo;
        }
    }
}