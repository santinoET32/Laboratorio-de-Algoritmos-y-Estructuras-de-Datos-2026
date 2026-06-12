class ejercicioN
{
    static void Main()
    {
        Console.Write("Escribi tu edad: ");
        int edad = Convert.ToInt16(Console.ReadLine());

        if (edad >= 18)
        {
            Console.WriteLine("Podes votar y manejar");
        }
        else
        {
            if (edad == 16 || edad == 17)
            {
                Console.WriteLine("Podes votar");
            }
            else
            {
                Console.WriteLine("No podes ni votar ni manejar");
            }
        }

    }
}