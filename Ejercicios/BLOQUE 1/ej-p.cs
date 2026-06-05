class ejercicioP
{
    static void Main()
    {
        string clave = "";
        bool key = false;

        Console.WriteLine("Escriba una contraseña: ");
        string c1 = Console.ReadLine();

        while (key == false)
        {
            Console.Write("Repetila: ");
            string c2 = Console.ReadLine();

            if (c1 == c2)
            {
                Console.WriteLine("Acceso permitido");
                key = true;
            }
            else
            {
                Console.WriteLine("Intenta de nuevo");
                key = false;
            }
        }
    }
}