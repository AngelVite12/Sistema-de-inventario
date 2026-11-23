using System;

public class Producto
{
    public string Codigo { get; set; }
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public int Existencia { get; set; }

    public Producto(string codigo, string nombre, decimal precio, int existencia)
    {
        Codigo = codigo;
        Nombre = nombre;
        Precio = precio;
        Existencia = existencia;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("===== PRODUCTO DISPONIBLE =====");
        Console.WriteLine("Código: " + Codigo);
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Precio: $" + Precio);
        Console.WriteLine("Existencia: " + Existencia);
    }
}