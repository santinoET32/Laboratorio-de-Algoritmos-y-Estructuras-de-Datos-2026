class ejercicioL
{
    static void Main()
    {
        double total = 0;
        int cantidadProductos = 0;

        while (total <= 1000)
        {
            Console.WriteLine("Escribi el precio del producto: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            total = total + precio;
            cantidadProductos = cantidadProductos + 1;
        }

        Console.WriteLine("El total superó los $1000 total actual: $" + total);
        Console.WriteLine("Cantidad de productos cargados: " + cantidadProductos);
    }
}