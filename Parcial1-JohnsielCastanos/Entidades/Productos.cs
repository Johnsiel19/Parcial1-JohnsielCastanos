using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_JohnsielCastanos.Entidades
{
    public class Productos
    {

        [Key]
        public int ProductosId { get; set; }

        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public float Costo { get; set; }
        public float ValorInvetario { get; set;}

        public Productos()
        {
            ProductosId = 0;
            Descripcion = string.Empty;
            Existencia = 0;
            Costo = 0.00F;
            ValorInvetario = 0.00F;

        }


    }
}
