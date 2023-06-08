using System;
using System.IO;
namespace PumaKatariConsola {
   [Serializable]
   public class Pasaje {
      private double tarifa;
      public Pasaje() { this.tarifa = 1.8; }
      public double Tarifa { get {return this.tarifa; }  set { this.tarifa = value; } }
      public void MostPasaje(){Console.WriteLine("\tPasaje: "+this.tarifa);}
      public void RdPasaje(BinaryReader j){ this.tarifa = j.ReadDouble(); }
      public void WrPasaje(BinaryWriter j){ j.Write(this.tarifa); }
   }
}
