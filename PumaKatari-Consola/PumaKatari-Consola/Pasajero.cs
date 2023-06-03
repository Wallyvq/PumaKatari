using System;
using System.IO;
namespace PumaKatariConsola {
   [Serializable]
   public class Pasajero : Persona {
      private string tipoPasajero;
      public Pasajero(string nom,int edad, string tipoPasajero) 
      : base(nom,edad) 
      { this.tipoPasajero = tipoPasajero; }
      public Pasajero(): base(){ }
      // Setters y Getters
      public string TipoPasajero { get { return this.tipoPasajero;}  set {this.tipoPasajero = value; } }
      // Metodos
      public void mostPasajero(){ Console.WriteLine("\t\t\tNombre: {0} \t| Edad: {1} \t| Tipo: {2} ", this.Nombre, this.Edad, this.tipoPasajero ); }
      public void readPasajero(BinaryReader j){ base.lector(j);this.tipoPasajero = j.ReadString(); }
      public void writePasajero(BinaryWriter j){ base.escritor(j); j.Write(this.tipoPasajero);}
   }
}
