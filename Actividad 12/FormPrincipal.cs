using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Actividad_12.Services;

namespace Actividad_12
{
    public partial class FormPrincipal : Form
    {
        NumericService servicio = new NumericService();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrarAlumno_Click(object sender, EventArgs e)
        {
            FormDatos fdatos = new FormDatos();
            if (fdatos.ShowDialog() == DialogResult.OK)
            {
                int lu = Convert.ToInt32(fdatos.tbLU.Text);
                string nombre = (fdatos.tbNombre.Text);
                double nota = Convert.ToDouble(fdatos.tbNota.Text);
                servicio.RegistrarAlumno(lu, nombre, nota);
            }
        }

        private void btnBuscarYVerAlumno_Click(object sender, EventArgs e)
        {
            int lu = Convert.ToInt32(tbLU.Text);
            int idx = servicio.BuscarPorLUSecuencial(lu);
            if (idx != -1)
            {
                string alumno = servicio.VerAlumno(idx);
                FormSalidas fsalidas = new FormSalidas();
                fsalidas.lsbListado.Items.Clear();
                fsalidas.lsbListado.Items.Add(alumno);
                fsalidas.ShowDialog();
            }
        }

        private void btnMostrarListadoOrdenado_Click(object sender, EventArgs e)
        {
            servicio.OrdenarPorLUBurbuja();
            FormSalidas fsalidas = new FormSalidas();
            for (int n = 0; n < servicio.VerContador(); n++)
            {
                string alumno = servicio.VerAlumno(n);
                fsalidas.lsbListado.Items.Add(alumno);
            }
            fsalidas.ShowDialog();
        }
    }
}
