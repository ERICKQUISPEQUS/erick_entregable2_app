using Microsoft.Maui.Controls;
using MiApp.Controllers;
using MiApp.Models;

namespace MiApp.Views
{
    public partial class BolsaListPage : ContentPage
    {
        private BolsaController _controller;

        public BolsaListPage()
        {
            InitializeComponent();
            _controller = new BolsaController();
            LoadBolsas();
        }

        private async void LoadBolsas()
        {
            BolsasListView.ItemsSource = await _controller.GetAllBolsas();
        }

        private async void OnProductTapped(object sender, ItemTappedEventArgs e)
        {
            var bolsa = (Bolsa)e.Item;
            await Navigation.PushAsync(new BolsaEditPage(bolsa));
        }

        private async void OnAddProductClicked(object sender, EventArgs e)
        {
            // Redirige a la vista para agregar un nuevo producto
            await Navigation.PushAsync(new BolsaEditPage());
        }
    }
}
