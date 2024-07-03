using System.Collections.Generic;
using System.Drawing;

namespace LibreriaAuto
{
    public class Auto
    {
        /*    
        Crear la clase y objeto Auto
        A. Los atributos marca, cantCombustible, color.
        B. un constructor que inicialice todos los atributos.
        C. Solo metodos Get() para todos sus atributos.
        D. El metodo AutoToString(), este metodo debe retornar un string con toda su informacion.
        E. El metodo Avanzar(int km) que retornara un booleano para informar
           si pudo recorrer o no la cantidad de kilometros recibo por parametro,
           tener en cuenta que para poder avanzar se debe tener conbustible y
           por cada litro de combustible se pueden recorrer 10km.
        */

        // A
        private string marca;
        private double cantCombustible;
        private string color;

        // B
        public Auto(string marca, double cantCombustible, string color)
        {
            this.marca = marca;
            this.cantCombustible = cantCombustible;
            this.color = color;
        }
        //  **** 2do constructor con t/ los datos que ingresan x los texbox convertidos a string ****
        public Auto(string marca, string combustible, string color)
        {
            this.marca = marca;
            this.convertirStringEnCombustible(combustible);
            this.color = color;
        }


        // C
        public string GetMarca()
        {
            return this.marca;
        }
        public double GetCantCombustible()
        {
            return this.cantCombustible;
        }
        public string GetColor()
        {
            return this.color;

        }

        // D 
        public string AutoToString()
        {
            return $"Auto Marca: {marca}. Cantidad de combustible: {cantCombustible}. Color: {color}";
        }

        /* E
           El metodo Avanzar(int km) que retornara un booleano para informar
           si pudo recorrer o no la cantidad de kilometros recibo por parametro,
           tener en cuenta que para poder avanzar se debe tener conbustible y
           por cada litro de combustible se pueden recorrer 10km.
        */

        public bool Avanzar(int km)
        {
            double kmRecorridos = cantCombustible * 10;
            double cantCombustibleConsumido = km / 10;
            double cantCombustibleRestante = cantCombustible - (cantCombustibleConsumido);   // acá también se puede usar operad doble cantCombustible -= km/10


            if (cantCombustible > 0 && km <= kmRecorridos)
            {

                Console.WriteLine($"Se avanzaron {km} km y consumió {cantCombustibleConsumido} lts de combustible.");
                Console.WriteLine($"Del total de {cantCombustible} lts de combustible, le quedan disponibles {cantCombustibleRestante} lts");
                return true;
            }
            else
            {
                Console.WriteLine($"No hay suficiente combustible para avanzar {km}  km.");
                return false;
            }
        }
        // ----------------------------------------------------------------------------------

        // ***** método p/ convertir dato string a double ******
        public bool convertirStringEnCombustible(string combustible)
        {
         bool retorno = false;
            if (double.TryParse(combustible, out double combustValido))
            {
                this.cantCombustible = combustValido;
                retorno = true;
            }
            return retorno;
        }
        // -------------------------------------------------------------

        // método p/agregar una lista de opciones de colores al combobox ------
        public static List<string> ColoresValidos()
        {
            List<string> list = new List<string>()
            {
                "Azul", "Rojo", "Verde", "Amarillo", "Gris"
            };

            return list;
        }
        //------------------------------------------

        public override string ToString()
        {
            return this.AutoToString();
        }


    }
}
