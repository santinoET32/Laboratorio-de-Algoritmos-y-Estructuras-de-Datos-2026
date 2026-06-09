class ejercicioD
{
    static void Main()
    {
        Console.WriteLine("--- CALCULADORA ---");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicacion");
        Console.WriteLine("4. Division");

        Console.WriteLine("Elegi una opcion: ");
        int opcion = Convert.ToInt16(Console.ReadLine());
        
        if (opcion == 4 || opcion == 3 || opcion == 2 || opcion == 1)
        {
            Console.Write("Escribi el primer numero: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Escribi el segundo numero: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            bool key = false;

            while(key == false)
            {
                switch (opcion)
                {
                    case 1:
                    {
                        resultado = numero1 + numero2;
                        Console.WriteLine("El resultado de la suma es: " + resultado);
                        key = true;
                        break;
                    }
                    case 2:
                    {
                        resultado = numero1 - numero2;
                        Console.WriteLine("El resultado de la resta es: " + resultado);
                        key = true;
                        break;
                    }
                    case 3:
                        resultado = numero1 * numero2;
                        Console.WriteLine("El resultado de la multiplicación es: " + resultado);
                        key = true;
                        break;

                    case 4:
                        if (numero2 == 0)
                        {
                            Console.WriteLine("Error: No se puede dividir por cero.");
                            key = true;
                            break;
                        }
                        else
                        {
                            resultado = numero1 / numero2;
                            Console.WriteLine("El resultado de la división es: " + resultado);
                            key = true;
                            break;
                        }
                }
            }
        }
    }
}