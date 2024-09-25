using System.IO;
using Microsoft.Maui.Controls;
using MiApp.Models;
using MiApp.Services;
using MiApp;
using MiApp.Controllers;


namespace MiApp.Controllers
{
    public class BolsaController
    {
        private readonly BolsaService _bolsaService;

        public BolsaController()
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "productos.db3");
            _bolsaService = new BolsaService(dbPath);
        }

        public async Task<List<Bolsa>> GetAllBolsas()
        {
            return await _bolsaService.GetAll();
        }

        public async
        Task
AddBolsa(Bolsa bolsa)
        {
            await _bolsaService.Add(bolsa);
        }

        public async
        Task
UpdateBolsa(Bolsa bolsa)
        {
            await _bolsaService.Update(bolsa);
        }

        public async void DeleteBolsa(int id)
        {
            await _bolsaService.Delete(id);
        }
    }

}
