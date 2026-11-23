namespace Sistema_de_inventario.Tests;

public class ProductoTests
{
    // Ejecuta MostrarInformacion() y devuelve lo que imprimió en pantalla.
    private static string CapturarSalida(Producto producto)
    {
        var salidaOriginal = Console.Out;
        try
        {
            using var escritor = new StringWriter();
            Console.SetOut(escritor);
            producto.MostrarInformacion();
            return escritor.ToString();
        }
        finally
        {
            Console.SetOut(salidaOriginal);
        }
    }

    [Fact]
    public void CP01_CrearProducto_ConDatosProporcionados()
    {
        var producto = new Producto("P001", "Teclado", 350m, 10);

        Assert.NotNull(producto);
        Assert.Equal("P001", producto.Codigo);
        Assert.Equal("Teclado", producto.Nombre);
        Assert.Equal(350m, producto.Precio);
        Assert.Equal(10, producto.Existencia);
    }

    [Fact]
    public void CP02_MostrarCodigo()
    {
        var producto = new Producto("P001", "Teclado", 350m, 10);

        Assert.Equal("P001", producto.Codigo);
        Assert.Contains("P001", CapturarSalida(producto));
    }

    [Fact]
    public void CP03_MostrarNombre()
    {
        var producto = new Producto("P001", "Teclado", 350m, 10);

        Assert.Equal("Teclado", producto.Nombre);
        Assert.Contains("Teclado", CapturarSalida(producto));
    }

    [Fact]
    public void CP04_MostrarPrecio()
    {
        var producto = new Producto("P001", "Teclado", 350m, 10);

        Assert.Equal(350m, producto.Precio);
        Assert.Contains("350", CapturarSalida(producto));
    }

    [Fact]
    public void CP05_MostrarExistencia()
    {
        var producto = new Producto("P001", "Teclado", 350m, 10);

        Assert.Equal(10, producto.Existencia);
        Assert.Contains("10", CapturarSalida(producto));
    }

    [Fact]
    public void CP06_MostrarInformacionCompleta()
    {
        var producto = new Producto("P001", "Teclado", 350m, 10);

        string salida = CapturarSalida(producto);

        Assert.Contains("P001", salida);
        Assert.Contains("Teclado", salida);
        Assert.Contains("350", salida);
        Assert.Contains("10", salida);
    }

    [Fact]
    public void CP07_CrearOtroProducto_SinConfundirDatos()
    {
        var primero = new Producto("P001", "Teclado", 350m, 10);
        var segundo = new Producto("P002", "Mouse", 180m, 5);

        Assert.Equal("P002", segundo.Codigo);
        Assert.Equal("Mouse", segundo.Nombre);
        Assert.Equal(180m, segundo.Precio);
        Assert.Equal(5, segundo.Existencia);

        // El primer producto no debe haber cambiado.
        Assert.Equal("P001", primero.Codigo);
        Assert.Equal("Teclado", primero.Nombre);
        Assert.Equal(350m, primero.Precio);
        Assert.Equal(10, primero.Existencia);
    }
}