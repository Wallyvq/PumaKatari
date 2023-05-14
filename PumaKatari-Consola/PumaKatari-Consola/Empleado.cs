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
         Console.WriteLine("Empleado: ");
         this.mostPersona();
         Console.WriteLine(
            "\t- Id: "+this.id+
            "\n\t- Cargo: "+this.cargo
         );
      }
   }
}
