class ejercicioB
{
    static void Main()
    {
        Console.WriteLine("Escribi un numero: ");
        int numero = Convert.ToInt16(Console.ReadLine());

        if (numero < 1)
        {
            Console.WriteLine("No se puede");
        }
        else
        {
            for (int i = 0; i <= numero; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}