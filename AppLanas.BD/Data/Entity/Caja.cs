﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLanas.BD.Data.Entity
{
    public class Caja
    {
        public int Id { get; set; }

        DateTime fecha { get; set; }

        List<Venta> Ventas { get; set; }
    }
}