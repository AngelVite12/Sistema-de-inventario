using System;
using System.Collections.Generic;

public static class BuscadorProductos
{
    public static List<Producto> BuscarPorNombre(List<Producto> productos, string texto)
    {
        List<Producto> resultados = new List<Producto>();

        foreach (Producto producto in productos)
        {
            if (producto.Nombre.Contains(texto, StringComparison.OrdinalIgnoreCase))
            {
                resultados.Add(producto);
            }
        }

        return resultados;
    }
}