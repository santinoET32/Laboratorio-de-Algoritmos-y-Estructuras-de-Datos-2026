class ejercicioE
{
    static void Main()
    {
        int contador = 0;
        int numero = 1;
        while (contador < 50)
        {
            if ((numero % 2 == 0 || numero % 5 == 0) && !(numero % 2 == 0 && numero % 5 == 0))
            {
                Console.WriteLine(numero);
                contador++;
            }
            numero++;
        }
    }
}
