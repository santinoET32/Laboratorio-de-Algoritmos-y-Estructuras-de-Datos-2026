class ejercicioA
{
    static void Main()
    {
        int opcion1 = 0;
        int opcion2 = 0;
        int opcion3 = 0;
        bool key = false;

        Console.WriteLine("Opciones:");
        Console.WriteLine("A Opcion");
        Console.WriteLine("B Opcion");
        Console.WriteLine("C Opcion");
        Console.WriteLine("Escribi terminar para finalizar");

        while (key == false)
        {
            Console.WriteLine("Tu voto: ");
            string entrada = Console.ReadLine().ToLower();

            if (entrada == "terminar")
            {
                key = true;
                break;
            }
            else
            {
                if (entrada == "a")
                {
                    opcion1++;
                }
                else
                {
                    if (entrada == "b")
                    {
                        opcion2++;
                    }
                    else
                    {
                        if (entrada == "c")
                        {
                            opcion3++;
                        }
                        else
                        {
                            Console.WriteLine("Error ;(");
                        }
                    }
                }
            }
        }

        Console.WriteLine("RESULTADOS");
        Console.WriteLine("Opcion A: " + opcion1);
        Console.WriteLine("Opcion B: " + opcion2);
        Console.WriteLine("Opcion C: " + opcion3);

        if (opcion1 > opcion2 && opcion1 > opcion3)
        {
            Console.WriteLine("Gano: Opcion A");
        }
        else
        {
            if (opcion2 > opcion1 && opcion2 > opcion3)
            {
                Console.WriteLine("Gano: Opcion B");
            }
            else
            {
                if (opcion3 > opcion1 && opcion3 > opcion2)
                {
                    Console.WriteLine("Gano: Opcion C");
                }
                else
                {
                    Console.WriteLine("Hubo empate");
                }
            }
        }
    }
}