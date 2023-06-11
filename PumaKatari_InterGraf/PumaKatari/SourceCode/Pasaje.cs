using System;
using System.IO;
namespace PumaKatariConsola {
   [Serializable]
   public class Pasaje {
      private double tarifa;
      // Constructores
      public Pasaje(){}// Constructor vacio para el Cast
      // Constuctor Parametrizado para Adicionar un Objeto Bus al Archivo
      public Pasaje(double tarifa) { this.tarifa = tarifa; }

      // Getters y Setter
      public double Tarifa { get {return this.tarifa; }  set { this.tarifa = value; } }
      
      public void RdPasaje(BinaryReader j){ this.tarifa = j.ReadDouble(); } //  Read Pasaje
      public void WrPasaje(BinaryWriter j){ j.Write(this.tarifa); } // Write Pasaje

      // Codigo sin Usar
      //public void MostPasaje(){Console.WriteLine("\tPasaje: "+this.tarifa);}
   }
}
