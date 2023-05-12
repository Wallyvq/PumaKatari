using System;
namespace PumaKatari_Consola {
   public class Persona {
      private string nombre;
      protected int edad, ci;
      public Persona(string nombre, int edad, int ci) {
         this.nombre = nombre;
         this.edad = edad;
         this.ci = ci;
      }
      // Setters y Getters
      public string Nombre { get => nombre; set => nombre = value; }
      public int Edad {get => edad; set => edad = value;}
      public int Ci {get => ci; set => ci = value;}
      public void mostPersona(){
         Console.WriteLine(
            "Nombre: "+this.nombre+
            "\nEdad: "+this.edad+
            "\nCI: "+this.ci
         );
      }
      
   }
}
