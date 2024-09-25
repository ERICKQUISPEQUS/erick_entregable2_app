using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiApp.Models;
using MiApp.Repositories;

namespace MiApp.Services
{
    public class DistritoService
    {
        private readonly IDistritoRepository _distritoRepository;
        public DistritoService(IDistritoRepository distritoRepository)
        {
            _distritoRepository = distritoRepository;
        }
        public async Task<Distrito> GetDistritoAsync(int id)
        {
            return await _distritoRepository.GetDistritoAsync(id);
        }
        public async Task<IEnumerable<Distrito>> GetAllDistritosAsync()
        {

            return await _distritoRepository.GetAllDistritosAsync();

        }



        public async Task<bool> AddDistritoAsync(Distrito distrito)

        {

            var result = await _distritoRepository.AddDistritoAsync(distrito);

            return result > 0;

        }



        public async Task<bool> UpdateDistritoAsync(Distrito distrito)

        {

            var result = await _distritoRepository.UpdateDistritoAsync(distrito);

            return result > 0;

        }



        public async Task<bool> DeleteDistritoAsync(int id)

        {

            var result = await _distritoRepository.DeleteDistritoAsync(id);

            return result > 0;

        }

    }
}
