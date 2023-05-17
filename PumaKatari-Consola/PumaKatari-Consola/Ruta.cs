using System;
using System.IO;
namespace PumaKatariConsola {
   [Serializable]
   public class Ruta {
      private string nomRuta;
      private int nroParadas, nroBus; 
      private Bus regBus;
      private Pasaje tarifa;
      // private Parada[] paradas = new Parada[40];

      public Ruta(int nroParadas, Pasaje tarifa) { this.nroParadas = nroParadas; }

      public Ruta(){this.nroParadas = 0;}

      // Setters y Getters 
      public int NroParadas { get => nroParadas; set => nroParadas = value; }
      // public Parada[] Paradas { get => paradas; set => paradas = value; }

      // metodos

      public void mostRuta(){
         Console.WriteLine("Nro Buses: "+this.nroBus);
      }
      public void leerRuta(){
         Console.Write("Nro Buses: "); this.nroBus = int.Parse(Console.ReadLine());
      }

      public void readRuta(BinaryReader j){
         this.nroBus = j.ReadInt32();
      }

      public void writeRuta(BinaryWriter j){
         j.Write(this.nroBus);
      }


      /* public void mostRuta(){
         Console.WriteLine("Ruta: ");
         Console.WriteLine("\tParadas: ");
         Console.Write("\t");
         for (int i = 0; i < this.nroParadas; i++) { 
            Console.Write("\t"+paradas[i].Ubicacion+"\t|");
            // paradas[i].mostParada(); 
         } 
      }*/
      // public void adiParada(Parada x, int i){ paradas[i] = x;}

      
   }
}
