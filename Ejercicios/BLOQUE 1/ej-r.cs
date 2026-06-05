class ejercicioR
{
    static void Main()
    {
        Console.Write("Escribi una oracion: ");
        string oracion = Console.ReadLine().ToLower();

        int cont = 0;

        for (int i = 0; i < oracion.Length; i++)
        {
            if (oracion[i] == 'a')
            {
                cont++;
            }
        }
        Console.WriteLine($"La oracion tiene {cont} letras A");
    }
}