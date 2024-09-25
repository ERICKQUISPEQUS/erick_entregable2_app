namespace MiApp.Views;
using MiApp.Models;
using MiApp.Controllers;
public partial class ProductoEditPage : ContentPage
    {
        private Producto _producto;

        public ProductoEditPage(Producto producto = null)
        {
            InitializeComponent();
            _producto = producto ?? new Producto();

            if (_producto.Id != 0)
            {
                NombreEntry.Text = _producto.Nombre;
                PrecioEntry.Text = _producto.Precio.ToString();
            }

            LoadCategorias(); 
        }

        private void LoadCategorias()
        {         
            var categorias = new List<Categoria>
            {
                new Categoria { Id = 1, Nombre = "Laptos" },
                new Categoria { Id = 2, Nombre = "Mauses" },
                new Categoria { Id = 3, Nombre = "Monitores" },
                new Categoria { Id = 4, Nombre = "Teclados" },
            };

            CategoriaPicker.ItemsSource = categorias;
            CategoriaPicker.ItemDisplayBinding = new Binding("Nombre");

            
            if (_producto.CategoriaId != 0)
            {
                var selectedCategoria = categorias.FirstOrDefault(c => c.Id == _producto.CategoriaId);
                CategoriaPicker.SelectedItem = selectedCategoria;
            }
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            
            _producto.Nombre = NombreEntry.Text;
            _producto.Precio = decimal.Parse(PrecioEntry.Text);
            _producto.CategoriaId = ((Categoria)CategoriaPicker.SelectedItem)?.Id ?? 0; 

            var controller = new ProductoController();
            if (_producto.Id == 0)
                await controller.AddProducto(_producto);  
            else
                await controller.UpdateProducto(_producto);  

            await Navigation.PopAsync();  
        }
    }