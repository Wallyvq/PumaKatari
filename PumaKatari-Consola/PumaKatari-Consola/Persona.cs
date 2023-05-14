using System;
namespace PumaKatariConsola {
   public class Persona {
      private int  edad;
      private string nombre;

      public Persona(string nombre,int edad) {
            this.nombre = nombre;
            this.edad = edad;
      }
      // Setters y Getters
      public int Edad { get => edad; set => edad = value; }
      public string Nombre { get => nombre; set => nombre = value; }

      // metodos
      public void mostPersona(){
         Console.WriteLine(
            "\t- Nombre: "+this.nombre+
            "\n\t- Edad: "+this.edad
         );
      }
   }
}
