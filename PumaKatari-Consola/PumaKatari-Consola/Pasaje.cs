using System;
using System.IO;
namespace PumaKatariConsola {
   [Serializable]
   public class Pasaje {
      private double tarifa;
      public Pasaje() { this.tarifa = 1.8; }
      public double Tarifa { get => tarifa; set => tarifa = value; }
      public void mostPasaje(){Console.WriteLine("\tPasaje: "+this.tarifa);}
      public void readPasaje(BinaryReader j){ this.tarifa = j.ReadDouble(); }
      public void writePasaje(BinaryWriter j){ j.Write(this.tarifa); }
   }
}
