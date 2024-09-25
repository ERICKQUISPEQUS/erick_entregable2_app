using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiApp.Models;

namespace MiApp.Services
{
    public class BolsaService
    {
        private Database _database;
        public BolsaService(string dbPath)
        {
            _database = new Database(dbPath);
        }
        public Task<List<Bolsa>> GetAll() => _database.GetAllBolsasAsync();
        public Task Add(Bolsa bolsa) => _database.SaveBolsaAsync(bolsa);
        public Task Update(Bolsa bolsa) => _database.SaveBolsaAsync(bolsa);
        public Task Delete(int id) => _database.DeleteBolsaAsync(id);
    }
}