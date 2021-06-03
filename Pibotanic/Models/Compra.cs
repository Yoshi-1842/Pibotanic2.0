using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pibotanic.Models
{
    public class Compra
    {
        public int CompraID { get; set; }
        public int Cantidad { get; set; }
        public int ProductoID { get; set; }
        public Producto Producto { get; set; }
    }
}
