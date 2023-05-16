using System;
namespace PumaKatariConsola {
   public class Empleado : Persona {
      private int id;
      private string cargo;   
      public Empleado(string cargo) : base() { this.id = 0; this.cargo = cargo; }

      // Setters y Getters
      public int Id { get => id; set => id = value; }
      public string Cargo { get => cargo; set => cargo = value; }
      // metodos
      public void mostEmpleado(){
         Console.WriteLine("\t\tNombre: {0} \t| Edad: {1} \t| Id: {2} \t| Cargo: {3}",
         this.Nombre, this.Edad, this.id, this.cargo
         );
      }
      public void leer(){
         this.regPersona();
         Console.Write("\tId: "); this.id = int.Parse(Console.ReadLine());
      }
   }
}
