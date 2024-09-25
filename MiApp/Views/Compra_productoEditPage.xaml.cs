namespace MiApp.Views;
using MiApp.Models;
using MiApp.Controllers;
public partial class Compra_productoEditPage : ContentPage
{
    private Compra_producto _compra_producto;
    public Compra_productoEditPage(Compra_producto compra_producto = null)
    {
        InitializeComponent();
        _compra_producto = compra_producto ?? new Compra_producto(); // Si no se pasa producto, creamos uno nuevo
        if (_compra_producto.Id != 0)
        {
            NombreEntry.Text = _compra_producto.Nombre;
            CantidadEntry.Text = _compra_producto.Cantidad.ToString();
            Precio_unitarioEntry.Text = _compra_producto.precio_unitario.ToString();

        }
        LoadProductos();
    }
    private void LoadProductos()
    {
        var productos = new List<Producto>
            {
                new Producto { Id = 1, Nombre = "Laptop Asus" },
                new Producto { Id = 2, Nombre = "Mouse Viper" },
                new Producto { Id = 3, Nombre = "Monitor Asus" },
                new Producto { Id = 4, Nombre = "Teclado RedDragon" },
            };

        ProductoPicker.ItemsSource = productos;
        ProductoPicker.ItemDisplayBinding = new Binding("Nombre");


        if (_compra_producto.ProductoId != 0)
        {
            var selectedProducto = productos.FirstOrDefault(c => c.Id == _compra_producto.ProductoId);
            ProductoPicker.SelectedItem = selectedProducto;
        }
    }
    private async void OnSaveClicked(object sender, EventArgs e)
    {

        _compra_producto.Nombre = NombreEntry.Text;
        _compra_producto.ProductoId = ((Producto)ProductoPicker.SelectedItem)?.Id ?? 0;
        _compra_producto.Cantidad = decimal.Parse(CantidadEntry.Text);
        _compra_producto.precio_unitario = decimal.Parse(Precio_unitarioEntry.Text);

        var controller = new Compra_productoController();
        if (_compra_producto.Id == 0)
            await controller.AddCompra_producto(_compra_producto);
        else
            await controller.UpdateCompra_producto(_compra_producto);

        await Navigation.PopAsync();
    }
}