using System;
namespace PumaKatariConsola
{
   public class Parada
   {
      // private int nroParada;
      private string ubicacion;
      public Parada(/* int nroParada, */ string ubicacion) {
         // this.nroParada = nroParada;
         this.ubicacion = ubicacion;
      }

      // Setters y Getters
      // public int NroParada { get => nroParada; set => nroParada = value; }
      public string Ubicacion { get => ubicacion; set => ubicacion = value; }
      // Metodos
      
      // public void mostParada(){ Console.WriteLine("\t|Ubicacion: {0}", this.ubicacion);}

   }
}
