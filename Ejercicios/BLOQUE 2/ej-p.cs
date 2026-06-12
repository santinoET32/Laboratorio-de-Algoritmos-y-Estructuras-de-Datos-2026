class ejercicioP
{
    static void Main()
    {
        Random random = new Random();
        int victoriasUsuario = 0;
        int victoriasPC = 0;

        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine("Ronda " + i + ": ");
            string usuario = Console.ReadLine();

            int pc = random.Next(1, 4);
            string jugadaPC = " ";

            if (pc == 1)
            {
                jugadaPC = "piedra";
            }
            else
            {
                if (pc == 2)
                {
                    jugadaPC = "papel";
                }
                else
                {
                    jugadaPC = "tijera";
                }
            }

            Console.WriteLine("La computadora eligio: " + jugadaPC);

            if (usuario == jugadaPC)
            {
                Console.WriteLine("Empate");
            }
            else
            {
                if ((usuario == "piedra" && jugadaPC == "tijera") ||
                     (usuario == "papel" && jugadaPC == "piedra") ||
                     (usuario == "tijera" && jugadaPC == "papel"))
                {
                    Console.WriteLine("Ganaste la ronda");
                    victoriasUsuario++;
                }
                else
                {
                    Console.WriteLine("Gano la computadora");
                    victoriasPC++;
                }
            }
        }

        if (victoriasUsuario > victoriasPC)
        {
            Console.WriteLine("Ganaste el juego");
        }
        else
        {
            if (victoriasPC > victoriasUsuario)
            {
                Console.WriteLine("La computadora te gano, sos un perro");
            }
            else
            {
                Console.WriteLine("Empate final");
            }
        }
    }
}