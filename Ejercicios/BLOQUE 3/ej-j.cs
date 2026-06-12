class ejercicioJ
{
    static void Main()
    {
        string usuarioCorrecto = "admin";
        string contraseñaCorrecta = "12890";
        int intentos = 0;

        while (intentos < 3)
        {
            Console.WriteLine("Usuario: ");
            string usuario = Console.ReadLine();
            Console.Write("Contraseña: ");
            string contraseña = Console.ReadLine();

            if (usuario == usuarioCorrecto && contraseña == contraseñaCorrecta)
            {
                Console.WriteLine("Bienvenido");
                break;
            }
            else
            {
                intentos++;
                Console.WriteLine("Usuario o contraseña incorrecto");
            }
        }
        if (intentos == 3)
        {
            Console.WriteLine("Agotaste los intentos");
        }
    }
}