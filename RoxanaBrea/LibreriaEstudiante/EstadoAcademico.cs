using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEstudiante
{
    internal class EstadoAcademico
    {
        private Estudiante2 estudiante;
        private string carrera;
        private List<Materia> materias;

        // Constructores ( SOBRECARGA :this() )---------------------
        private EstadoAcademico() 
        { 
            materias = new List<Materia>();
        }

        public EstadoAcademico(Estudiante2 estudiante, string carrera):this()
        {
            this.estudiante = estudiante;
            this.carrera = carrera;
        }

        public EstadoAcademico(Estudiante2 estudiante, string carrera, List<Materia> materias)
            :this(estudiante, carrera)
        {
            this.materias = materias;
        }
        // ------------------------------------

        // Propiedades -----------------------
        public Estudiante2 Estudiante2
        {
            get
            {
                return this.estudiante;
            }
        }
        public string Carrera
        {
            get
            {
                return this.carrera;
            }
            set
            {
                this.carrera = value;
            }
        }
        public Materia SetMateria
        {
            set
            {
               this.materias.Add(value);
            }
        }
        public List<Materia> Materias
        {
            get
            {
                return this.materias;
            }
        }
        // ----------------------------------------

















    }
}
