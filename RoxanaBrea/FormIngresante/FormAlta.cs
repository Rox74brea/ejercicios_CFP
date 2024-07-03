using LibreriaEstudiante;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormIngresante
{
    public partial class FormAlta : Form
    {
        Ingresante Ingresante;
        public Ingresante Ingresante1 { get => Ingresante; }

        public FormAlta()
        {
            InitializeComponent();
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            string nombre = txt_Nombre.Text;
            string apellido = txt_Apellido.Text;
            int edad = (int)num_Edad.Value;
            string genero = string.Empty;
            string pais = lst_Paises.Text;
            List<string> cursos = new List<string>();

            this.resultadoGenero();
            this.resultadoCursos();

            Ingresante = new Ingresante(nombre, apellido, edad, genero, pais, cursos);

            DialogResult = DialogResult.OK;



        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


        // metodos ----------------------------
        public string resultadoGenero()
        {
            string genero = string.Empty;
            foreach (RadioButton radioBut in gpb_Genero.Controls)
            {
                if (radioBut.Checked == true)
                {
                    genero = radioBut.Text;
                    break;
                }
            }
            return genero;
        }
        public List<string> resultadoCursos()
        {
            List<string> cursos = new List<string>();
            foreach (CheckBox chkBox in gpb_Cursos.Controls)
            {
                if (chkBox.Checked == true)
                {
                    cursos.Add(chkBox.Text);
                    break;
                }
            }
            return cursos;
        }
        // --------------------------------------

       
    }
}
