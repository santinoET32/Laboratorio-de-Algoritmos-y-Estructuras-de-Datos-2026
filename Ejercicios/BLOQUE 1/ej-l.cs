class ejercicioM
{
    static void Main()
    {
        Console.Write("Escribi una palabra: ");
        string palabra = Console.ReadLine();

        for (int i = 0; i < palabra.Length; i++)
        {
            string letra = palabra.Substring(i, 1);
            Console.WriteLine(letra);
        }
    }
}