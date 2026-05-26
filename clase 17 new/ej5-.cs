class Ejercicio5
{
    static void Main()
    {
        Console.Write("Escribir una fecha como un entero de 6 dígitos: (DDMMAA)");
        int fecha = int.Parse(Console.ReadLine());
        int mes = (fecha / 100) % 100;
        Console.WriteLine($"Fecha: {fecha}");
        Console.WriteLine($"Mes: {mes}");
    }
}