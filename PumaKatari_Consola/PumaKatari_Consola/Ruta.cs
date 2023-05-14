using System;
namespace PumaKatari_Consola {
   public class Ruta {
      private int nroParadas, nroBuses;
      private Bus[] bus = new Bus[40];
      private Parada[] parada = new Parada[40];
      public Ruta(int nroParadas) {
         this.nroBuses = 0;
         this.nroParadas = nroParadas;
         for (int i = 0; i < this.nroParadas; i++) { parada[i] = new Parada(i+1,"Sopocachi"); }
      }

      // Getters y Setters
      public int NroBuses { get => nroBuses; set => nroBuses = value; }
      public int NroParadas { get => nroParadas; set => nroParadas = value; }
      
      // Metodos
      public void adiBus(Bus x){ bus[this.nroBuses] = x; this.nroBuses++; }
      public void adiParada(Parada x){ parada[this.nroParadas] = x; this.nroParadas++; }      
      public void mostRuta(){
         Console.WriteLine(
            "\tRuta: "+
            "\n\tNro Buses: "+this.nroBuses+
            "\n\tNro Paradas: "+this.nroParadas
         );
         Console.WriteLine("\t- Paradas: ");
         for (int i = 0; i < this.nroParadas; i++) { parada[i].mostParada(); }
         Console.WriteLine("\t- Bus: ");
         for (int i = 0; i < this.nroBuses; i++) { bus[i].mostBus(); }
         
      }

      
   }
}
