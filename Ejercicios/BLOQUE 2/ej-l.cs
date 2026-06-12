class ejercicioL
{
    static void Main()
    {
        for (int num = 100; num <= 200; num++)
        {
            if (num % 7 == 0 && num % 10 == 3)
            {
                Console.WriteLine(num);
            }
        }
    }
}
