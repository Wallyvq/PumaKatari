using System;
namespace PumaKatariConsola
{
   public class Empleado : Persona
   {
      private int id;
      private string cargo;

      public Empleado(string nom,int edad, int id, string cargo)
      : base(nom,edad) {
            this.id = id;
            this.cargo = cargo;
      }

      // Setters y Getters
      public int Id { get => id; set => id = value; }
      public string Cargo { get => cargo; set => cargo = value; }

      // metodos

      public void mostEmpleado(){
         // Console.WriteLine("\tEmpleado: ");
         // this.mostPersona();
         // Console.WriteLine( "\t\t- Id: "+this.id+ "\n\t\t- Cargo: "+this.cargo );
         Console.WriteLine("\t\tNombre: {0} \t| Edad: {1} \t| Id: {2} \t| Cargo: {3}",
         this.Nombre, this.Edad, this.id, this.cargo
         );
      }
   }
}
