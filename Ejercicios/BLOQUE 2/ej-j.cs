class ejercicioJ
{
    static void Main()
    {
        string[] listnombres = new string[100];
        int cantidad = 0;

        Console.Write("Escribi un nombre o fin para terminar");
        string nombres = Console.ReadLine();

        while (nombres != "fin")
        {
            listnombres[cantidad] = nombres;
            cantidad++;

            Console.Write("Escribi un nombre o fin para terminar");
            nombres = Console.ReadLine();
        }

        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine("Hola, " + listnombres[i]);
        }
    }
}
