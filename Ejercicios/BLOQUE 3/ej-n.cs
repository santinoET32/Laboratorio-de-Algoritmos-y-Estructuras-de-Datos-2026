class ejercicioN
{
    static void Main()
    {
        string frase = "";

        while (frase != "agusfortnite2008")
        {
            Console.Write("Escribi una frase: ");
            frase = Console.ReadLine().ToLower();

            if (frase == "agusfortnite2008")
            {
                break;
            }

            string vocales = "aeiou";

            for (int i = 0; i < vocales.Length; i++)
            {
                string nuevaFrase = "";
                for (int j = 0; j < frase.Length; j++)
                {
                    if (frase[j] == 'a' || frase[j] == 'e' || frase[j] == 'i' || frase[j] == 'o' || frase[j] == 'u')
                    {
                        nuevaFrase += vocales[i];
                    }
                    else
                    {
                        nuevaFrase += frase[j];
                    }
                }
                Console.WriteLine(nuevaFrase);
            }
        }
        Console.WriteLine("swag agusfortnite2008");
    }
}