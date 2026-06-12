class ejercicioL
{
    static void Main()
    {
        Console.WriteLine("Escribi tu peso en KG: ");
        double peso = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Escribi tu altura en M: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double imc = peso/(altura*altura);
        Console.WriteLine("IMC: " + imc);

        if (imc < 18.5)
        {
            Console.WriteLine("Bajo peso");
        }
        else
        {
            if (imc < 25)
            {
                Console.WriteLine("Peso normal");
            }
            else
            {
                if (imc < 30)
                {
                    Console.WriteLine("Sobrepeso");
                }
                else
                {
                    Console.WriteLine("Obesidad");
                }
            }
        }
    }
}