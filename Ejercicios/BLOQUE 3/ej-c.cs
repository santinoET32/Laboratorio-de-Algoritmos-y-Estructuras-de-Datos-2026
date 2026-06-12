class ejercicioC
{
    static void Main()
    {
        Console.WriteLine("Escribi una palabra: ");
        string palabra = Console.ReadLine().ToLower();

        Console.WriteLine("escribi una letra: ");
        char letra = Console.ReadLine().ToLower()[0];

        int contador = 0;

        for (int i = 0; i < palabra.Length; i++)
        {
            if (palabra[i] == letra)
            {
                contador++;
            }
        }

        Console.WriteLine("La letra aparece " + contador + " veces");
    }
}