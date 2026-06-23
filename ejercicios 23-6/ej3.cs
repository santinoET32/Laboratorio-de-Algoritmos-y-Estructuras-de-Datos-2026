class Ejercicio3
{
    static void Main()
    {
        string[] ciudades = { "Madrid", "Buenos Aires", "Bogota", "Lima", "Santiago" };

        Console.Write("Escribi una ciudad: ");
        string ciudad = Console.ReadLine();

        bool encontrada = false;

        for (int i = 0; i < ciudades.Length; i++)
        {
            if (ciudades[i] == ciudad)
            {
                Console.WriteLine("Encontrada en indice " + i);
                encontrada = true;
            }
        }

        if (encontrada == false)
        {
            Console.WriteLine("Ciudad no encontrada");
        }
    }
}