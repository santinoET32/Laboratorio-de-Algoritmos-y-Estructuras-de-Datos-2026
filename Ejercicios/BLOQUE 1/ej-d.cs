class ejercicioD
{
    static void Main()
    {
        string contraseña = "AJXDR";
        int intentos = 0;
        while (intentos < 5)
        {
            Console.WriteLine("Escribi la contraseña: ");
            string intento = Console.ReadLine();
            intentos++;
            if (intento == contraseña)
            {
                Console.WriteLine("Contraseña correcta");
            }
            else
            {
                Console.WriteLine($"Contraseña incorrecta te quedan {5 - intentos} intentos");
            }
        }
        if (intentos == 5)
        {
            Console.WriteLine("Agotaste los intentos");
        }
    }
}