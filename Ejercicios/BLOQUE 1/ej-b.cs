class ejercicioB
{
    static void Main()
    {
        Console.Write("Escriba su edad: ");
        int edad = Convert.ToInt16(Console.ReadLine());

        if (edad < 18)
        {
            Console.WriteLine("Sos menor de edad");
        }
        else
        {
            if (edad == 18)
            {
                Console.WriteLine("Tiene justo 18 años");
            }
        }
        if (edad > 18)
        {
            Console.WriteLine("Es mayor de edad");
        }
    }
}
