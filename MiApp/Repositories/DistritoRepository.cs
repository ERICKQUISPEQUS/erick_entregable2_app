using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiApp.Models;
using SQLite;

namespace MiApp.Repositories
{
    public class DistritoRepository : IDistritoRepository


    {

        private readonly SQLiteConnection _connection;



        public DistritoRepository(SQLiteConnection connection)

        {

            _connection = connection;

            _connection.CreateTable<Distrito>();

        }



        public Task<Distrito> GetDistritoAsync(int id)

        {

            return Task.FromResult(_connection.Table<Distrito>().FirstOrDefault(d => d.Id == id));

        }



        public Task<IEnumerable<Distrito>> GetAllDistritosAsync()

        {

            return Task.FromResult(_connection.Table<Distrito>().AsEnumerable());

        }



        public Task<int> AddDistritoAsync(Distrito distrito)

        {

            return Task.FromResult(_connection.Insert(distrito));

        }



        public Task<int> UpdateDistritoAsync(Distrito distrito)

        {

            return Task.FromResult(_connection.Update(distrito));

        }



        public Task<int> DeleteDistritoAsync(int id)

        {

            var distrito = _connection.Table<Distrito>().FirstOrDefault(d => d.Id == id);

            if (distrito != null)

            {

                return Task.FromResult(_connection.Delete(distrito));

            }

            return Task.FromResult(0);

        }

    }
}
