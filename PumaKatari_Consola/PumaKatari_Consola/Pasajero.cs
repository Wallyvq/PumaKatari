using System;
namespace PumaKatari_Consola {
   public class Pasajero : Persona {
      private int rangoEdad, idAsiento;
      private string tipoPasajero;

      // Constructor
      public Pasajero( string nombre, int edad, int ci, int rangoEdad, int idAsiento, string tipoPasajero) 
      : base(nombre, edad, ci) {
         this.rangoEdad = rangoEdad;
         this.idAsiento = idAsiento;
         this.tipoPasajero = tipoPasajero;
      }
      
      // Setters y Getters
      public string TipoPasajero { get => tipoPasajero; set => tipoPasajero = value; }
      public int IdAsiento { get => idAsiento; set => idAsiento = value; }
      public int IdAsiento1 { get => idAsiento; set => idAsiento = value; }

      // Metodos
      public void mostrarPasajero(){
         Console.WriteLine("Pasajero: ");
         this.mostrarPersona();
         Console.WriteLine(
            "Rango Edad: "+this.rangoEdad+
            "\nId Asiento: "+this.idAsiento+
            "\nTipo Pasajero: "+this.tipoPasajero
         );
      }
      
   }
}
