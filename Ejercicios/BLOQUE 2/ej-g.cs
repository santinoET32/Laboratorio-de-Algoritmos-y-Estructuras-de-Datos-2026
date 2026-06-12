class ejercicioG
{
    static void Main()
    {
        int cont = 0;

        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                cont++;
            }
        }
        Console.WriteLine("La cantidad de numeros pares entre 1 y 100 es: " + cont);
    }
}