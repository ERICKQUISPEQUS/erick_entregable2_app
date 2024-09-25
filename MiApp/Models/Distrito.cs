using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MiApp.Models
{
    public class Distrito
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [PrimaryKey, AutoIncrement]
        public int ProvinciaId { get; set; }

        [MaxLength(100), NotNull]
        public string NombreDistrito { get; set; }
    }
}
