﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLanas.BD.Data.Entity
{
    public class Producto
    {
        public int id { get; set; }

        [Required(ErrorMessage = "EL Nombre del producto debe ser OBLIGATORIO")]
        [MaxLength(40, ErrorMessage = "Solo se aceptan hasta 40 caracteres en el Nombre del Deposito")]
        public string nombreProducto { get; set; }

        [Required(ErrorMessage = "EL Precio del Producto debe ser OBLIGATORIO")]
        [MaxLength(40, ErrorMessage = "Solo se aceptan hasta 10 caracteres en el Precio del Producto")]
        public decimal precioProducto { get; set; }

        [Required(ErrorMessage = "El Precio del Producto comprado a proveedores debe ser OBLIGATORIO")]
        public decimal precioProveedor { get; set; }

        [Required(ErrorMessage = "El Porcentaje del Producto que se desea obtener debe ser OBLIGATORIO")]
        public decimal porcentajeGanancia { get; set; }

        //conexion Relacion de uno a muchos. una venta tiene muchos productos 

        public int ventaid {get; set; }

        public Venta Venta { get; set; }


    }


}
