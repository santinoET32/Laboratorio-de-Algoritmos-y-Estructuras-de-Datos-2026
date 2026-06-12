class ejercicioH
{
    static void Main()
    {
        Console.WriteLine("Escribi una frase: ");
        string frase = Console.ReadLine();

        string palabra = "";

        for (int i = 0; i <= frase.Length; i++)
        {
            if (i == frase.Length || frase[i] == ' ')
            {
                for (int j = palabra.Length - 1; j >= 0; j--)
                {
                    Console.Write(palabra[j]);
                }

                Console.WriteLine(" ");
                palabra = "";
            }
            else
            {
                palabra += frase[i];
            }
        }
    }
}