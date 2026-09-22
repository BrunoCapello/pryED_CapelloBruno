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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }
        clsListaDoble ListaDoble = new clsListaDoble();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Persona = new clsNodo();
            Persona.Codigo = Convert.ToInt32(txtCodigo.Text);
            Persona.Nombre = txtNombre.Text;
            Persona.Tramite = txtTramite.Text;

            ListaDoble.Agregar(Persona);
            LosRecorrer();
            LimpiarTodo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigo;
            string selected = null;
            if (cboCodigo.SelectedItem != null)
            {
                selected = cboCodigo.SelectedItem.ToString();
            }
            else
            {
                selected = cboCodigo.Text;
            }

            if (!int.TryParse(selected, out codigo))
            {
                MessageBox.Show("Debe seleccionar un código válido para eliminar.");
                return;
            }

            try
            {
                ListaDoble.Eliminar(codigo);
                MessageBox.Show("Eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }

            LimpiarTodo();
        }

        private void LimpiarTodo()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
            cboCodigo.SelectedIndex = -1;
            LosRecorrer();
        }

        private void LosRecorrer()
        {
            ListaDoble.RecorrerLista(lbListado);
            ListaDoble.RecorrerCombo(cboCodigo);
            ListaDoble.RecorrerAscendente(dgvListado);
        }
        
    }
}
