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
using Parcial1_JohnsielCastanos.DAL;

namespace Parcial1_JohnsielCastanos.UI.Consultas
{
    public partial class cInventario : Form
    {
        public cInventario()
        {
            InitializeComponent();


        }

        public static Inventario LlenaClase()
        {
            Inventario inventario = new Inventario();
            inventario.Valor = 0;
            inventario.InventarioId = 1;

            return inventario;
        }


        private void Actualizarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            Inventario inventario = new Inventario();
            try
            {
                inventario = InventariosBLL.Buscar(1);
                if (inventario == null)
                {

                    inventario = LlenaClase();
                    paso = InventariosBLL.Guardar(inventario);

                }

                inventario = InventariosBLL.Buscar(1);
                double total;
                total = inventario.Valor;
                valortextBox.Text = total.ToString();

            }
            catch (Exception)
            {

            }


        }

   } 
}
