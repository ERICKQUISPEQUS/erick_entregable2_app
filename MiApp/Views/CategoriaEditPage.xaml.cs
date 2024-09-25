using MiApp.Controllers;
using MiApp.Models;
using Microsoft.Maui.Controls;

namespace MiApp.Views
{
    public partial class CategoriaEditPage : ContentPage
    {
        private Categoria _categoria;

        public CategoriaEditPage(Categoria categoria = null)
        {
            InitializeComponent();
            _categoria = categoria ?? new Categoria(); // Si no se pasa producto, creamos uno nuevo
            if (_categoria.Id != 0)
            {
                NombreEntry.Text = _categoria.Nombre;
                DescriptionEntry.Text = _categoria.Descripcion;

            }
            LoadDepartamento_ventas();
        }

        private void LoadDepartamento_ventas()
        {
            var departamento_ventas = new List<Departamento_ventas>
            {
                new Departamento_ventas { Id = 1, Nombre = "Marketig" },
                new Departamento_ventas { Id = 2, Nombre = "Finanzas" },
                new Departamento_ventas { Id = 3, Nombre = "Finanzas" },
                new Departamento_ventas { Id = 4, Nombre = "Recursos Humanos" },
                 new Departamento_ventas { Id = 5, Nombre = "Logística" },
            };

            Departamento_ventaPicker.ItemsSource = departamento_ventas;
            Departamento_ventaPicker.ItemDisplayBinding = new Binding("Nombre");


            if (_categoria.Departamento_ventasId != 0)
            {
                var selectedCategoria = departamento_ventas.FirstOrDefault(c => c.Id == _categoria.Departamento_ventasId);
                Departamento_ventaPicker.SelectedItem = selectedCategoria;
            }
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {

            _categoria.Nombre = NombreEntry.Text;
            _categoria.Descripcion = NombreEntry.Text;
            _categoria.Departamento_ventasId = ((Departamento_ventas)Departamento_ventaPicker.SelectedItem)?.Id ?? 0;

            var controller = new CategoriaController();
            if (_categoria.Id == 0)
                await controller.AddCategoria(_categoria);
            else
                await controller.UpdateCategoria(_categoria);

            await Navigation.PopAsync();
        }
    }
}