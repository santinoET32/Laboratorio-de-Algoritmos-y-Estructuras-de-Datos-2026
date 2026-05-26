using System;

class Ejercicio9
{
    static void Main()
    {
        Console.WriteLine("Primer instante");
        Console.Write("Hora: ");
        int h1 = int.Parse(Console.ReadLine());

        Console.Write("Minutos: ");
        int m1 = int.Parse(Console.ReadLine());

        Console.Write("Segundos: ");
        int s1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Segundo instante");
        Console.Write("Hora 2: ");
        int h2 = int.Parse(Console.ReadLine());

        Console.Write("Minutos 2: ");
        int m2 = int.Parse(Console.ReadLine());

        Console.Write("Segundos 2: ");
        int s2 = int.Parse(Console.ReadLine());

        int tiempo1 = h1 * 3600 + m1 * 60 + s1;
        int tiempo2 = h2 * 3600 + m2 * 60 + s2;

        int intervalo = tiempo2 - tiempo1;

        Console.WriteLine("Segundos del intervalo: " + intervalo);
    }
}