using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLanas.Shared.DTO
{
    public class VentaDTO
    {
        [Required]
        public int idCaja { get; set; }

        [Required]
        public decimal totalGanancia { get; set; }

      // falta conexion

        

    }
}
