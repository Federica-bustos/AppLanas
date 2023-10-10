using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLanas.BD.Data.Entity
{
    public class Venta
    {
        public int Id { get; set; }

        [Required]
        public int idCaja { get; set; }
       
        [Required]
        public decimal totalGanancia { get; set; }

        List<Producto> Productos { get; set; }
    }
}
