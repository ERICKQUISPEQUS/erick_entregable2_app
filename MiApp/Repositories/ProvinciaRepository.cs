using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiApp.Models;
using SQLite;

namespace MiApp.Repositories
{
    public class ProvinciaRepository : IProvinciaRepository

    {
        private readonly SQLiteConnection _connection;



        public ProvinciaRepository(SQLiteConnection connection)

        {

            _connection = connection;

            _connection.CreateTable<Provincia>();

        }



        public Task<Provincia> GetProvinciaAsync(int id)

        {

            return Task.FromResult(_connection.Table<Provincia>().FirstOrDefault(d => d.Id == id));

        }



        public Task<IEnumerable<Provincia>> GetAllProvinciasAsync()

        {

            return Task.FromResult(_connection.Table<Provincia>().AsEnumerable());

        }



        public Task<int> AddProvinciaAsync(Provincia provincia)

        {

            return Task.FromResult(_connection.Insert(provincia));

        }



        public Task<int> UpdateProvinciaAsync(Provincia provincia)

        {

            return Task.FromResult(_connection.Update(provincia));

        }



        public Task<int> DeleteProvinciaAsync(int id)

        {

            var provincia = _connection.Table<Provincia>().FirstOrDefault(d => d.Id == id);

            if (provincia != null)

            {

                return Task.FromResult(_connection.Delete(provincia));

            }

            return Task.FromResult(0);

        }

    }
}
