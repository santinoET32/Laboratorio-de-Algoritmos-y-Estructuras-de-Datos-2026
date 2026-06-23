class Ejercicio5
{
    static void Main()
    {
        int[] numeros = { 10, 20, 30, 40, 50, 0 };

        Console.WriteLine("Nuevo numero: ");
        int nuevo = int.Parse(Console.ReadLine());

        for (int i = numeros.Length - 1; i > 2; i--)
        {
            numeros[i] = numeros[i - 1];
        }
        numeros[2] = nuevo;

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}