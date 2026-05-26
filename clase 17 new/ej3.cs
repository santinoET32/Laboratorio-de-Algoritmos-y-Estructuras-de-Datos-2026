
class Ejercicio3
{
    static void Main()
    {
       Console.Write("Indicar precio de lista: ");
        double precioLista = double.Parse(Console.ReadLine());

        double descuento = precioLista * 0.18;
        double precioFinal = precioLista - descuento;

        Console.WriteLine("Precio de lista: $" + precioLista);
        Console.WriteLine("Descuento: 18% sobre el precio de lista.");
        Console.WriteLine("Precio con descuento: $" + precioFinal);
    }
}