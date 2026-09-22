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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        clsPila objPila = new clsPila();
        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();

            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;
            objNodo.siguiente = null;

            objPila.AgregarPila(objNodo);
            objPila.Recorrer(lbListado);
            objPila.RecorrerDgv(dgvListado);

            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
            txtCodigo.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (objPila.Primero != null)
            {
                lblMuestraCodigo.Text = objPila.Primero.Codigo.ToString();
                lblMuestraNombre.Text = objPila.Primero.Nombre;
                lblMuestraTramite.Text = objPila.Primero.Tramite;

                objPila.Primero = objPila.Primero.siguiente;

                objPila.Recorrer(lbListado);
                objPila.RecorrerDgv(dgvListado);
            }
            else
            {
                MessageBox.Show("La pila está vacía");
            }

            lblMuestraCodigo.Text = "";
            lblMuestraNombre.Text = "";
            lblMuestraTramite.Text = "";
        }

        private void dgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lblMuestraCodigo.Text = dgvListado.Rows[e.RowIndex].Cells[0].Value.ToString();
                lblMuestraNombre.Text = dgvListado.Rows[e.RowIndex].Cells[1].Value.ToString();
                lblMuestraTramite.Text = dgvListado.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
    }
}
