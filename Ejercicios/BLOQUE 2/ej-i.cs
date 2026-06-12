class ejercicioI
{
    static void Main()
    {
        Console.WriteLine("Escribi un numero: ");
        int numero = Convert.ToInt16(Console.ReadLine());

        if (numero <= 1)
        {
            Console.WriteLine("No es primo");
        }
        else
        {
            bool esPrimo = true;
            int divisor = 2;

            while (divisor * divisor <= numero)
            {
                if (numero % divisor == 0)
                {
                    esPrimo = false;
                    break;
                }
                divisor++;
            }

            if (esPrimo)
            {
                Console.WriteLine("Es primo");
            }
            else
            {
                Console.WriteLine("No es primo");
            }
        }
    }
}