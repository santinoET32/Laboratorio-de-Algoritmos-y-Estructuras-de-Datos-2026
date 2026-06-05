class ejercicioF
{
    static void Main()
    {
        Console.Write("Escribi la cantidad de turnos: ");
        int cantidad = Convert.ToInt16(Console.ReadLine());

        string[] turnos = new string[cantidad];

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Escribi el nombre para el turno numero {i + 1}: ");
            turnos[i] = Console.ReadLine();
        }
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"Turno N° {i + 1}: {turnos[i]}");
        }
    }
}