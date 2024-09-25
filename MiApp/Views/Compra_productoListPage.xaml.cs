using Microsoft.Maui.Controls;
using MiApp.Controllers;
using MiApp.Models;

namespace MiApp.Views
{
    public partial class Compra_productoListPage : ContentPage
    {
        private Compra_productoController _controller;

        public Compra_productoListPage()
        {
            InitializeComponent();
            _controller = new Compra_productoController();
            LoadCompra_productos();
        }

        private async void LoadCompra_productos()
        {
            Compra_productosListView.ItemsSource = await _controller.GetAllCompra_productos();
        }

        private async void OnProductTapped(object sender, ItemTappedEventArgs e)
        {
            var compra_producto = (Compra_producto)e.Item;
            await Navigation.PushAsync(new Compra_productoEditPage(compra_producto));
        }

        private async void OnAddProductClicked(object sender, EventArgs e)
        {
            // Redirige a la vista para agregar un nuevo producto
            await Navigation.PushAsync(new Compra_productoEditPage());
        }
    }
}
