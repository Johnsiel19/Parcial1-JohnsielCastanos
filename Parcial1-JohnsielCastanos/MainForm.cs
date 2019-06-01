using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial1_JohnsielCastanos.UI;
using Parcial1_JohnsielCastanos.UI.Consultas;



namespace Parcial1_JohnsielCastanos
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rProductos frm = new rProductos();
            frm.Show();


        }

        private void ProdusctosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cInventario frm = new cInventario();
            frm.Show();


        }
    }
}
