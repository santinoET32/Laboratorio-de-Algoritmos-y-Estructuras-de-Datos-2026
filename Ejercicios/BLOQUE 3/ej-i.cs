class ejercicioI
{
    static void Main()
    {
        Console.WriteLine("Escribi una palabra: ");
        string palabra = Console.ReadLine().ToLower();

        for (int i = 0; i < palabra.Length; i++)
        {
            int cont = 0;
            bool repetida = false;

            for (int j = 0; j < i; j++)
            {
                if (palabra[i] == palabra[j])
                {
                    repetida = true;
                }
            }
            if (repetida == false)
            {
                for (int k = 0; k < palabra.Length; k++)
                {
                    if (palabra[i] == palabra[k])
                    {
                        cont++;
                    }
                }
                Console.WriteLine(palabra[i] + ": " + cont);
            }
        }
    }
}