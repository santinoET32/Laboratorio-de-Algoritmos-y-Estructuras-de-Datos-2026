class ejercicioA
{
    static void Main()
    {
        Random random = new Random();
        int secreto = random.Next(1, 11);
        bool key = false;

        while (key == false)
        {
            Console.WriteLine("Adivina un numero del 1 al 10: ");
            int intento = Convert.ToInt16(Console.ReadLine());

            if (intento == secreto)
            {
                Console.WriteLine("Adivinaste el numero");
                key = true;
            }
            else
            {
                if (intento < secreto)
                {
                    Console.WriteLine("El numero es mayor");
                }
                else
                {
                    Console.WriteLine("El numero es menor");
                }
            }
        }
    }
}