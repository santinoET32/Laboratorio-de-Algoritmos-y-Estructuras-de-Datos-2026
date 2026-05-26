
class Ejercicio7
{
    static void Main()
    {
        Console.Write("Escribir el valor de una hora de trabajo: ");
        float valorHora = float.Parse(Console.ReadLine());

        Console.Write("Escribit la cantidad de horas trabajadas: ");
        float horasTrabajadas = float.Parse(Console.ReadLine());

        float sueldoBruto = valorHora * horasTrabajadas;

        Console.WriteLine($"Sueldo bruto: ${sueldoBruto:F2}");
    }
}