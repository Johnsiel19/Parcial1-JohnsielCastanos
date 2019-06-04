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
using System.Globalization;

using Parcial1_JohnsielCastanos.UI.Registros;

namespace Parcial1_JohnsielCastanos.UI
{
    public partial class rProductos : Form
    {
        public rProductos()
        {
            InitializeComponent();
            LlenarComboBox();
         
        }

        private void Limpiar()
        {
            ProductoIdnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            CostoUpDown.Value = 0;
            ExistencianumericUpDown.Value = 0;
            ValorInventariotextBox.Text = string.Empty;
        }

        public Productos LlenaClase()
        {
            Productos producto = new Productos();
            producto.ProductoId = Convert.ToInt32(ProductoIdnumericUpDown.Value);
            producto.Descripcion = DescripciontextBox.Text;
            producto.Existencia = Convert.ToSingle(ExistencianumericUpDown.Value );
            producto.Costo = Convert.ToSingle(CostoUpDown.Value);
            producto.ValorInvetario = Convert.ToSingle(ValorInventariotextBox.Text);
            return producto;
        }

        private void LlenaCampo(Productos producto)
        {
            ProductoIdnumericUpDown.Value = producto.ProductoId;
            DescripciontextBox.Text = producto.Descripcion;
            ExistencianumericUpDown.Value =Convert.ToDecimal( producto.Existencia) ;
            CostoUpDown.Value = Convert.ToDecimal(producto.Costo);
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

            if (String.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                errorProvider.SetError(DescripciontextBox, "El campo descripcion  no puede estar vacio");
                paso = false;
            }

            if (ExistencianumericUpDown.Value == 0)
            {
                errorProvider.SetError(ExistencianumericUpDown, "El campooExistencia no puede estar vacio");
                ExistencianumericUpDown.Focus();
                paso = false;

            }

            if (CostoUpDown.Value == 0)            {
                errorProvider.SetError(CostoUpDown, "El Costo no puede estar vacio");
                CostoUpDown.Focus();
                paso = false;

            }
            return paso;

        }

        private void LlenarComboBox()
        {
            var listado = new List<Ubicaciones>();
            listado = UbicacionesBLL.GetList(p => true);
            ubicacioncomboBox.DataSource = listado;
            ubicacioncomboBox.DisplayMember = "Descripcion";
            ubicacioncomboBox.ValueMember = "UbicacionId";
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
        private void ValorInventario()
        {
            ValorInventariotextBox.Text = Convert.ToString( Convert.ToDecimal(ExistencianumericUpDown.Value) * Convert.ToDecimal(CostoUpDown.Value));

        }



        private void AgregarUbicacion_Click(object sender, EventArgs e)
        {
            rUbicacion frm = new rUbicacion();
            frm.ShowDialog();
            
        }

        private void CostoUpDown_ValueChanged(object sender, EventArgs e)
        {
            ValorInventario();
        }

        private void ExistencianumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ValorInventario();
        }

    }
}
