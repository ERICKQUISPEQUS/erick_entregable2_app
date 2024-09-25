using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiApp.Models;

namespace MiApp.Services
{
    public interface IProvinciaService

    {

        Task<Provincia> GetProvinciaAsync(int id);

        Task<IEnumerable<Provincia>> GetAllProvinciasAsync();

        Task<bool> AddProvinciaAsync(Provincia provincia);

        Task<bool> UpdateProvinciaAsync(Provincia provincia);

        Task<bool> DeleteProvinciaAsync(int id);

    }

}
