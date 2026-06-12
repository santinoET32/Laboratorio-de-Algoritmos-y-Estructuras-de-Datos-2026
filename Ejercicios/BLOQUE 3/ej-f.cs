class ejercicioF
{
    static void Main()
    {
        string abecedario = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        Console.WriteLine("Escribi una palabra: ");
        string palabra = Console.ReadLine().ToUpper();
        for (int i = 0; i < palabra.Length; i++)
        {
            for (int j = 0; j < abecedario.Length; j++)
            {
                if (palabra[i] == abecedario[j])
                {
                    Console.WriteLine((j + 1));
                }
            }
        }
    }
}