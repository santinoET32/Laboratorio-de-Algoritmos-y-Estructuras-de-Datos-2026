class ejercicioD
{
    static void Main()
    {
        int saldo = 1000;
        int opcion = 0;

        while (opcion != 3)
        {
            Console.WriteLine("Saldo actual: $" + saldo);
            Console.WriteLine("1. Depositar");
            Console.WriteLine("2. Retirar");
            Console.WriteLine("3. Salir");
            Console.WriteLine("Elegi una opcion: ");
            opcion = Convert.ToInt16(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("Escribi el monto que vas a depositar: ");
                int deposito = Convert.ToInt16(Console.ReadLine());
                saldo += deposito;
                Console.WriteLine("Saldo actual: $" + saldo);
            }
            else
            {
                if (opcion == 2)
                {
                    Console.WriteLine("Escribi el monto que vas a retirar: ");
                    int retiro = Convert.ToInt16(Console.ReadLine());
                    if (retiro <= saldo)
                    {
                        saldo -= retiro;
                        Console.WriteLine("Saldo actual: $" + saldo);
                    }
                    else
                    {
                        Console.WriteLine("No tenes saldo suficiente para retirar");
                    }
                }
                else
                {
                    if (opcion == 3)
                    {
                        Console.WriteLine("Cerrando sistema...");
                    }
                    else
                    {
                        Console.WriteLine("Error ;(");
                    }
                }
            }
        }
    }
}