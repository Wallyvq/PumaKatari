using System;
namespace PumaKatari_Consola {
   public class Ruta {
      private int nroParadas, nroBuses;
      private Bus[] bus = new Bus[40];
      private Parada[] parada = new Parada[40];
      public Ruta() {
         this.nroParadas = 0;
         this.nroBuses = 0;
      }

      // Getters y Setters
      public int NroBuses { get => nroBuses; set => nroBuses = value; }
      public int NroParadas { get => nroParadas; set => nroParadas = value; }
      public void adiBus(Bus x){ bus[this.nroBuses] = x; this.nroBuses++; }
      public void adiParada(Parada x){ parada[this.nroParadas] = x; this.nroParadas++; }

      // Metodos
      public void mostRuta(){
         Console.WriteLine(
            "Ruta: "+
            "\nNro Buses: "+this.nroBuses+
            "\nNro Paradas: "+this.parada
         );
         for (int i = 0; i < this.nroBuses; i++) { bus[i].mostBus(); }
         for (int i = 0; i < this.nroParadas; i++) { parada[i].mostParada(); }
      }
   }
}
