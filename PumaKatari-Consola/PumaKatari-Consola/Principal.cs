using System;
namespace PumaKatariConsola {
   public class Principal {
      
      public static void Main() {
         Console.WriteLine("");
      
         Bus b3 = new Bus(); b3.regBus(); b3.pjAleatorio(); b3.mostBus();

         Console.WriteLine("\n\n"); 

         Console.ReadKey();
      }
   }
}

