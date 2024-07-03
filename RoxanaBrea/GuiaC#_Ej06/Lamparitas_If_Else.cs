namespace GuiaC__Ej06
{
    internal class Lamparitas_If_Else
    {
        static void Main(string[] args)
        {

            // Una empresa que se dedica a la comercialización de lamparitas de bajo consumo, registra de sus ventas,
            // los siguientes datos: marca y cantidad.
            // El precio de cada lamparita es de $150 (Sin importar la marca).
            // El programa deberá calcular el precio total de la venta, aplicando un descuento si es que corresponde.
            // A. Si compra 6 lamparitas o más, tiene un descuento del 50%.
            // B. Si compra 5 lamparitas marca "ArgentinaLuz" se aplica un 40% y si es de otra marca, el descuento es del 30%.
            // C. Si compra 4 lamparitas marca "ArgentinaLuz" o "FelipeLamparas" se hace un descuento del 25%, 
            //    y si es de otra marca el descuento es del 20%.
            // D. Si compra 3 lamparitas marca "ArgentinaLuz" el descuento es del 15%, 
            //     si es "FelipeLamparas se hace un descuento del 10% y si es otra marca, 5%.
            // E. Si el importe final con descuento suma más de $950, se debe agregar el 10% de ingresos brutos.
            // Informar: cantidad de lamparitas, marca, total sin descuento, descuento, total con descuento, y si corresponde
            //  total de ingresos brutos y total a pagar.


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


            if (cantUnidCompraNumerico >= 6)
            {
                descuento = 50;
            }
            else
            {
                if (cantUnidCompraNumerico == 5)
                {
                    Console.WriteLine("Ingrese la marca del producto");
                    marca = Console.ReadLine();

                    if (marca == "argentinaluz")
                    {
                        descuento = 40;
                    }
                    else
                    {
                        descuento = 30;
                    }
                }
                else
                {
                    if (cantUnidCompraNumerico == 4)
                    {
                        Console.WriteLine("Ingrese la marca del producto");
                        marca = Console.ReadLine();

                        if (marca == "argentinaluz" || marca == "felipelamparas")
                        {
                            descuento = 25;
                        }
                        else
                        {
                            descuento = 20;
                        }
                    }
                    else
                    {
                        if (cantUnidCompraNumerico == 3)
                        {
                            Console.WriteLine("Ingrese la marca del producto");
                            marca = Console.ReadLine();

                            if (marca == "argentinaluz")
                            {
                                descuento = 15;
                            }
                            else
                            {
                                if (marca == "felipelamparas")
                                {
                                    descuento = 10;
                                }
                                else
                                {
                                    descuento = 5;
                                }
                            }
                        }
                    }
                }
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
