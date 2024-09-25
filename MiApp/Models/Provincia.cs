using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MiApp.Models
{
    public class Provincia
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [PrimaryKey, AutoIncrement]
        public int DepartamentoId { get; set; }

        [ NotNull]
        public string NombreProvincia { get; set; }
    }
}
