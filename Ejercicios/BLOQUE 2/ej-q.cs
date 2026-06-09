class ejercicioQ
{
    static void Main()
    {
        Random random = new Random();

        int mayores = 0;

        for (int i = 0; i < 10; i++)
        {
            int numero = random.Next(1, 101);

            Console.WriteLine(numero);
            if (numero > 50)
            {
                mayores++;
            }
        }

        Console.WriteLine("Cantidad de numeros mayores a 50: " + mayores);
    }
}