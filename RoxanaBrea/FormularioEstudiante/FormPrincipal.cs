using ClaseEstudiante;

namespace FormularioEstudiante
{
    public partial class FormPrincipal : Form
    {
        // atributos -----------------------
        private List<Estudiante> estudiantes;


        // ---------------------------------

        // este es el constructor -----------
        public FormPrincipal()
        {
            InitializeComponent();
        }
        // -----------------------------------

        private void Form1_Load(object sender, EventArgs e)
        {
            this.estudiantes = new List<Estudiante>();
            this.estudiantes = Estudiante.ListaEstudiantes();
            this.lst_Estudiantes.DataSource = this.estudiantes;
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            this.dgv_Informacion.DataSource = this.estudiantes;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            FormAltas FormAltas = new FormAltas();
            FormAltas.ShowDialog();
        }

        private void btn_Evaluar_Click(object sender, EventArgs e)
        {

        }
    }
}
