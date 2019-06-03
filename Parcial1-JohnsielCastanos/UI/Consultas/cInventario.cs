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
        float r = 0;
        private void Calc()
        {
            int i = 1;
            r = 0;
            Productos producto = new Productos();
            while (producto != null)
            {
               
                producto = ProductosBLL.Buscar(i);


                if (producto != null)
                {
                    
                    r = r+(producto.ValorInvetario);
  
                }
                else
                {
                    break; 
                }
                i++;

            }


        }

        private void Actualizarbutton_Click(object sender, EventArgs e)
        {
            int id = 1;
            Inventario inventario = new Inventario();
            bool paso = false;
           
            inventario = InventarioBLL.Buscar(id);
            if ( inventario == null)
            {
                Calc();
                inventario = LlenaClase();
                paso = InventarioBLL.Guardar(inventario);
                MessageBox.Show("Se ha creado ub buevo inventario" );
            }
            else
            {
                Calc();
                inventario = LlenaClase();
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("no se pudo actualizar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = InventarioBLL.Modificar(inventario);

                MessageBox.Show("Se ha actualizado buevo inventario");
            }

             mostrar();

        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Inventario inventario = InventarioBLL.Buscar(1);
            return (inventario != null);

        }

        private void mostrar()
        {
             string d = "1";
            int id;
            Inventario inventario = new Inventario();

            int.TryParse(d, out id);
           

            inventario = InventarioBLL.Buscar(id);

            if (inventario != null)
            {
                MessageBox.Show("Producto encontrado");
                LlenaCampo(inventario);

            }
            else
            {
                MessageBox.Show("Producto no existe");
            }
         

        }

        private void LlenaCampo(Inventario inventario)
        {
           
            valortextBox.Text = Convert.ToString( inventario.Valor);
    
        }

        public Inventario LlenaClase()
        {
            Inventario inventario = new Inventario();
            inventario.Valor = Convert.ToSingle(r);
            inventario.InventarioId = 1;
          
            return inventario;
        }

    }
}
