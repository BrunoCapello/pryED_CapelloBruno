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
    public partial class frmLista : Form
    {
        public frmLista()
        {
            InitializeComponent();
        }

        clsListaSimple ListaSimple = new clsListaSimple();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Persona = new clsNodo();
            Persona.Codigo = Convert.ToInt32(txtCodigo.Text);
            Persona.Nombre = txtNombre.Text;
            Persona.Tramite = txtTramite.Text;

            ListaSimple.Agregar(Persona);

            LimpiarTodo();
        }

        public void LimpiarTodo()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
            cboCodigo.SelectedIndex = -1;

            LosRecorrer();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cboCodigo.SelectedItem != null)
            {
                try
                {
                    ListaSimple.Eliminar(Convert.ToInt32(cboCodigo.SelectedItem));
                    MessageBox.Show("Eliminado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún valor a eliminar");
            }
            LimpiarTodo();
        }

        private void LosRecorrer()
        {
            ListaSimple.RecorrerLista(lbListado);
            ListaSimple.RecorrerCombo(cboCodigo);
            ListaSimple.RecorrerDGV(dgvListado);
        }

        
    }
}
