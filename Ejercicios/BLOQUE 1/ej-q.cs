class ejercicioQ
{
    static void Main()
    {
        string nombre = " ";

        while (nombre.Length <= 10)
        {
            Console.WriteLine("Escribi un nombre: ");
            nombre = Console.ReadLine();
        }

        Console.WriteLine("El nombre tiene mas de 10 caracteres");
    }
}
