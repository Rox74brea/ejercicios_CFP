namespace GuiaC__Ej04
{
    internal class Promedio
    {
        static void Main(string[] args)
        {
           
            // Ingresar 5 números enteros, calcular y mostrar el promedio

            string numeroTexto1;
            string numeroTexto2;
            string numeroTexto3;
            string numeroTexto4;
            string numeroTexto5;
            int numeroNum1;
            int numeroNum2;
            int numeroNum3;
            int numeroNum4;
            int numeroNum5;

            int suma;
            int promedio;

            Console.WriteLine(" Ingrese 5 números para ver el promedio de todos ");
            Console.WriteLine(" ");
            Console.WriteLine(" Por favor ingrese el número 1 de 5: ");
            numeroTexto1 = Console.ReadLine();
            numeroNum1 = int.Parse(numeroTexto1);

            Console.WriteLine(" Por favor ingrese el número 2 de 5: ");
            numeroTexto2 = Console.ReadLine();
            numeroNum2 = int.Parse(numeroTexto2);

            Console.WriteLine(" Por favor ingrese el número 3 de 5: ");
            numeroTexto3 = Console.ReadLine();
            numeroNum3 = int.Parse(numeroTexto3);

            Console.WriteLine(" Por favor ingrese el número 4 de 5: ");
            numeroTexto4 = Console.ReadLine();
            numeroNum4 = int.Parse(numeroTexto4);

            Console.WriteLine(" Por favor ingrese el número 5 de 5: ");
            numeroTexto5 = Console.ReadLine();
            numeroNum5 = int.Parse(numeroTexto5);


            suma = numeroNum1 + numeroNum2 + numeroNum3 + numeroNum4 + numeroNum5;
            promedio = suma / 5;

            Console.WriteLine(" ");
            Console.WriteLine("La suma de los 5 números por ud ingresados es : " + suma);
            Console.WriteLine(" ");
            Console.WriteLine("El promedio de los 5 números por ud ingresados es : " + promedio);









        }
    }
}
