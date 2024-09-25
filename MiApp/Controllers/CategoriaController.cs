using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiApp.Services;
using MiApp.Models;
using MiApp.Views;

namespace MiApp.Controllers
{
    public class CategoriaController
    {
        private readonly CategoriaService _categoriaService;

        public CategoriaController()
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "productos.db3");
            _categoriaService = new CategoriaService(dbPath);
        }

        public async Task<List<Categoria>> GetAllCategorias()
        {
            return await _categoriaService.GetAll();
        }

        public async 
        Task
AddCategoria(Categoria categoria)
        {
            await _categoriaService.Add(categoria);
        }

        public async 
        Task
UpdateCategoria(Categoria categoria)
        {
            await _categoriaService.Update(categoria);
        }

        public async void DeleteCategoria(int id)
        {
            await _categoriaService.Delete(id);
        }
    }

}
