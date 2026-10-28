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
    public partial class frmConsultaConOperaciones : Form
    {
        public frmConsultaConOperaciones()
        {
            InitializeComponent();
        }


        clsBaseDeDatos BD = new clsBaseDeDatos();

        private void btnListar_Click(object sender, EventArgs e)
        {
            string consulta;

            if (cmbConsultasOperaciones.SelectedIndex != -1)
            {
                consulta = cmbConsultasOperaciones.SelectedItem.ToString();
                Mostrar(consulta);
            }
        }

        public void Mostrar(string Consulta)
        {
            string sql = "";
            switch (Consulta)
            {
                case "Proyeccion Simple":
                    sql = "SELECT Titulo FROM Libro";
                    break;
                case "Proyeccion  Multiatributo":
                    sql = "SELECT Titulo, Precio FROM Libro";
                    break;
                case "Juntar":
                    sql = "SELECT * FROM Libro INNER JOIN Autor ON Libro.IdAutor = Autor.IdAutor";
                    break;
                case "Seleccion Simple":
                    sql = "SELECT * FROM Libro WHERE IdAutor = 2";
                    break;
                case "Seleccion Multiatributo":
                    sql = "SELECT * FROM Libro WHERE IdPais = 3 AND IdAutor = 9";
                    break;
                case "Seleccion por Convolucion":
                    sql = "SELECT * FROM (SELECT * FROM Libro as T1 WHERE T1.IdIdioma > 5) as T2 WHERE T2.IdAutor > 10";
                    break;
                case "Union":
                    sql = "SELECT * FROM Libro WHERE IdAutor = 2 UNION SELECT * FROM Libro WHERE IdAutor = 5 UNION SELECT * FROM Libro WHERE IdAutor = 3";
                    break;
                case "Interseccion":
                    sql = "SELECT * FROM Libro WHERE IdAutor > 10 AND IdLibro IN (SELECT IdLibro FROM Libro WHERE IdIdioma > 8)";
                    break;
                case "Diferencia":
                    sql = "SELECT * FROM Libro WHERE IdIdioma NOT IN (SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 5)";
                    break;
            }

            if (sql != "")
            {
                DataSet datos = BD.Listar(sql);
                dgvMostrar.DataSource = datos.Tables[0];
            }
            lblConsultaSQL.Text = $"{Consulta}:\r\n{sql}";
        }

    }

}
}
