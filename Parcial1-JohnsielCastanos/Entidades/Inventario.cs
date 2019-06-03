using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_JohnsielCastanos.Entidades
{
     public class Inventario
    {

        public int InventarioId { get; set; }
        public float Valor { get; set; }

        public Inventario()
        {
            Valor = 0;
            InventarioId = 0;
        }

    }
}
