class Ejercicio6
{
    static void Main()
    {
        string[] colores = { "Rojo", "Verde", "Azul", "Amarillo", "Negro" };

        Console.WriteLine("Escriba un indice del 0 al 4: ");
        int indice = int.Parse(Console.ReadLine());
        for (int i = indice; i < colores.Length - 1; i++)
        {
            colores[i] = colores[i + 1];
        }
        colores[colores.Length - 1] = "";
        
        foreach (string color in colores)
        {
            Console.WriteLine(color);
        }
    }
}