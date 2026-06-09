class ejercicioE
{
    static void Main()
    {
        Console.WriteLine("Escribi un numero: ");
        int n = Convert.ToInt16(Console.ReadLine());

        int factorial = 1;
        int contador = 1;

        while (contador <= n)
        {
            factorial = factorial * contador;
            contador = contador + 1;
        }
        Console.WriteLine("El factorial es: " + factorial);
    }
}