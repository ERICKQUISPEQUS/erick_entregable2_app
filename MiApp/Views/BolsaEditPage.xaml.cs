namespace MiApp.Views;
using MiApp.Models;
using MiApp.Controllers;
public partial class BolsaEditPage : ContentPage
{
    private Bolsa _bolsa;
    public BolsaEditPage(Bolsa bolsa = null)
    {
        InitializeComponent();
        _bolsa = bolsa ?? new Bolsa(); // Si no se pasa producto, creamos uno nuevo
        if (_bolsa.Id != 0)
        {
            NombreEntry.Text = _bolsa.Nombre;
            CantidadEntry.Text = _bolsa.Cantidad.ToString();

        }
        LoadProductos();
    }
    private void LoadProductos()
    {
        var productos = new List<Producto>
            {
                new Producto { Id = 1, Nombre = "Laptop HP" },
                new Producto { Id = 2, Nombre = "Mouse Logitech" },
                new Producto { Id = 3, Nombre = "Monitor Asus" },
                new Producto { Id = 4, Nombre = "Teclado RedDragon" },
            };

        ProductoPicker.ItemsSource = productos;
        ProductoPicker.ItemDisplayBinding = new Binding("Nombre");


        if (_bolsa.ProductoId != 0)
        {
            var selectedProducto = productos.FirstOrDefault(c => c.Id == _bolsa.ProductoId);
            ProductoPicker.SelectedItem = selectedProducto;
        }
    }
    private async void OnSaveClicked(object sender, EventArgs e)
    {

        _bolsa.Nombre = NombreEntry.Text;
        _bolsa.ProductoId = ((Producto)ProductoPicker.SelectedItem)?.Id ?? 0;
        _bolsa.Cantidad = decimal.Parse(CantidadEntry.Text);

        var controller = new BolsaController();
        if (_bolsa.Id == 0)
            await controller.AddBolsa(_bolsa);
        else
            await controller.UpdateBolsa(_bolsa);

        await Navigation.PopAsync();
    }
}