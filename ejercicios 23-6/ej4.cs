class Ejercicio4
{
    static void Main()
    {
        double[] notas = new double[5];
        double suma = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write("Nota: ");
            notas[i] = double.Parse(Console.ReadLine());
            suma += notas[i];
        }

        double promedio = suma / notas.Length;

        Console.WriteLine("Promedio: " + promedio);
        if (promedio >= 6)
        {
            Console.WriteLine("Aprobado");
        }
        else
        {
            Console.WriteLine("Reprobado");
        }
    }
}