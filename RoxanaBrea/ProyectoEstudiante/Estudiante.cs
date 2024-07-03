
using ClaseEstudiante;

namespace ProyectoEstudiante
{
    internal class ClaseEstudiante
    {
        static void Main(string[] args)
        {
            //  8 - Crear tres instancias de la clase Estudiante(tres objetos) en el método Main.
            //  9 - Cargar las notas del primer y segundo parcial a todos los alumnos.Dos deberán estar aprobados
            //       y uno desaprobado.
            // 10 - Mostrar los datos de todos los alumnos. 

            // 8 --------------------

            Random random = new Random();

            /*  Estudiante estudiante1 = new Estudiante("Martin","Zieminsky","1001");
                Estudiante estudiante2 = new Estudiante("Marcelo", "Medina", "1002");
                Estudiante estudiante3 = new Estudiante("Fernando", "Pizzio", "1003");

                List<Estudiante> estudiantes = new List<Estudiante>() { };
                {
                   estudiantes.Add(estudiante1);
                   estudiantes.Add(estudiante2);
                   estudiantes.Add(estudiante3);
                }
              Esto es instanciar, crear objetos y agregarlos a una lista, es lo mismo q lo de abajo en donde
              directamente instancia dentro de la lista
            */

            List <Estudiante> estudiantes = new List <Estudiante>();
            {
                new Estudiante("Martin", "Zieminsky", "1001");
                new Estudiante("Marcelo", "Medina", "1002");
                new Estudiante("Fernando", "Pizzio", "1003");
            }

            // 9 -------------
            //  Esta forma es generando notas aleatorias con un random
            foreach (Estudiante nota in estudiantes)
            {
                nota.SetNotaPrimerParcial(random.Next(1,10));
                nota.SetNotaSegundoParcial(random.Next(1,10));
            }
            
            foreach (Estudiante datos in estudiantes)
            {
                Console.WriteLine( datos.Mostrar());
            }
            











        }
    }
}
