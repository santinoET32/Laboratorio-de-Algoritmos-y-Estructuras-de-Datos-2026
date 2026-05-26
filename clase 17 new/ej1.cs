namespace ej1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba un numero de dos cifras: ");
            int numero = Convert.ToInt16(Console.ReadLine());

            int decenas = numero / 10;
            int unidades = numero % 10;

            Console.WriteLine("Decenas: " + decenas);
            Console.WriteLine("Unidades: " + unidades);
        }
    }
}