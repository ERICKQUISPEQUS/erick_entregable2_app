using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiApp.Models;

namespace MiApp.Repositories
{
    public interface IDistritoRepository

    {

        Task<Distrito> GetDistritoAsync(int id);

        Task<IEnumerable<Distrito>> GetAllDistritosAsync();

        Task<int> AddDistritoAsync(Distrito distrito);

        Task<int> UpdateDistritoAsync(Distrito distrito);

        Task<int> DeleteDistritoAsync(int id);

    }
}
