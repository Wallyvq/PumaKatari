using System;
using System.IO;
namespace PumaKatariConsola {
   public class PumaKatari {
      public static void Main(){

         Console.WriteLine("--x--------------------------------------x--");
         Console.WriteLine("--x--            PUMA KATARI           --x--");
         Console.WriteLine("--x--------------------------------------x--");

         ArchBus regBus = new ArchBus("RegBuses.dat");
         ArchRuta regRuta = new ArchRuta("RegRutas.dat");
         ArchEmpleado regEmp = new ArchEmpleado("RegEmpleados.dat");
         ArchFecha regFechaRecorrido = new ArchFecha("RecorridoFechas.dat");

         int op;

         do{
            Console.WriteLine(
               "\t1. Crear Nuevo Registro del PumaKatari\n"+
               "\t2. Agregar Nuevas Rutas \n"+
               "\t3. Mostrar Todos los Registros \n"+
               "\t10. Salir del Programa" 
            );
            Console.WriteLine("--x--------------------------------------x--");
            Console.Write("\tOpcion: ");
            op = int.Parse(Console.ReadLine());
            switch (op) {
               case 1: 
                  regRuta.CrearRegRuta();
                  regBus.CrearRegBus(); 
                  regEmp.CrearRegEmpl();
                  regFechaRecorrido.CrearRegFecha();
                  break;
               case 2: 
                  
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
