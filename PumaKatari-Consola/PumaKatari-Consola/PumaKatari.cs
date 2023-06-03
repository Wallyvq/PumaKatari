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

         //regBus.crearRegBus(); 
         //regBus.adiBus(); 
         regBus.mostRegBus();

         // regRuta.crearRegRuta(); 
         // regRuta.adiRuta(); 
         regRuta.mostRegRutas();
         
         // regEmp.CrearRegEmpl();
         // regEmp.RegisEmpleado(); 
         regEmp.mostRegEmple();

         //regFechaRecorrido.CrearRegFecha(); regFechaRecorrido.RegisFecha(); 
         regFechaRecorrido.MostRegFecha();


         /* int op;
         Console.WriteLine("--x--------------------------------------x--");
         Console.WriteLine("--x--            PUMA KATARI           --x--");
         Console.WriteLine("--x--------------------------------------x--");
         do{
            Console.WriteLine(
               "\t1. Crear Nuevo Registro \n"+
               "\t2. Agregar Nuevas Rutas \n"+
               "\t3. Mostrar Registro \n"+
               "\t10. Salir del Programa" 
            );
            Console.WriteLine("--x--------------------------------------x--");
            Console.Write("\tOpcion: ");
            op = int.Parse(Console.ReadLine());
            switch (op) {
               case 1: 
                  //puma.crear(); 
                   Console.WriteLine("\n--x-- Restaurando Archivo Vacio --x--\n");
                  break;
               case 2: 
                  //puma.adicionar(); 
                  break;
               case 3: 
                  //puma.list(); 
                  break;             
               case 10: 
                  Console.WriteLine("--x--------------------------------------x--");
                  Console.WriteLine("--x--             FINISH               --x--");
                  Console.WriteLine("--x--------------------------------------x--");
                  break;             
            }
         } while (op != 10);
         Console.WriteLine("\n\n"); 
         */
      /* public void asignarTarifa(){
            for (int i = 0; i < this.nroPasajeros; i++){
                if(pasajeros[i].TipoPasajero == "estudiante" || pasajeros[i].TipoPasajero == "adulto mayor" || pasajeros[i].TipoPasajero == "discapacidad"){
                    pasajeros[i].Tarifa.Tarifa = 1 ;
                }
            }
        } */
      }
      
   }
}
