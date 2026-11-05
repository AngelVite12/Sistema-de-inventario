using System;

class Program
{
    static void Main(string[] args)
    {
        Producto producto1 = new Producto(
            "PROD001",
            "Laptop Lenovo",
            12500.00m,
            10
        );

        producto1.MostrarInformacion();
    }
}