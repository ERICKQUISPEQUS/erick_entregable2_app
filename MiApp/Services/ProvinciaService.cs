using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiApp.Models;
using MiApp.Repositories;

namespace MiApp.Services
{
    public class ProvinciaService : IProvinciaService
    {
        private readonly IProvinciaRepository _provinciaRepository;
        public ProvinciaService(IProvinciaRepository provinciaRepository)
        {
            _provinciaRepository = provinciaRepository;
        }
        public async Task<Provincia> GetProvinciaAsync(int id)
        {
            return await _provinciaRepository.GetProvinciaAsync(id);
        }
        public async Task<IEnumerable<Provincia>> GetAllProvinciasAsync()
        {

            return await _provinciaRepository.GetAllProvinciasAsync();

        }



        public async Task<bool> AddProvinciaAsync(Provincia provincia)

        {

            var result = await _provinciaRepository.AddProvinciaAsync(provincia);

            return result > 0;

        }



        public async Task<bool> UpdateProvinciaAsync(Provincia provincia)

        {

            var result = await _provinciaRepository.UpdateProvinciaAsync(provincia);

            return result > 0;

        }



        public async Task<bool> DeleteProvinciaAsync(int id)

        {

            var result = await _provinciaRepository.DeleteProvinciaAsync(id);

            return result > 0;

        }

    }
 }
