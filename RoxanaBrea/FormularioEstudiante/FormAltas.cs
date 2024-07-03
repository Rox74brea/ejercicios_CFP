using ClaseEstudiante;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioEstudiante
{
    public partial class FormAltas : Form
    {
        // atributos ----------------
        private Estudiante nuevoEstudiante;

        // --------------------------

        // constructor --------------
        public FormAltas()
        {
            InitializeComponent();
        }
        // -------------------------
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            nuevoEstudiante = new Estudiante(txt_Legajo.Text, txt_Nombre.Text, txt_Apellido.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FormAltas_Load(object sender, EventArgs e)
        {

        }

        public Estudiante AltaDeEstudiante
        {
            get
            {
                return nuevoEstudiante;
            }
        }

    }
}
