using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEstudiante
{
    internal class Materia
    {
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;
         
        // constructor ------------------
        public Materia(string nombre)
        {
            this.nombre = nombre;
        }
        // ----------------------------------

        // Propiedades -------------------
        public string Nombre
        {
            get
            {
                return this.nombre;
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
            }
        }
        // ---------------------------------------






    }
}
