using System;
namespace PumaKatariConsola {
   public class Ruta {
      private string nomRuta;
      private int nroParadas, nroBus; 
      private Parada[] paradas = new Parada[40];

      public Ruta(int nroParadas, Pasaje tarifa) {
            this.nroParadas = nroParadas;
            
      }

      // Setters y Getters 
      public int NroParadas { get => nroParadas; set => nroParadas = value; }
      public Parada[] Paradas { get => paradas; set => paradas = value; }

      // metodos
      public void mostRuta(){
         Console.WriteLine("Ruta: ");
         
         Console.WriteLine("\tParadas: ");
         Console.Write("\t");
         for (int i = 0; i < this.nroParadas; i++) { 
            Console.Write("\t"+paradas[i].Ubicacion+"\t|");
            // paradas[i].mostParada(); 
         }
         
      }

      public void adiParada(Parada x, int i){ paradas[i] = x;}
   }
}
