class ejercicioB
{
    static void Main()
    {
        Console.WriteLine("Escribi un numero: ");
        int n = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Divisores: ");
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0) Console.WriteLine(i + " ");
        }
    }
}