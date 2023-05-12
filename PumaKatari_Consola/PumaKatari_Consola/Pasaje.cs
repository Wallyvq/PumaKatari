using System;
namespace PumaKatari_Consola {
   public class Pasaje { 
      private double tarifa ;
      public Pasaje() { this.tarifa = 1.8; }
      
      // Setters y Getters
      public double Tarifa {get => tarifa; set => tarifa = value; } 

      // Metodos
      public void mostPasaje(){ Console.WriteLine("Tarifa: "+this.tarifa); }

   }
}
