namespace GuiaC__Ej06_bis
{
    internal class Lamparitas_Switch

    {
        static void Main(string[] args)
        {

            float precio;
            string cantUnidCompraTexto;
            int cantUnidCompraNumerico;
            float descuento;
            float importeDesc;
            float totCompra;
            float totCompraConDesc;
            string marca;
            float porcentIngresosBrutos;
            float importeIngrBrutos;

            Console.WriteLine("Por favor ingrese la cantidad de unidades de la compra ");
            cantUnidCompraTexto = Console.ReadLine();
            cantUnidCompraNumerico = int.Parse(cantUnidCompraTexto);
            Console.WriteLine(" ");

            precio = 150;
            totCompra = cantUnidCompraNumerico * precio;

            Console.WriteLine("Ingrese la marca del producto");
            marca = Console.ReadLine();

            switch (cantUnidCompraNumerico)
            {
                case 3:
                    {
                        switch (marca)
                        {
                            case "argentinaluz":
                                descuento = 15;
                                break;
                            case "felipelamparas":
                                descuento = 10;
                                break;
                            default:
                                descuento = 5;
                                break;
                        }
                    break;
                    }
                case 4:
                    {
                        if (marca == "argentinaluz" || marca == "felipelamparas")
                        {
                            descuento = 25;
                        }
                        else
                        {
                            descuento = 20;
                        }
                    break;
                    }

                case 5:
                    {
                        switch (marca)
                        {
                            case "argentinaluz":
                                descuento = 40;
                                break;
                            default:
                                descuento = 30;
                                break;
                        }
                        break;
                    }
                default:
                    if (cantUnidCompraNumerico >= 6)
                    {
                        descuento = 50;
                    }
                    break;
            } 


                    Console.WriteLine(" El detalle de su compra es:");
                    Console.WriteLine(" Total de unidades: ", cantUnidCompraNumerico, " Precio unitario $ ", precio);

                    if (cantUnidCompraNumerico <= 5 && cantUnidCompraNumerico >= 3)
                    {
                        Console.WriteLine(" Marca del producto :", marca);
                    }

                    Console.WriteLine("Total de la compra: $ ", totCompra);

                    if (descuento > 0)
                    {
                        importeDesc = totCompra * descuento / 100;
                        totCompraConDesc = totCompra - importeDesc;
                        Console.WriteLine(" Descuento por promo unidades/ marca: - ", descuento, " %", " Son $ ", importeDesc);
                        Console.WriteLine(" Total de la compra con descuento: $ ", totCompraConDesc);
                    }

                    if (totCompra > 950)
                    {
                        porcentIngresosBrutos = 10;
                        importeIngrBrutos = totCompra * porcentIngresosBrutos / 100;
                        Console.WriteLine(" Se recarga un ", porcentIngresosBrutos, " % en concepto de IIBB", " Son $ ", importeIngrBrutos);
                        Console.WriteLine(" Total a pagar $ ", totCompra + importeIngrBrutos);
                    }

            
        }
    }
}















