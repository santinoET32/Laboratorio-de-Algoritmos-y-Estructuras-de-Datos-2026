using System;

class Ejercicio10
{
    static void Main()
    {
        int[] vector = new int[5];
        int opcion = 0;

        while (opcion != 5)
        {
            Console.WriteLine("1. Cargar vector");
            Console.WriteLine("2. Mostrar vector");
            Console.WriteLine("3. Buscar numero");
            Console.WriteLine("4. Sumar elementos");
            Console.WriteLine("5. Salir");
            Console.WriteLine("Opcion: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    for (int i = 0; i < vector.Length; i++)
                    {
                        Console.Write("Numero: ");
                        vector[i] = int.Parse(Console.ReadLine());
                    }
                    break;

                case 2:
                    foreach (int numero in vector)
                    {
                        Console.WriteLine(numero);
                    }
                    break;

                case 3:
                    Console.Write("Numero que se busca: ");
                    int buscado = int.Parse(Console.ReadLine());
                    bool encontrado = false;
                    for (int i = 0; i < vector.Length; i++)
                    {
                        if (vector[i] == buscado)
                        {
                            Console.WriteLine("Encontrado en el indice: " + i);
                            encontrado = true;
                        }
                    }
                    if (encontrado == false)
                    {
                        Console.WriteLine("No encontrado");
                    }
                    break;

                case 4:
                    int suma = 0;

                    for (int i = 0; i < vector.Length; i++)
                    {
                        suma += vector[i];
                    }

                    Console.WriteLine("Suma: " + suma);
                    break;

                case 5:
                    Console.WriteLine("Fin del programa");
                    break;
            }
        }
    }
}