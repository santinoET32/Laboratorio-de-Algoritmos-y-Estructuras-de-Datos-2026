class ejercicioI
{
    static void Main()
    {
        Console.Write("Escribi un numero: ");
        int n = Convert.ToInt16(Console.ReadLine());
        if (n % 2 == 0)
        {
            Console.WriteLine("El numero es par");
        }
        else
        {
            Console.WriteLine("El numero es impar");
        }
    }
}