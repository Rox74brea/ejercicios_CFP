using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text;

namespace ClaseEstudiante
{
    public class Estudiante
    {

        /* Crear una aplicación de consola y una biblioteca de clases que contenga la clase 
           del siguiente diagrama:    
          La clase Estudiante:
          1- Tendrá un constructor estático que inicializará el atributo estático random.
          2- Tendrá un constructor de instancia que inicializará los atributos nombre, apellido y legajo.
          3- El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo notaPrimerParcial.
          4- El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo notaSegundoParcial.
          5- El método privado CalcularPromedio retornará el promedio de las dos notas.
          6- El método CalcularNotaFinal deberá retornar la nota del final con un número aleatorio entre 6 y 10 
              incluidos siempre y cuando las notas del primer y segundo parcial sean mayores o iguales a 4, 
              caso contrario la inicializará con el valor -1.
          7- El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
               Nombre, apellido y legajo.
               Nota del primer y segundo parcial.
               Promedio.
               Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario se mostrará la 
               leyenda "Alumno desaprobado".

          8- Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.
          9- Cargar las notas del primer y segundo parcial a todos los alumnos. Dos deberán estar aprobados y uno desaprobado.
          10- Mostrar los datos de todos los alumnos.
        */

        // parametros ---------------
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        // propiedades --------------------------
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
        public int NotaPrimerParcial
        {
            get
            {
                return this.notaPrimerParcial;
            }
            set
            {
                this.notaPrimerParcial = value;
                if (value >= 0 && value <= 10)
                {
                    notaPrimerParcial = value;
                }
                else
                {
                    notaPrimerParcial = 0;
                }
            }
        }
        public int NotaSegundoParcial
        {
            get
            {
                return this.notaSegundoParcial;
            }
            set
            {
                this.notaSegundoParcial = value;
                if (value >= 0 && value <= 10)
                {
                    notaSegundoParcial = value;
                }
                else
                {
                    notaSegundoParcial = 0;
                }
            }
        }
        public double NotaFinal
        {
            get
            {
                return this.CalcularNotaFinal();
            }
        }
        public double Promedio
        {
            get
            {
                return this.CalcularPromedio();
            }
        }

        // -----------------------------------------

        // constructores --------------
        // 1
        static Estudiante()
        {
            Estudiante.random = new Random();
        }

        // 2
        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        //  3 metodos Set ---------------------------------------
        public void SetNotaPrimerParcial(int notaPrimerParcial)
        {
            this.notaPrimerParcial = notaPrimerParcial;
        }

        // 4 
        public void SetNotaSegundoParcial(int notaSegundoParcial)
        {
            this.notaSegundoParcial = notaSegundoParcial;
        }
        


        // 5 metodo CalcularPromedio ----------------------------
        private double CalcularPromedio()
        {
            double promedio = ((double)notaPrimerParcial + notaSegundoParcial) / 2;
            return promedio;
        }

        // 6 metodo CalcularNotaFinal ---------------------------
        public int CalcularNotaFinal()
        {
            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                Random random = new Random();  // Si las notas de los parciales son mayores o iguales a 4, se 
                return random.Next(6, 10);    // genera un número aleatorio entre 6 y 10 y se devuelve como nota final.
            }
            else
            {
                return -1;  // Si las notas de los parciales son menores a 4, se devuelve -1.
            }
        }
        // 7 metodo mostrar  ------------------------------------
        // CON ToString ------------
        //   public string AlumnoToString()
        //    {
        //     return $"El nombre del alumno es: {nombre}, el apellido del alumno es: {apellido} y el legajo es: {legajo}";
        //    }
        // CON StringBuilder -------

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre y Apellido: {this.nombre} {this.apellido}");
            sb.AppendLine($"Legajo: {this.legajo}");
            sb.AppendLine($"Nota Primer Parcial: {this.notaPrimerParcial}");
            sb.AppendLine($"Nota Segundo Parcial: {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio: {this.CalcularPromedio()}");

            double notaFinal = CalcularNotaFinal();
            if (notaFinal != -1)
            {
                sb.AppendLine($"Nota Final: {notaFinal}");
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }
            return sb.ToString();
        }

        // acá creo un método con la lista de estudiantes como había hecho en el main
        // para poder ver los datos en el form, en el main los veo x consola
        public static List<Estudiante> ListaEstudiantes()
        {
            return new List<Estudiante>()
             {
                new Estudiante("Martin", "Zieminsky", "1001"),
                new Estudiante("Marcelo", "Medina", "1002"),
                new Estudiante("Fernando", "Pizzio", "1003")
             };
        }
        // ----------------------------------------------------------------
        // sobreescribir el metodo ToString con Override para q no aparezca en el listbox
        // el nombre del componente sino los datos q debe mostrar
        public override string ToString()
        {
            return $"{apellido}, {nombre}";
        }









    }
}
