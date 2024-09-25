using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiApp.Models;

namespace MiApp.Services
{
    public class Compra_productoService
    {
        private Database _database;
        public Compra_productoService(string dbPath)
        {
            _database = new Database(dbPath);
        }
        public Task<List<Compra_producto>> GetAll() => _database.GetAllCompra_productosAsync();
        public Task Add(Compra_producto compra_producto) => _database.SaveCompra_productoAsync(compra_producto);
        public Task Update(Compra_producto compra_producto) => _database.SaveCompra_productoAsync(compra_producto);
        public Task Delete(int id) => _database.DeleteCompra_productoAsync(id);
    }
}