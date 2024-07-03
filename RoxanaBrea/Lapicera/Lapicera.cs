using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClaseLapicera
{
    public class Lapicera
    {
        /*
         Crear la clase lapicera, esta debe tener los atributos:
               color, precio, marca, nivelDeTinta.
         crear propiedades todas las propiedad de lectura.
         Un constructor que inicialice color, precio, marca.
         Todas las lapiceras se crean con el nivel de tinta al 100.
         Sobreescribir el metodo ToString() para que muestre todos sus valores.
         Crear el metodo publicv bool Escribir(int cantLetras), donde cada letra consume un nivel de tinta, 
               el metodo debe verificar si tiene tinta
               para escribir la cantidad de letas solicitadas por parametro en informara con un true o false si le alcanzo.
         El metodo public void Recargar() que colocara el nivel a 100 nuevamente.
         Al igual que hicimos con los formularios de ingresante, crear dos forms, el principal con el datagridview y el boton agregar y
         el fomrAlta para crear lapiceras, utilizar groupbox, combobox y la mayor variedad de componentes posibles.
        */


        // atributos --------------
        private string color;
        private double precio;
        private string marca;
        private int nivelDeTinta;

        // constructor ------------------
        public Lapicera(string color, double precio, string marca, int nivelDeTinta)
        {
            this.color = color;
            this.precio = precio;
            this.marca = marca;
            this.nivelDeTinta = 100;
        }

        public Lapicera(int nivelDeTinta)
        {
            this.nivelDeTinta = nivelDeTinta;
        }

        // **** constructor con t/ los datos que ingresan x el form convertidos a string****
        public Lapicera(string color, string precio, string marca, string nivelDeTinta)
        {
            this.color = color;
            this.ConvertirStringEnPrecio(precio);
            this.marca = marca;
            this.ConvertirStringEnNivelDeTinta(nivelDeTinta);
        }


        // ---------------------------------------

        // propiedades -----------------
        public string Color { get => color; }
        public double Precio {get => precio; }
        public string Marca { get => marca; }
        public string GetMarca()
        {
            return marca;
        }
        public int NivelDeTinta { get => nivelDeTinta; }

        // metodos --------------------
        public string LapiceraToString()
        {
            return $"Color:{color}, Precio:{precio}, Marca:{marca}, Nivel de Tinta{nivelDeTinta}";
        }
        public override string ToString()
        {
            return this.LapiceraToString();  
        }

        public bool Escribir(int cantLetras)
        {
            bool puedeEscribir = false;
            int tintaRestante = nivelDeTinta - cantLetras;
            if (nivelDeTinta >= cantLetras)
            {
                nivelDeTinta -= cantLetras;
                puedeEscribir = true;
            }
         return puedeEscribir;
        }
        public void Recargar()
        {
            nivelDeTinta = 100;
        }

        public bool ConvertirStringEnPrecio(string precio)
        {
            bool retornoPrecio = false;
            if (double.TryParse(precio, out double precioConvertido))
            {
                this.precio = precioConvertido;
                retornoPrecio = true;
            }
            return retornoPrecio;
        }
        public bool ConvertirStringEnNivelDeTinta(string nivelDeTinta)
        {
            bool retornoTinta = false;
            if (int.TryParse(nivelDeTinta, out int nivelDeTintaConvertido))
            {
                this.nivelDeTinta = nivelDeTintaConvertido;
                retornoTinta = true;
            }
            return retornoTinta;
        }

       
        // ---------------------------------


        // listas ------------------
        public static List<Lapicera> ListaDeLapiceras()
        {
            return new List<Lapicera>();
        }

        public static List<string> ListadoDeMarcas()
        {
            List<string> listaDeMarcas = new List<string>()
            {
                "Bic", "Faber Castell", "Filgo", "Paper Mate", "Simball", "Micro","otras"
            };
            return listaDeMarcas;
        }







    }
}
