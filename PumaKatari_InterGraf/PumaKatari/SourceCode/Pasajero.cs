using System;
using System.IO;
namespace PumaKatariConsola {
   [Serializable]
   public class Pasajero : Persona {
      private string tipoPasajero;
      // Constructores
      public Pasajero(): base(){ } // Constructor vacio para el Cast
      // Constuctor Parametrizado para Adicionar un Objeto Bus al Archivo
      public Pasajero(string nom,int edad, string tipoPasajero) : base(nom,edad) 
      { this.tipoPasajero = tipoPasajero; }
      

      // Getters y Setter
      public string TipoPasajero { get { return this.tipoPasajero;}  set {this.tipoPasajero = value; } }
      public void readPasajero(BinaryReader j){ base.RdPersona(j);this.tipoPasajero = j.ReadString(); } // Read Pasajero
      public void writePasajero(BinaryWriter j){ base.WrPersona(j); j.Write(this.tipoPasajero);} // Write Pasajero

      // Codigo Sin Usar
      //public void mostPasajero(){ Console.WriteLine("\t\t\tNombre: {0} \t| Edad: {1} \t| Tipo: {2} ", this.Nombre, this.Edad, this.tipoPasajero ); }
   }
}
