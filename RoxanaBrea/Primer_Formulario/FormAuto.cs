namespace Primer_Formulario
{
    public partial class FormAuto : Form
    {
        public FormAuto()
        {
            InitializeComponent();


            string nombre;
            string apellido;
            string password;

            nombre = txt_Nombre.Text;
            apellido = txt_Apellido.Text;   
            password = txt_Password.Text;

            lst_Salida.Items.Add($"El nombre ingresado es {nombre}");
            lst_Salida.Items.Add($"El apellido ingresado es {apellido}");
            lst_Salida.Items.Add($"La password ingresada es {password}");




        }

    }
}
