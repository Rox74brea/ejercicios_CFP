using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GuiaC__Ej03
{
    internal class SumaNum
    {
        static void Main(string[] args)
        {

            // ingresar 2 números y mostrar la suma de los mismos


            string numeroTexto1;
            string numeroTexto2;
            int numeroNum1;
            int numeroNum2;
            int suma;

            Console.WriteLine(" Ingrese dos números para ver la sumatoria de ambos ");
            Console.WriteLine(" Por favor ingrese el primer número: ");
            numeroTexto1= Console.ReadLine();
            numeroNum1 = int.Parse(numeroTexto1);

            Console.WriteLine(" Por favor ingrese el segundo número: ");
            numeroTexto2 = Console.ReadLine();
            numeroNum2 = int.Parse(numeroTexto2);
            Console.WriteLine(" ");

            suma = numeroNum1 + numeroNum2;
            Console.WriteLine( " La suma de " + numeroNum1 + " y " + numeroNum2 + " es : " + suma);


        }
    }
}
