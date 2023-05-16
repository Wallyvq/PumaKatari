using System;
namespace PumaKatariConsola {
   public class Pasaje {
      private double tarifa;
      public Pasaje() { this.tarifa = 1.8; }
      public double Tarifa { get => tarifa; set => tarifa = value; }
      public void mostPasaje(){Console.WriteLine("\tPasaje: "+this.tarifa);}
   }
}
