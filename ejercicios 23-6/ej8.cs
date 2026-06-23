class Ejercicio8
{
    static void Main()
    {
        int[] numeros = new int[8];

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("Numero: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }
        int mayor = numeros[0];
        int posicion = 0;

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > mayor)
            {
                mayor = numeros[i];
                posicion = i;
            }
        }

        Console.WriteLine("Mayor: " + mayor);
        Console.WriteLine("Posicion: " + posicion);
    }
}