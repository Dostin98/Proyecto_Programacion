using System;
using System.Collections.Generic;

namespace Proyecto_Integrador
{
    class Producto
    {
        public int CodigoProducto { get; set; }
        public string Nombre { get; set; }
        public double ValorNutricional { get; set; }
        public float Precio { get; set; }
        public DateTime IngresoProducto { get; set; }


        public List<Producto> Productos { get; set; } = new List<Producto>();

    }
}
