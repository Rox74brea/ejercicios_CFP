using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEstudiante
{
    public class Ingresante
    {
        // atributos --------------------------
        string nombre;
        string apellido;
        int edad;
        string genero;
        string pais;
        List<string> cursos;
         
        // constructor -----------------------
        public Ingresante(string nombre, string apellido, int edad, string genero, 
            string pais, List<string> cursos)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.genero = genero;
            this.pais = pais;
            this.cursos = cursos;
        }
        // propiedades ------------------------
        public string Nombre { get => nombre;}
        public string Apellido { get => apellido;}
        public int Edad { get => edad;}
        public string Genero { get => genero;}
        public string Pais { get => pais;}
        public List<string> Cursos { get => cursos;}
        // -----------------------------------------

        










    }
}
