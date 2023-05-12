using System;
namespace PumaKatari_Consola {
   public class Conductor : Persona {
      private int id;
      private string horario;
      private double sueldo;
      // Constructor
      public Conductor(string nombre, int edad, int ci,  int id, string horario, double sueldo) 
      : base(nombre, edad, ci) {
         this.id = id;
         this.horario = horario;
         this.sueldo = sueldo;
      }

      // Setters y Getters
      public int Id { get => id; set => id = value; }
      public string Horario { get => horario; set => horario = value; }
      public double Sueldo { get => sueldo; set => sueldo = value; }
        
      // Metodos
      public void mostrarConductor(){
         Console.WriteLine("Conductor: ");
         this.mostrarPersona();
         Console.WriteLine(
            "Id: "+this.id+
            "\nHorario: "+this.horario+
            "\nSueldo: "+this.sueldo
         );
      }
   }
}
