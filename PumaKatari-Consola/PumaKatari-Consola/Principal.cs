using System;
namespace PumaKatariConsola {
   public class Principal {
      
      public static void Main() {
         Console.WriteLine("");

         PumaKatari puma = new PumaKatari("puma.dat");
         int op;
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
                  puma.crear(); 
                   Console.WriteLine("\n--x-- Restaurando Archivo Vacio --x--\n");
                  break;
               case 2: 
                  puma.adicionar(); 
                  break;
               case 3: 
                  puma.list(); 
                  break;             
               case 10: 
                  Console.WriteLine("--x--------------------------------------x--");
                  Console.WriteLine("--x--             FINISH               --x--");
                  Console.WriteLine("--x--------------------------------------x--");
                  break;             
            }
         } while (op != 10);
         
         Console.WriteLine("\n\n"); 
         // Console.ReadKey();
      }
   }
}

