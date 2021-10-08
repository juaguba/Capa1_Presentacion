using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Winform.ModuloInscripcion
{
    public partial class RealizarInscripcion : Form
    {
        public RealizarInscripcion()
        {
            InitializeComponent();
        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("DNI no encontrado ¿Desea registrarlo?", "", MessageBoxButtons.YesNo);
            if (opcion == DialogResult.Yes)
            {
                RegistrarAlumno NuevaVentana = new RegistrarAlumno();
                NuevaVentana.Show();
            }
        }

        private void btnInfoClase_Click(object sender, EventArgs e)
        {
            InformacionClase NuevaVentana = new InformacionClase();
            NuevaVentana.Show();
        }

        private void RealizarInscripcion_Load(object sender, EventArgs e)
        {

        }
    }
}
