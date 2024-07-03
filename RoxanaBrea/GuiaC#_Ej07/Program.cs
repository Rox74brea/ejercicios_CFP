using System.Runtime.ConstrainedExecution;

namespace GuiaC__Ej07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ej 07 (REPETITIVAS)  Ingresar 15 números y determinar: 
                a - Suma de los negativos.
                b - Suma de los positivos.
                c - Cantidad de positivos.
                d - Cantidad de negativos.
                e - Cantidad de ceros.
                f - Cantidad de números pares.
                g - Promedio de positivos.
                h - Promedio de negativos.
                i - Diferencia entre positivos y negativos, (positivos-negativos). 
                j - El número máximo
                k - De los negativos el mínimo
             */

            Definir i Como Entero;
            Definir final Como Entero;
            Definir numeroIngresado Como Entero;
            Definir sumaNegativos Como Entero;
            Definir sumaPositivos Como Entero;
            Definir cantidadPositivos Como Entero;
            Definir cantidadNegativos Como Entero;
            Definir cantidadCeros Como Entero;
            Definir cantidadPares Como Entero;
            Definir promedioPositivos Como Real;
            Definir promedioNegativos Como Real;
            Definir diferenciaNumero Como Entero;
            Definir numeroMax Como Entero;
            Definir numeroMinNegativo Como Entero;

            final = 15;
            sumaNegativos = 0;
            sumaPositivos = 0;
            cantidadPositivos = 0;
            cantidadNegativos = 0;
            cantidadCeros = 0;
            cantidadPares = 0;



            Para i = 1 Hasta final Con Paso 1 Hacer

            Escribir "Ingrese el numero ", i, " de ", final;
            leer numeroIngresado;

            Si numeroIngresado > 0 Entonces
                sumaPositivos = sumaPositivos + numeroIngresado;
            cantidadPositivos = cantidadPositivos + 1;
            promedioPositivos = sumaPositivos / cantidadPositivos;
            SiNo
                Si  numeroIngresado < 0 Entonces
                     sumaNegativos = sumaNegativos + numeroIngresado;
            cantidadNegativos = cantidadNegativos + 1;
            promedioNegativos = sumaNegativos / cantidadNegativos;
            SiNo
               Si numeroIngresado == 0 Entonces
                    cantidadCeros = cantidadCeros + 1;
            FinSi
        FinSi

            FinSi

            Si numeroIngresado Mod 2 == 0 Entonces
                cantidadPares = cantidadPares + 1;
            FinSi

           diferenciaNumero = sumaPositivos + sumaNegativos; // OJO...!!!! PONER EL "+" xq si pongo menos los va a sumar xq - x - es +


            Fin Para















        }
    }
}
