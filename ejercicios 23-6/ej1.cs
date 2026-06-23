class Ejercicio1
{
    static void Main()
    {
        string[] peliculas = new string[5];

        for (int i = 0; i < peliculas.Length; i++)
        {
            Console.WriteLine("Pelicula " + (i + 1) + ": ");
            peliculas[i] = Console.ReadLine();
        }

        foreach (string pelicula in peliculas)
        {
            Console.WriteLine("Peliculas: " + pelicula);
        }
    }
}