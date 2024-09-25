using MiApp.Controllers;
using MiApp.Models;
using Microsoft.Maui.Controls;

namespace MiApp.Views
{
    public partial class CategoriaListPage : ContentPage
    {
        private CategoriaController _controller;

        public CategoriaListPage()
        {
            InitializeComponent();
            _controller = new CategoriaController();
            LoadCategorias();
        }

        private async void LoadCategorias()
        {
            CategoriasListView.ItemsSource = await _controller.GetAllCategorias();
        }

        private async void OnProductTapped(object sender, ItemTappedEventArgs e)
        {
            var categoria = (Categoria)e.Item;
            await Navigation.PushAsync(new CategoriaEditPage(categoria));
        }

        private async void OnAddProductClicked(object sender, EventArgs e)
        {
            // Redirige a la vista para agregar un nuevo producto
            await Navigation.PushAsync(new CategoriaEditPage());
        }
    }
}

