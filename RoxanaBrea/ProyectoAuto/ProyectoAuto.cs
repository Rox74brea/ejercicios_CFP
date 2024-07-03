
using LibreriaAuto;


namespace ProyectoAuto

{
    internal class ProyectoAuto
    {
        static void Main(string[] args)
        {



            Auto Auto1 = new Auto("Peugeot", 1, "azul"); 

            bool pudoAvanzar = Auto1.Avanzar(1); 
            if (pudoAvanzar)
            {
                Console.WriteLine($"Pudo avanzar los km deseados.");
            }
            else
            {
                Console.WriteLine ($"No puede avanzar los km deseados.");
            }





        }
    }
}
