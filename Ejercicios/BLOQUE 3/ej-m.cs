class ejercicioM
{
    static void Main()
    {
        Console.WriteLine("Escribi una palabra: ");
        string palabra = Console.ReadLine();

        for (int i = 0; i < palabra.Length; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(palabra[j]);
            }
            Console.WriteLine();
        }
    }
}