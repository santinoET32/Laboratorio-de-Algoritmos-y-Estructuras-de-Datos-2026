
class Ejercicio4
{
    static void Main()
    {
        Console.Write("Escribir un numero de dos cifras: ");
        int numero = Convert.ToInt16(Console.ReadLine());

        int unidades = numero % 10;
        int decenas = numero / 10;
        int permutado = unidades * 10 + decenas;

        Console.WriteLine($"Valor:{numero,2}");
        Console.WriteLine($"Valor permutado: {permutado,2}");
    }
}