using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryED_CapelloBruno
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola Cola = new frmCola();
            Cola.ShowDialog();
        }

        private void datosDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLista Datos = new frmLista();
            Datos.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipal cerrar = new frmPrincipal();
            this.Close();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila Pila = new frmPila();
            Pila.ShowDialog();
        }

        private void lToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLista ListaSimple = new frmLista();
            ListaSimple.ShowDialog();
        }

        private void lDEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble ListaDoble = new frmListaDoble();
            ListaDoble.ShowDialog();
        }
    }
}
