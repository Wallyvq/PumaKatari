using System;
namespace PumaKatari_Consola {
   public class Parada {
      private int nroParada;
      private string ubicacion;
      public Parada(int nroParada, string ubicacion) {
         this.nroParada = nroParada;
         this.ubicacion = ubicacion;
      }

      // Getters y Setters
      public string Ubicacion { get => ubicacion; set => ubicacion = value; }
      public int NroParada { get => nroParada; set => nroParada = value; }
      
      // Metodos
      public void mostParada(){ Console.Write( "\t\t Nro Parada: "+this.nroParada+"\t"+ "| Ubicacion: "+this.ubicacion+"\n" ); }
   }
}
