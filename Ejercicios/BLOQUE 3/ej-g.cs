class ejercicioG
{
    static void Main()
    {
        Random random = new Random();
        int secreto = random.Next(0, 32767);
        bool key = false;
        int intento = 0;

        while (key == false)
        {
            Console.WriteLine("Adivina el numero: ");
            int num = Convert.ToInt16(Console.ReadLine());

            intento++;

            if (num == secreto)
            {
                Console.WriteLine($"Adivinaste el numero, lo hiciste en {intento} intentos");
                key = true;
            }
            else
            {
                if (num < secreto)
                {
                    Console.WriteLine("mas grande");
                }
                else
                {
                    Console.WriteLine("Mas chico");
                }
            }
        }
    }
}