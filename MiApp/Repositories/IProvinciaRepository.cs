using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiApp.Models;

namespace MiApp.Repositories
{
    public interface IProvinciaRepository

    {

        Task<Provincia> GetProvinciaAsync(int id);

        Task<IEnumerable<Provincia>> GetAllProvinciasAsync();

        Task<int> AddProvinciaAsync(Provincia provincia);

        Task<int> UpdateProvinciaAsync(Provincia provincia);

        Task<int> DeleteProvinciaAsync(int id);

    }
}
