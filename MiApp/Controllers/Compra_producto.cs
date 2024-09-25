using System.IO;
using Microsoft.Maui.Controls;
using MiApp.Models;
using MiApp.Services;
using MiApp;
using MiApp.Controllers;


namespace MiApp.Controllers
{
    public class Compra_productoController
    {
        private readonly Compra_productoService _compra_productoService;

        public Compra_productoController()
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "productos.db3");
            _compra_productoService = new Compra_productoService(dbPath);
        }

        public async Task<List<Compra_producto>> GetAllCompra_productos()
        {
            return await _compra_productoService.GetAll();
        }

        public async
        Task
AddCompra_producto(Compra_producto compra_producto)
        {
            await _compra_productoService.Add(compra_producto);
        }

        public async
        Task
UpdateCompra_producto(Compra_producto compra_producto)
        {
            await _compra_productoService.Update(compra_producto);
        }

        public async void DeleteCompra_producto(int id)
        {
            await _compra_productoService.Delete(id);
        }
    }

}
