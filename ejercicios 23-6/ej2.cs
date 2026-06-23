class Ejercicio2
{
    static void Main()
    {
        int[] numeros = new int[6];
        int pares = 0;
        int impares = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("Numero: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] % 2 == 0)
                pares++;
            else
                impares++;
        }
        Console.WriteLine("Pares: " + pares);
        Console.WriteLine("Impares: " + impares);
    }
}