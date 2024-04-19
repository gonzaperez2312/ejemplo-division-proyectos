// See https://aka.ms/new-console-template for more information
using CuentaBancariaService;

Banco banco = new Banco();

Console.WriteLine("Ingrese accion a realizar " +
    "(1-Deposito, 2-Retiro, 3-Consulta Saldo, " +
    "4-Crear Cuenta, 5-Salir)");
int opcion = int.Parse(Console.ReadLine());

while (opcion != 5)
{
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese nro de cuenta: ");
            int nroCuenta = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese monto a depositar: ");
            decimal monto = decimal.Parse(Console.ReadLine());

            banco.Deposito(nroCuenta, monto);

            break;
        case 2:
            Console.WriteLine("Ingrese nro de cuenta: ");
            int nroCuenta2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese monto a retirar: ");
            decimal montoRetiro = decimal.Parse(Console.ReadLine());

            banco.Retiro(nroCuenta2, montoRetiro);

            break;
        case 3:
            Console.WriteLine("Ingrese nro de cuenta: ");
            int nroCuentaSaldo = int.Parse(Console.ReadLine());

            banco.DevolverSaldo(nroCuentaSaldo);

            break;
        case 4:
            Console.WriteLine("Ingrese nombre propietario: ");
            string nombre = Console.ReadLine();

            banco.AgregarCuenta(nombre);

            break;
    }

    Console.WriteLine("Ingrese accion a realizar " +
    "(1-Deposito, 2-Retiro, 3-Consulta Saldo, " +
    "4-Crear Cuenta, 5-Salir)");
    opcion = int.Parse(Console.ReadLine());
}
