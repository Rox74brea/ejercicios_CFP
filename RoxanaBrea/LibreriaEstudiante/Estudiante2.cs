using System.Text;

namespace LibreriaEstudiante
{
    public class Estudiante2
    {
        private string apellido;
        private string legajo;
        private string nombre;


        // -----------------------------------------

        // constructores -------------------------

        public Estudiante2(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        // Propiedades ----------------------------
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }
        public string Legajo
        {
            get
            {
                return this.legajo;
            }
            set
            {
                this.legajo = value;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
       // -----------------------------------------------
        
        public static List<Estudiante2> ListaEstudiantes2()
        {
            return new List<Estudiante2>()
             {
                new Estudiante2("Martin", "Zieminsky", "1001"),
                new Estudiante2("Marcelo", "Medina", "1002"),
                new Estudiante2("Fernando", "Pizzio", "1003")
             };
        }
        // ----------------------------------------------------------------
        // sobreescribir el metodo ToString con Override para q No aparezca en el listbox
        // el nombre del componente sino los datos q debe mostrar
        public override string ToString()
        {
            return $"{apellido}, {nombre}";
        }
























    }
}
