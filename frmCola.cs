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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        clsCola objCola = new clsCola();
        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();

            objNodo.Nombre = txtNombre.Text;
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Tramite = txtTramite.Text;
            objNodo.siguiente = null;

            objCola.Agregar(objNodo);
            objCola.Recorrer(lbListado);
            objCola.RecorrerDGV(dgvListado);

            //el método .Clear() no ocupa lugar en la memoria, en cambio el "" si. Conviene el .Clear()
            txtCodigo.Clear();
            txtTramite.Clear();
            txtNombre.Clear();
            txtCodigo.Focus();  
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (objCola.Primero != null)
            {
                objCola.Eliminar();

                objCola.Recorrer(lbListado);
                objCola.RecorrerDGV(dgvListado);
            }
            else
            {
                MessageBox.Show("La cola está vacía");
            }

            lblMuestraNombre.Text = "";
            lblMuestraCodigo.Text = "";
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
