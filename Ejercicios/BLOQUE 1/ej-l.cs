class ejercicioL
{
    static void Main()
    {
        int total = 0;
        while (total <= 100)
        {
            Console.Write("Escribi un numero: ");
            int n = Convert.ToInt16(Console.ReadLine());
            total += n;
        }
        Console.WriteLine($"Te pasaste de 100");
    }
}
