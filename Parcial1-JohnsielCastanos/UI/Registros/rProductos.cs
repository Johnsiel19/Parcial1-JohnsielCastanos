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
            producto.ProductosId = Convert.ToInt32(ProductoIdnumericUpDown.Value);
            producto.Descripcion = DescripciontextBox.Text;
            producto.Existencia = Convert.ToInt32(ExistenciatextBox.Text);
            producto.Costo = Convert.ToSingle(CostotextBox.Text;
            producto.ValorInvetario = Convert.ToSingle(ValorInventariotextBox.Text);
            return producto;
        }

        private void LlenaCampo(Productos producto)
        {
            ProductoIdnumericUpDown.Value = producto.ProductosId;
            DescripciontextBox.Text = producto.Descripcion;
            ExistenciatextBox.Text = producto.Existencia.ToString();
            CostotextBox.Text = producto.Costo.ToString();
            ValorInventariotextBox.Text = producto.ValorInvetario.ToString();


        }


    }
}
