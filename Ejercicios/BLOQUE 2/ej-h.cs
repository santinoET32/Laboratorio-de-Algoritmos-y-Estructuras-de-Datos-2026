class ejercicioH
{
    static void Main()
    {
        Console.WriteLine("--- CONVERTIDOR DE TEMPERATURA ---");
        Console.WriteLine("1. Convertir de Celsius a Fahrenheit");
        Console.WriteLine("2. Salir");
        int opcion = 1;

        while(opcion != 2)
        {
            Console.WriteLine("elegi una opcion: ");
            opcion = Convert.ToInt16(Console.ReadLine());

            if (opcion == 1 || opcion == 2)
            {
                if (opcion == 1)
                {
                    Console.WriteLine("Escribi la temperatura en grados Celsius: ");
                    double celsius = Convert.ToDouble(Console.ReadLine());
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine($"{celsius}°C equivalen a {fahrenheit}°F");
                }
                else 
                {
                    if (opcion == 2)
                    {
                        Console.WriteLine("Saliendo...");
                    }
                }
            }
            else
            {
                if (opcion != 2 && opcion != 1)
                {
                    Console.WriteLine("Opcion no valida");
                }
            }
        }
    }
}