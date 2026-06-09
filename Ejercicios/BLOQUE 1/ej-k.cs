class ejercicioK
{
    static void Main()
    {
        Console.Write("Escribi un numero: ");
        int n = Convert.ToInt16(Console.ReadLine());
        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
        }
    }
}
