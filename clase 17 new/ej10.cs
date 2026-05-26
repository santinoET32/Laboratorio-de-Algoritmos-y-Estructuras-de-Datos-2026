
class Ejercicio10
{
    static void Main()
    {
        Console.Write("Valor ingresado: ");
        int numero = Convert.ToInt16(Console.ReadLine());

        int unidades = numero % 10;
        int decenas = (numero / 10) % 10;
        int centenas = numero / 100;

        Console.WriteLine($"Unidades: {unidades}");
        Console.WriteLine($"Decenas:  {decenas}");
        Console.WriteLine($"Centenas: {centenas}");
    }
}