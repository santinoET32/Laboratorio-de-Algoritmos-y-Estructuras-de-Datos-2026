class ejercicioO
{
    static void Main()
    {
        Console.WriteLine("Escribi un numero: ");
        string numero = Console.ReadLine();

        Console.WriteLine("Los digitos por separado son:");

        int i = 0;
        while (i < numero.Length)
        {
            Console.WriteLine(numero[i]);
            i++;
        }
    }
}