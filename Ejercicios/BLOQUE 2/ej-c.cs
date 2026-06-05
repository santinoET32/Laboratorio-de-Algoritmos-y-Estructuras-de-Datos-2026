class ejercicioC
{
    static void Main()
    {
        int a = 0;
        int b = 1;

        Console.WriteLine(a + " " + b);

        for (int i = 2; i < 20; i++)
        {
            int siguiente = a + b;
            Console.WriteLine(" " + siguiente);
            a = b;
            b = siguiente;
        }
    }
}