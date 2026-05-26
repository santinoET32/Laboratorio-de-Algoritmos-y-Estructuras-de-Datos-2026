class Ejercicio2
{
    static void Main()
    {
        Console.Write("Escribir un numero de tres cifras: ");
        int numero = Convert.ToInt16(Console.ReadLine());

        int cifracentral = (numero / 10) % 10;

        Console.WriteLine($"La cifra central es: {cifracentral}");
    }
}