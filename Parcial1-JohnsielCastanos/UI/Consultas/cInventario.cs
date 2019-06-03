using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial1_JohnsielCastanos.BLL;
using Parcial1_JohnsielCastanos.Entidades;

namespace Parcial1_JohnsielCastanos.UI.Consultas
{
    public partial class cInventario : Form
    {
        public cInventario()
        {
            InitializeComponent();
     
      
        }
 


        private void Actualizarbutton_Click(object sender, EventArgs e)
        {
            Inventario inventario = InventarioBLL.Buscar(1);
            double total;
            total = inventario.Valor;
            valortextBox.Text = total.ToString();

        }

      

    }
}
