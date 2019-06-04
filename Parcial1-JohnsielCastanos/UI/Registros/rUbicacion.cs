using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial1_JohnsielCastanos.Entidades;
using Parcial1_JohnsielCastanos.BLL;
using Parcial1_JohnsielCastanos.DAL;

namespace Parcial1_JohnsielCastanos.UI.Registros
{
    public partial class rUbicacion : Form
    {
        public rUbicacion()
        {
            InitializeComponent();
      
        }


        private void Limpiar()
        {
            UbicacionIdnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
          
        }

        public Ubicaciones LlenaClase()
        {
            Ubicaciones ubicacion = new Ubicaciones();
            ubicacion.UbicacionId = Convert.ToInt32(UbicacionIdnumericUpDown.Value);
            ubicacion.Descripcion = DescripciontextBox.Text;

            return ubicacion;
        }

        private void LlenaCampo(Ubicaciones ubicacion)
        {
            UbicacionIdnumericUpDown.Value = ubicacion.UbicacionId;
            DescripciontextBox.Text = ubicacion.Descripcion;
         
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Productos producto = ProductosBLL.Buscar((int)UbicacionIdnumericUpDown.Value);
            return (producto != null);

        }

        private bool Validar()
        {

            bool paso = true;
            errorProvider.Clear();

            if (String.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                errorProvider.SetError(DescripciontextBox, "El campo descripcion  no puede estar vacio");
                paso = false;
            }
  
            return paso;

        }

 

        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {

            int id;

            Ubicaciones ubicacion = new Ubicaciones();

            int.TryParse(UbicacionIdnumericUpDown.Text, out id);
            Limpiar();

            ubicacion = UbicacionesBLL.Buscar(id);

            if (ubicacion != null)
            {
                MessageBox.Show("ubicacion encontrado");
                LlenaCampo(ubicacion);

            }
            else
            {
                MessageBox.Show("ubicacion no existe");
            }
        }

        private void Nuevobutton_Click_1(object sender, EventArgs e)
        {
            Limpiar();

        }

        public static bool NoDuplicado(string descripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Ubicacion.Any(p => p.Descripcion.Equals(descripcion)))
                {
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }



            return paso;
        }

        private bool ValidarCampos()
        {
            bool paso = true;
            if (DescripciontextBox.Text == string.Empty)
            {
                MessageBox.Show("La descripcion no puede estar vacia");
                DescripciontextBox.Focus();
                paso = false;
            }
            if (NoDuplicado (DescripciontextBox.Text))
            {
                MessageBox.Show("Los nombre no pueden ser iguales");
                DescripciontextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void Eliminarbutton_Click_1(object sender, EventArgs e)
        {
            errorProvider.Clear();
            int id;
            int.TryParse(UbicacionIdnumericUpDown.Text, out id);
            Limpiar();
            if (UbicacionesBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado");
            }
            else
            {
                errorProvider.SetError(UbicacionIdnumericUpDown, "No se puede elimina, porque no existe");
            }

        }

        private void Guardarbutton_Click_1(object sender, EventArgs e)
        {
            Ubicaciones ubicacion;
            bool paso = false;

            if (!Validar())
                return;
            if (!ValidarCampos())
                return;

            ubicacion = LlenaClase();


            if (UbicacionIdnumericUpDown.Value == 0)
            {
                paso = UbicacionesBLL.Guardar(ubicacion);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una ubicacion que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = UbicacionesBLL.Modificar(ubicacion);

            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();


        }
    }


}
