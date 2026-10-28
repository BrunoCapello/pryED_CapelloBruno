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
    public partial class frmOperaciones : Form
    {
        public frmOperaciones()
        {
            InitializeComponent();
        }

        clsBaseDeDatos BD = new clsBaseDeDatos();

        private void frmOperaciones_Load(object sender, EventArgs e)
        {
            AplicarEstiloGrilla();
            lblBotonSeleccionado.Visible = false;
        }

        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            DataSet datos = BD.Listar("SELECT Titulo FROM Libro");
            if (datos.Tables.Count > 0)
            {
                dgvMostrar.DataSource = datos.Tables[0];
            }
            CargarLabel("Proyeccion Simple");
        }

        private void btnProyeccionMultiatributo_Click(object sender, EventArgs e)
        {
            DataSet datos = BD.Listar("SELECT Titulo, Precio FROM Libro");
            if (datos.Tables.Count > 0)
            {
                dgvMostrar.DataSource = datos.Tables[0];
            }
            CargarLabel("Proyeccion Multiatributo");
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            DataSet datos = BD.Listar("SELECT * FROM Libro INNER JOIN Autor ON Libro.IdAutor = Autor.IdAutor");
            if (datos.Tables.Count > 0)
            {
                dgvMostrar.DataSource = datos.Tables[0];
            }
            CargarLabel("Juntar");
        }

        private void btnSelecciónSimple_Click(object sender, EventArgs e)
        {
            DataSet datos = BD.Listar("SELECT * FROM Libro WHERE IdAutor = 2");
            if (datos.Tables.Count > 0)
            {
                dgvMostrar.DataSource = datos.Tables[0];
            }
            CargarLabel("Seleccion Simple");
        }

        private void btnSelecciónMultiatributo_Click(object sender, EventArgs e)
        {
            DataSet datos = BD.Listar("SELECT * FROM Libro WHERE IdPais = 3 AND IdAutor = 9");
            if (datos.Tables.Count > 0)
            {
                dgvMostrar.DataSource = datos.Tables[0];
            }
            CargarLabel("Seleccion Multiatributo");
        }

        private void btnSeleccionConvolucion_Click(object sender, EventArgs e)
        {
            DataSet datos = BD.Listar("SELECT * FROM (SELECT * FROM Libro as T1 WHERE T1.IdIdioma > 5) as T2 WHERE T2.IdAutor > 10");
            if (datos.Tables.Count > 0)
            {
                dgvMostrar.DataSource = datos.Tables[0];
            }
            CargarLabel("Seleccion Por Convolucion");
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            DataSet datos = BD.Listar("SELECT * FROM Libro WHERE IdAutor = 2 UNION SELECT * FROM Libro WHERE IdAutor = 5 UNION SELECT * FROM Libro WHERE IdAutor = 3");
            if (datos.Tables.Count > 0)
            {
                dgvMostrar.DataSource = datos.Tables[0];
            }
            CargarLabel("Union");
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            DataSet datos = BD.Listar("SELECT * FROM Libro WHERE IdAutor > 10 AND IdLibro IN (SELECT IdLibro FROM Libro WHERE IdIdioma > 8)");
            if (datos.Tables.Count > 0)
            {
                dgvMostrar.DataSource = datos.Tables[0];
            }
            CargarLabel("Interseccion");
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            DataSet datos = BD.Listar("SELECT * FROM Libro WHERE IdIdioma NOT IN (SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 5)");
            if (datos.Tables.Count > 0)
            {
                dgvMostrar.DataSource = datos.Tables[0];
            }
            CargarLabel("Diferencia");
        }

        public void CargarLabel(string texto)
        {
            lblBotonSeleccionado.Visible = true;
            lblBotonSeleccionado.Text = texto;
        }

    }
}
