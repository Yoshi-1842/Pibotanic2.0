﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pibotanic.Models
{
    public class Producto
    {
        public int ProductoID { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public ICollection<Compra> Compras { get; set; }
    }
}
