class ejercicioE
{
    static void Main()
    {
        int max = -9999999;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Escribi un numero: ");
            int num = Convert.ToInt16(Console.ReadLine());
            if (num > maximo)
                max = num;
        }
        Console.WriteLine($"El numero mas alto fue: {max}");
    }
}