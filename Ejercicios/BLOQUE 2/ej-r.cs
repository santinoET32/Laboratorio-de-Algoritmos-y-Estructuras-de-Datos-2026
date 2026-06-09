class ejercicioR
{
    static void Main()
    {
        string[] nombres = new string[5];
        double[] notas = new double[5];
        double suma = 0;
        double mejorNota = 0;
        string mejorAlumno = " ";

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Nombre: ");
            nombres[i] = Console.ReadLine();

            Console.WriteLine("Nota: ");
            notas[i] = Convert.ToDouble(Console.ReadLine());
            suma += notas[i];

            if (i == 0 || notas[i] > mejorNota)
            {
                mejorNota = notas[i];
                mejorAlumno = nombres[i];
            }
        }

        double promedio = suma / 5;

        Console.WriteLine("Promedio: " + promedio);
        Console.WriteLine("Mejor nota: " + mejorNota);
        Console.WriteLine("Alumno con mejor nota: " + mejorAlumno);
    }
}