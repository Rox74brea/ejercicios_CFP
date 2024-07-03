using LibreriaEstudiante;

namespace FormIngresante
{
    public partial class FormIngresante : Form
    {
        List<Ingresante> ingresantes;
        public FormIngresante()
        {
            InitializeComponent();
        }

        private void FormIngresante_Load(object sender, EventArgs e)
        {
            List<Ingresante> ingresantes = new List<Ingresante>();
        }




        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            FormAlta formAlta = new FormAlta();
            formAlta.ShowDialog();

        }

    }
}
