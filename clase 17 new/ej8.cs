
class Ejercicio8
{
    static void Main()
    {
        Console.Write("Escriba la temperatura en Fahrenheit: ");
        float fahrenheit = float.Parse(Console.ReadLine());

        float centigrados = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine("Temperatura en centigrados: " + centigrados);
    }
}