using ClaseLapicera;

using System.Drawing.Text;

namespace FormularioLapicera
{
    public partial class FormularioLapicera : Form
    {

        private List<Lapicera> lapiceras;
       

        public FormularioLapicera()
        {
            InitializeComponent();
        }
        private void FormularioLapicera_Load(object sender, EventArgs e)
        {
            this.lapiceras = new List<Lapicera>();
            this.lapiceras = Lapicera.ListaDeLapiceras();
            this.dgv_InfoLapiceras.DataSource = this.lapiceras;

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            FormularioAltaDeLapiceras altaDeLapiceras = new FormularioAltaDeLapiceras();
            altaDeLapiceras.ShowDialog();
            if (altaDeLapiceras.DialogResult == DialogResult.OK && altaDeLapiceras is not null)
            {
                lapiceras.Add(altaDeLapiceras.Lapicera);
                CargarDgv();
            }
        }

        

        // Metodos -------------------------
        private void CargarDgv()
        {
            dgv_InfoLapiceras.DataSource = null;
            dgv_InfoLapiceras.DataSource = lapiceras;
        }

       
    }
}
