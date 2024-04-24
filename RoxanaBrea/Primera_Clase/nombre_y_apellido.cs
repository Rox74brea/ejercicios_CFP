using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Primera_Clase
{
    internal class nombre_y_apellido
    {
        static void Main(string[] args)
        {
            //1) pedir y mostrar el nombre y apellido del usuario


            string nombre;
            string apellido;


           Console.Write(" Ingrese su nombre: ");
            nombre = Console.ReadLine();

           Console.Write(" Ingrese su apellido: ");
            apellido = Console.ReadLine();

            Console.WriteLine(" ");
            
            Console.Write("Bienvenido " + nombre + " " + apellido);
           




        }
    }
}
