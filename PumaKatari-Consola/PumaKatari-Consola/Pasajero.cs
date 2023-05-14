using System;
namespace PumaKatariConsola {
   public class Pasajero : Persona {
      private string tipoPasajero;
      public Pasajero(string nom,int edad, string tipoPasajero) 
      : base(nom,edad) 
      { this.tipoPasajero = tipoPasajero; }

      // Setters y Getters
      public string TipoPasajero { get => tipoPasajero; set => tipoPasajero = value; }

      // Metodos
      public void mostPasajero(){
         Console.WriteLine("Pasajero: ");
         this.mostPersona();
         Console.WriteLine("\t- Tipo Pasajero: "+this.tipoPasajero);
      }
   }
}
