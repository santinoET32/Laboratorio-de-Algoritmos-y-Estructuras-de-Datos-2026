class ejercicioJ
{
    static void Main()
    {
        string[] nombres = new string[1000];
        int contador = 0;
        bool repetido = false;

        while (repetido == false && contador < 1000)
        {
            Console.WriteLine("Escribi un nombre: ");
            string entrada = Console.ReadLine();

            int i = 0;
            while (i < contador && repetido == false)
            {
                if (nombres[i].ToLower() == entrada.ToLower())
                {
                    repetido = true;
                }
                i++;
            }

            if (repetido == false)
            {
                nombres[contador] = entrada;
                contador++;
            }
        }

        Console.WriteLine("Nombre repetido");
        Console.WriteLine("Cantidad de nombres ingresados antes del duplicado: " + contador);
    }
}