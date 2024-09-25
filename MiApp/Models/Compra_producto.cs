using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiApp.Models
{
    public class Compra_producto
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int ProductoId { get; set; }
        public decimal Cantidad { get; set; }
        public decimal precio_unitario { get; set; }

    }
}