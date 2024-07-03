namespace GuiaC__Ej05
{
    internal class Presup_Hospital
    {
        static void Main(string[] args)
        {

            // En un hospital existen 3 área: Cardiología, Pediatría y Traumatología. El presupuesto anual del hospital
            // se reparte conforme a la sgte tabla: Cardio: 40%, Pediat: 45%, Traumat: 15% 

            string presupuestoTotalTexto;
            int presuTotalNumero;
            int porcentajeCardioNum;
            int porcentajePediatriaNum;
            int porcentajeTraumaNum;
            int presupuestoCardio;
            int presupuestoPediatria;
            int presupuestoTrauma;

            porcentajeCardioNum = 40;
            porcentajePediatriaNum = 45;
            porcentajeTraumaNum = 15;

            Console.WriteLine(" Por favor ingrese el presupuesto total del hospital :");
            presupuestoTotalTexto = Console.ReadLine();
            presuTotalNumero = int.Parse(presupuestoTotalTexto);

            presupuestoCardio = (presuTotalNumero * porcentajeCardioNum) / 100;
            presupuestoPediatria = (presuTotalNumero * porcentajePediatriaNum) / 100;
            presupuestoTrauma = (presuTotalNumero * porcentajeTraumaNum) / 100;

            Console.WriteLine(" ");
            Console.WriteLine("{0,-30} {1,10}", "Sector/ Porcentaje", "Presupuesto");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(" {0,-30} {2,5:C2}", " Cardiología/ 40% ", " $ ", presupuestoCardio);
            Console.WriteLine(" {0,-30} {2,5:C2}", " Pediatría  / 45% ", " $ ", presupuestoPediatria);
            Console.WriteLine(" {0,-30} {2,5:C2}", " Traumatologia/ 15% ", " $ ", presupuestoTrauma);
            


        }
    }
}
