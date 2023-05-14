using System;
namespace PumaKatariConsola {
   public class Principal {
      public static void pjAleatorio(Bus x){
         
         string[] tipoPersona = new string[]{"normal","estudiante","discapacidad","adulto mayor"};
         string[] nombres = new string[]{"Sofia","Lucas","Diego","Max","Zoe","Leo","Rex","Ben","Mia","Ana"};

         Random rnd = new Random();

         for (int i = 0; i < x.NroPasajeros; i++) { 
            int iNom = rnd.Next(nombres.Length); 
            int iTipopj = rnd.Next(tipoPersona.Length);
            int edad = rnd.Next(18,60); 

            if( tipoPersona[iTipopj] == "estudiante"){ edad = rnd.Next(5,18); }
            else if(tipoPersona[iTipopj] == "adulto mayor"){ edad = rnd.Next(60,80); }
            
            Pasajero pj = new Pasajero(nombres[iNom],edad,tipoPersona[iTipopj]);
            
            x.adiPasajero(pj,i);
         }
      }
      public static void Main() {
         Console.WriteLine("");
         Empleado e1 = new Empleado("Carlos",25,101010,"Conductor");
         Empleado e2 = new Empleado("Pepe",30,202020,"Personal Apoyo");

         Pasajero p1 = new Pasajero("Jhonny",18,"Estudiante");
         
         Bus b1 = new Bus(398121, 138423,5,e1,e2);
         Bus b2 = new Bus(108472, 138294,5,e1,e2);

         pjAleatorio(b1); pjAleatorio(b2);
         
         b1.mostBus(); b2.mostBus();

         Console.WriteLine(""); 
      }
   }
}
