class Ejercicio9
{
    static void Main()
    {
        string[] palabras = new string[5];
        string resultado = "";

        for (int i = 0; i < palabras.Length; i++)
        {
            Console.WriteLine("Palabra: ");
            palabras[i] = Console.ReadLine();
        }

        for (int i = 0; i < palabras.Length; i++)
        {
            if (palabras[i].Length > 4)
            {
                resultado += palabras[i] + " ";
            }
        }

        Console.WriteLine(resultado);
    }
}