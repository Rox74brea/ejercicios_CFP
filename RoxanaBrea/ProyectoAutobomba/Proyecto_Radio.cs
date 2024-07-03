
using Libreria_Radio;
using System.ComponentModel.Design;
using System.Text.RegularExpressions;

namespace Proyecto_Radio
{
    internal class Proyecto_Radio
    {
        static void Main(string[] args)
        {

            int volumen;
            string volumenTexto;
            string selector;
            int codigoEmisora;
            string emisora01 = " 98.3 - Mega FM";
            string emisora02 = "100.7 - Blue FM";
            string emisora03 = "102.3 - Aspen FM";
            string mensajeDeError = "La opción elegida No es correcta, ingrese una opción válida";
            string cdNombre;
            string parteCdA_Escuchar;
            int cant_Temas_Cd;


            Radio radio1 = new Radio("Noblex", 2, "radio",20);

            Console.WriteLine(" ¿ Desea escuchar radio o CD ?");
            Console.WriteLine(" ");
            selector = Console.ReadLine();

            switch (selector)
            {
                case "radio":
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("  **** Ingrese el codigo de la emisora ****  ");
                        Console.WriteLine("----------------------------------------------- ");
                        Console.WriteLine("{0,-15} {1,20}", "Codigo de Emisora", "Emisora");
                        Console.WriteLine("----------------------------------------------- ");
                        Console.WriteLine("{0,-15} {1,25} ", "  01   ", emisora01);
                        Console.WriteLine("{0,-15} {1,25} ", "  02   ", emisora02);
                        Console.WriteLine("{0,-15} {1,25} ", "  03   ", emisora03);
                        Console.WriteLine(" ");
                        codigoEmisora = int.Parse(Console.ReadLine());

                        Console.WriteLine(" *** Seleccione el volumen deseado ( 1- Bajo // 2- Intermedio // 3- Alto ) *** ");
                        Console.WriteLine(" ");
                        volumen = int.Parse(Console.ReadLine());

                        // hacer funcion elegir volumen *************************
                        switch (volumen)
                        {
                            case 1:
                                {
                                    volumenTexto = "Bajo";
                                    break;
                                }
                            case 2:
                                {
                                    volumenTexto = "Intermedio";
                                    break;
                                }
                            case 3:
                                {
                                    volumenTexto = "Alto";
                                    Console.WriteLine(" *** Cuidado!!!! Escuchar a volumen alto es perjudicial *** ");
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine(mensajeDeError);
                                    break;
                                }
                        }
                        // ---------------------------------------------------------------------------


                        // ver de hacer funcion transmitir radio **********************************************
                        // ver q necesito q muestre el volumenTexto y no el volumen solo
                        // debería ser el retorno de la funcion volumen


                        if (codigoEmisora > 0 & codigoEmisora <= 3)
                        {
                            switch (codigoEmisora)
                            {
                                case 1:
                                    {
                                        Console.WriteLine($"transmitiendo radio {emisora01} a volumen ");
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine($"transmitiendo radio {emisora02} a volumen ");
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine($"transmitiendo radio {emisora03} a volumen ");
                                        break;
                                    }
                            }
                        }
                        else
                        {
                            Console.WriteLine(mensajeDeError);
                        }
                        // ------------------------------------------------------------------------------------------
                        break;
                    }
                case "cd":
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine(" ¿ Qué CD vas a escuchar ?  ");
                        cdNombre = Console.ReadLine();
                        Console.WriteLine(" ");
                        Console.WriteLine(" ¿ Cuántos temas tiene el CD ?");
                        cant_Temas_Cd = int.Parse(Console.ReadLine());
                        Console.WriteLine(" ");
                        Console.WriteLine(" ¿ Querés escuchar el CD completo o una pista ? (completo - pista)  ");
                        parteCdA_Escuchar = Console.ReadLine();
                        Console.WriteLine("------------------------------------------------------------------- ");
                        switch (parteCdA_Escuchar)
                        {
                            case "completo":
                                {
                                    Console.Write($"** REPRODUCIENDO LOS {cant_Temas_Cd} TEMAS DEL CD {cdNombre} COMPLETO **");
                                    break;
                                }
                            case "pista":
                                {
                                    int pista;
                                    string otroTema;
                                    do
                                    {
                                        Console.WriteLine(" Ingresá el número de tema que querés escuchar ");
                                        pista = int.Parse(Console.ReadLine());
                                        Console.WriteLine(" ");
                                        Console.WriteLine($"REPRODUCIENDO LA PISTA {pista} DEL CD {cdNombre} ");
                                        Console.WriteLine(" ");
                                        Console.WriteLine("¿ Querés escuchar otro tema ? ( SI - NO )");
                                        otroTema = Console.ReadLine();
                                    } while (otroTema == "SI");
                                    
                                }
                            break;
                        }
                    break;
                    }
                default:
                    {
                        Console.WriteLine(mensajeDeError);
                        break;
                    }
                    break;


  


                    //  ------------------ lista de objetos ------------------------
                    Radio radio2 = new Radio("Aiwa", 1, "radio", 100);
                    Radio radio3 = new Radio("Philips", 3, "radio", 50);
                    Radio radio4 = new Radio("Pioneer", 0, "cd", 30);
                    Radio radio5 = new Radio("Noblex", 0, "cd", 70);

                    List<Radio> listaDeRadios = new List<Radio>();
                    listaDeRadios.Add(radio2);
                    listaDeRadios.Add(radio3);
                    listaDeRadios.Add(radio4);
                    listaDeRadios.Add(radio5);









            }
        }
    }
}
