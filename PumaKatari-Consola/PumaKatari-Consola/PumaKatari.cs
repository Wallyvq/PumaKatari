using System;
using System.IO;
namespace PumaKatariConsola {
   public class PumaKatari {
      public static void Main(){
         int op;

         Console.WriteLine("\n--x--------------------------------------x--");
         Console.WriteLine("--x--            PUMA KATARI           --x--");
         Console.WriteLine("--x--------------------------------------x--");

         ArchBus regBus = new ArchBus("RegBuses.dat");
         ArchRuta regRuta = new ArchRuta("RegRutas.dat");
         ArchEmpleado regEmp = new ArchEmpleado("RegEmpleados.dat");
         ArchFecha regFechaRecorrido = new ArchFecha("RecorridoFechas.dat");

         do{
            Console.WriteLine(
               "\t1. Crear Nuevo Registro del PumaKatari\n"+
               "\t2. Agregar Nuevas Rutas, Buses, Empleados y Fechas de Recorrido \n"+
               "\t3. Mostrar Todos los Registros \n"+
               "\t10. Salir del Programa" 
            );
            Console.WriteLine("--x--------------------------------------x--");
            Console.Write("\tOpcion: ");
            op = int.Parse(Console.ReadLine());
            Console.WriteLine("--x--------------------------------------x--");
            switch (op) {
               case 1: 
                  regRuta.CrearRegRuta();
                  regBus.CrearRegBus(); 
                  regEmp.CrearRegEmpl();
                  regFechaRecorrido.CrearRegFecha();
                  break;
               case 2: 
                  regRuta.AdiRuta();
                  regBus.AdiBus(); 
                  regEmp.AdiEmpleado();
                  regFechaRecorrido.AdiFecha();
                  
                  break;
               case 3: 
                  regRuta.MostRegRutas();
                  regBus.MostRegBus();
                  regEmp.MostRegEmple();
                  regFechaRecorrido.MostRegFecha();
                  break;             
               case 10: 
                  Console.WriteLine("--x--------------------------------------x--");
                  Console.WriteLine("--x--         FIN PUMA KATARI          --x--");
                  Console.WriteLine("--x--------------------------------------x--");
                  break;             
            }
         } while (op != 10); 
         Console.WriteLine("\n\n"); 
      }
   }
}