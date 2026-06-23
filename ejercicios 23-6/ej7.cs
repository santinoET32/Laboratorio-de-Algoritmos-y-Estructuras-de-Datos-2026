class Ejercicio7
{
    static void Main()
    {
        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] subvector = numeros[3..8];
        foreach (int numero in subvector)
        {
            Console.WriteLine(numero);
        }
    }
}