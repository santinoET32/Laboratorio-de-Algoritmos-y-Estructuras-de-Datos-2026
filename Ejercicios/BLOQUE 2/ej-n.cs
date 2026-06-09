class ejercicioN
{
    static void Main()
    {
        Console.WriteLine("Nombre: ");
        string nombre = Console.ReadLine();

        int edad = 0;
        bool edadValida = false;

        while (edadValida == false)
        {
            Console.WriteLine("Edad: ");
            string entradaEdad = Console.ReadLine();

            if (entradaEdad != "")
            {
                bool esNumero = true;
                int i = 0;

                while (i < entradaEdad.Length)
                {
                    if (entradaEdad[i] < '0' || entradaEdad[i] > '9')
                    {
                        esNumero = false;
                    }
                    i++;
                }

                if (esNumero == true)
                {
                    edad = Convert.ToInt16(entradaEdad);
                    edadValida = true;
                }
                else
                {
                    Console.WriteLine("Error: La edad debe contener solo números");
                }
            }
            else
            {
                Console.WriteLine("Error: No ingresaste nada");
            }
        }

        string mail = "";
        bool mailValido = false;

        while (mailValido == false)
        {
            Console.WriteLine("Mail: ");
            mail = Console.ReadLine();

            if (mail.Contains("@"))
            {
                mailValido = true;
            }
            else
            {
                Console.WriteLine("Error: El mail debe contener un @");
            }
        }

        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Mail: " + mail);
    }
}