class ejercicioJ
{
    static void Main()
    {
        Console.WriteLine("Escriba una frase: ");
        string frase = Console.ReadLine();

        int vocales = 0;

        for (int i = 0; i < frase.Length; i++)
        {
            if (frase[i] == 'a' || frase[i] == 'e' || frase[i] == 'i' ||
                frase[i] == 'o' || frase[i] == 'u')
            {
                vocales++;
            }
        }

        Console.WriteLine("La cantidad de vocales es: " + vocales);
    }
}
