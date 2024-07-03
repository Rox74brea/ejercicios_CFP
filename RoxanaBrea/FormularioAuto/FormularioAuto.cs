using LibreriaAuto;
using System.Drawing.Text;

namespace FormularioAuto
{
    public partial class FormularioAuto : Form
    {
        List<Auto> misAutos;
        public FormularioAuto()
        {
            InitializeComponent();
        }

        private void FormularioAuto_Load(object sender, EventArgs e)
        {
            this.misAutos = new List<Auto>();
            this.cmb_color.Items.AddRange(Auto.ColoresValidos().ToArray());
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            string marca = this.txt_marca.Text;
            string cantCombust = this.txt_cantCombust.Text;
            string color = this.cmb_color.Text;

            Auto miAuto = new Auto(marca, cantCombust, color);
            misAutos.Add(miAuto);

            this.Limpiar();




        }
        // método limpiar ----------
        private void Limpiar()
        {
            this.cmb_color.Text = string.Empty;
            this.txt_marca.Text = string.Empty;
            this.txt_cantCombust.Text = string.Empty;
        }
        // --------------------------
        private void lst_AutosIngresados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // método p/ mostrar los datos (botón mostrar) ------
        private void btn_mostrar_datos_Click(object sender, EventArgs e)
        {
            this.lst_AutosIngresados.Items.AddRange(misAutos.ToArray());
        }
        // --------------------------------------------------

        // método para limpiar los datos (botón limpiar) -----
        private void btn_limpiar_datos_Click(object sender, EventArgs e)
        {
            this.Vaciar_Lista();
        }
        //------------------------------------------
         
        // método para vacia la lista de datos ingresados p/ q solo muestre el dato reciente
        // q se ingresó y no me muestre todo lo anterior o sea la lista completa ----------
        private void Vaciar_Lista()
        {
            this.lst_AutosIngresados.Items.Clear();
        }
        // ---------------------------------------------------------------------------------





    }
}
