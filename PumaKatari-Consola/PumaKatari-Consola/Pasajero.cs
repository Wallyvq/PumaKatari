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
         /* this.mostPersona();
         Console.WriteLine("\t\t- Tipo Pasajero: "+this.tipoPasajero+"\n"); */
         Console.WriteLine("\t\tNombre: {0} \t| Edad: {1} \t| Tipo: {2} ", 
         this.Nombre, this.Edad, this.tipoPasajero );
      }
   }
}
