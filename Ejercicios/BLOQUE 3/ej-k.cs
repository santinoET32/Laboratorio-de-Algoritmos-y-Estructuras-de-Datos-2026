class ejercicioK
{
    static void Main()
    {
        Console.WriteLine("Escribi un numero: ");
        int numero = Convert.ToInt16(Console.ReadLine());

        if (numero >= 0 && numero <= 25)
        {
            Console.WriteLine("Rango 0 a 25");
        }
        else
        {
            if (numero >= 26 && numero <= 50)
            {
                Console.WriteLine("Rango 26 a 50");
            }
            else
            {
                if (numero >= 51 && numero <= 75)
                {
                    Console.WriteLine("Rango 51 a 75");
                }
                else
                {
                    if (numero >= 76 && numero <= 100)
                    {
                        Console.WriteLine("Rango 76 a 100");
                    }
                    else
                    {
                        Console.WriteLine("Fuera del rango 0 a 100");
                    }
                }
            }
        }
    }
}