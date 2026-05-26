using System;

class Ejercicio6
{
    static void Main()
    {
        Console.Write("Escriba el lado del cuadrado: ");
        int lado = Convert.ToInt16(Console.ReadLine());

        int perimetro = 4 * lado;
        int superficie = lado * lado;

        Console.WriteLine($"Perímetro: {perimetro}");
        Console.WriteLine($"Superficie: {superficie}");
    }
}