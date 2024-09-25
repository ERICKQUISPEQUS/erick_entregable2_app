using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiApp.Models;
using MiApp.Services;

namespace MiApp.Controllers
{
    public class ProvinciaController

    {

        private readonly IProvinciaService _provinciaService;



        public ProvinciaController(IProvinciaService provinciaService)

        {

            _provinciaService = provinciaService;

        }



        public async Task<Provincia> GetDistritoAsync(int id)

        {

            return await _provinciaService.GetProvinciaAsync(id);

        }



        public async Task<IEnumerable<Provincia>> GetAllProvinciasAsync()

        {

            return await _provinciaService.GetAllProvinciasAsync();

        }



        public async Task<bool> AddProvinciaAsync(Provincia provincia)

        {

            return await _provinciaService.AddProvinciaAsync(provincia);

        }


        public async Task<bool> UpdateProvinciaAsync(Provincia provincia)

        {

            return await _provinciaService.UpdateProvinciaAsync(provincia);

        }



        public async Task<bool> DeleteProvinciaAsync(int id)

        {

            return await _provinciaService.DeleteProvinciaAsync(id);

        }

    }
}
