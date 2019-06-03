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


namespace Parcial1_JohnsielCastanos.UI
{
    public partial class rProductos : Form
    {
        public rProductos()
        {
            InitializeComponent();
         
        }

        private void Limpiar()
        {
            ProductoIdnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            CostotextBox.Text = string.Empty;
            ExistenciatextBox.Text = string.Empty;
            ValorInventariotextBox.Text = string.Empty;
        }

        public Productos LlenaClase()
        {
            Productos producto = new Productos();
            producto.ProductoId = Convert.ToInt32(ProductoIdnumericUpDown.Value);
            producto.Descripcion = DescripciontextBox.Text;
            producto.Existencia = Convert.ToSingle(ExistenciatextBox.Text);
            producto.Costo = Convert.ToSingle(CostotextBox.Text);
            producto.ValorInvetario = Convert.ToSingle(ValorInventariotextBox.Text);
            return producto;
        }

        private void LlenaCampo(Productos producto)
        {
            ProductoIdnumericUpDown.Value = producto.ProductoId;
            DescripciontextBox.Text = producto.Descripcion;
            ExistenciatextBox.Text = producto.Existencia.ToString();
            CostotextBox.Text = producto.Costo.ToString();
            ValorInventariotextBox.Text = producto.ValorInvetario.ToString();
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Productos producto = ProductosBLL.Buscar((int) ProductoIdnumericUpDown.Value);
            return (producto != null);

        }

        private bool Validar()
        {

            bool paso = true;
            errorProvider.Clear();



            if (DescripciontextBox.Text == string.Empty)
            {
                errorProvider.SetError(DescripciontextBox, "El campo Descripcion no puede estar vacio");
                DescripciontextBox.Focus();
                paso = false;
            }

            if (ExistenciatextBox.Text == string.Empty)
            {
                errorProvider.SetError(ExistenciatextBox, "El campooExistencia no puede estar vacio");
                ExistenciatextBox.Focus();
                paso = false;

            }

            if (CostotextBox.Text == string.Empty)
            {
                errorProvider.SetError(CostotextBox, "El Costo no puede estar vacio");
                CostotextBox.Focus();
                paso = false;

            }



            return paso;

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {

            int id;
            Productos producto = new Productos();

            int.TryParse(ProductoIdnumericUpDown.Text, out id);
            Limpiar();

            producto = ProductosBLL.Buscar(id);

            if (producto != null)
            {
                MessageBox.Show("Producto encontrado");
                LlenaCampo(producto);

            }
            else
            {
                MessageBox.Show("Producto no existe");
            }
            ValorInventario();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            int id;
            int.TryParse(ProductoIdnumericUpDown.Text, out id);
            Limpiar();
            if (ProductosBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado");
            }
            else
            {
                errorProvider.SetError(ProductoIdnumericUpDown, "No se puede elimina, porque no existe");
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Productos producto;
            bool paso = false;

            if (!Validar())
                return;

            producto = LlenaClase();


            if (ProductoIdnumericUpDown.Value == 0)
            {
                paso = ProductosBLL.Guardar(producto);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una persona que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = ProductosBLL.Modificar(producto);

            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();

        }

        public void soloLetras(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception )
            {

            }
        }

        public void soloNumeros(KeyPressEventArgs e)
        {
      
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
               else if(e.KeyChar == '.')
                {
                    e.Handled = false;

                }
           
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se aceptan Numeros");
                }
            }
            catch (Exception )
            {

            }
        }

        private void ValorInventario()
        {
            if (CostotextBox.Text.Length > 0 && ExistenciatextBox.Text.Length > 0)
                ValorInventariotextBox.Text = Convert.ToString(Convert.ToSingle(CostotextBox.Text) * Convert.ToSingle(ExistenciatextBox.Text));

            if (CostotextBox.Text.Length > 0 && ExistenciatextBox.Text.Length == 0)
                ValorInventariotextBox.Text = "0";

            if (CostotextBox.Text.Length == 0 && ExistenciatextBox.Text.Length > 0)
                ValorInventariotextBox.Text = "0";

            if (CostotextBox.Text.Length == 0 && ExistenciatextBox.Text.Length == 0)
                ValorInventariotextBox.Text = "0";
        }
    

  
        private void ExistenciatextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void CostotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void ExistenciatextBox_TextChanged(object sender, EventArgs e)
        {

            ValorInventario();


         
        }

        private void CostotextBox_TextChanged(object sender, EventArgs e)
        {
            ValorInventario();
        

        }
    }
}
