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
using Parcial1_JohnsielCastanos.DAL;
using Parcial1_JohnsielCastanos.Entidades;

namespace Parcial1_JohnsielCastanos.UI.Consultas
{
    public partial class cProductos : Form
    {
        public cProductos()
        {
            InitializeComponent();
            FiltrocomboBox.Text ="Todo";
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {

            var listado = new List<Productos>();

            if (CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.Text)
                {
                    case "Todo":
                        listado = ProductosBLL.GetList(p => true);
                        break;

                    case "Id":
                        int id = Convert.ToInt32(CriteriotextBox.Text);
                        listado = ProductosBLL.GetList(p => p.ProductosId == id);
                        break;

                    case "Descripcion":
                        listado = ProductosBLL.GetList(p => p.Descripcion.Contains(CriteriotextBox.Text));
                        break;

                }

            }
            else
            {
                listado = ProductosBLL.GetList(p => true);
            }

            ConsultadataGridView.DataSource = null;
            ConsultadataGridView.DataSource = listado;

        }
    }
}
