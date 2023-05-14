using System;
namespace PumaKatariConsola
{
   public class Principal
   {
      public static void Main()
      {
         Empleado e1 = new Empleado("Carlos",25,101010,"Conductor");
         Empleado e2 = new Empleado("Carlos",25,101010,"Personal Apoyo");

         Pasajero p1 = new Pasajero("Jhonny",18,"Estudiante");

         e1.mostEmpleado();
         e2.mostEmpleado();
         p1.mostPasajero();


      }
   }
}
