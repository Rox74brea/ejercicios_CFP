namespace GuiaC__Ej02
{
    internal class nomApellEdad
    {
        static void Main(string[] args)
        {
           

            //2) pedir nombre, apellido y edad por consola

            string nombre;
            string apellido;
            string edadTexto;
            int edadNumerica;


            Console.Write(" Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write(" Ingrese su apellido: ");
            apellido = Console.ReadLine();

            Console.Write(" Ingrese su edad: ");
            edadTexto = Console.ReadLine();
            edadNumerica = int.Parse(edadTexto);

            Console.WriteLine(" ");

            Console.WriteLine("Bienvenido " + nombre + " " + apellido + ", Ud tiene " + edadNumerica + " años");


        }
    }
}
