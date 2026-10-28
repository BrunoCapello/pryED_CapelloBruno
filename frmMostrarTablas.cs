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
    public partial class frmConsultasSQL : Form
    {
        public frmConsultasSQL()
        {
            InitializeComponent();
        }

        clsBaseDeDatos objDB = new clsBaseDeDatos();

        private void btnListar_Click(object sender, EventArgs e)
        {

            objDB.Listar(dgvConsultas, lbConsultas.Text);

        }

        private void frmConsultasSQL_Load(object sender, EventArgs e)
        {
            AplicarEstiloGrilla();
        }
    }
}
