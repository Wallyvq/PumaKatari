using System;
using System.IO;
namespace PumaKatariConsola {
   [Serializable]
   public class Ruta {
      private string nomRuta;
      private int nroParadas, nroBus; 
      private Bus[] regBus = new Bus[40];
      private Pasaje tarifa;
      private Parada[] paradas = new Parada[40];

      public Ruta(){
         this.nroParadas = 0;
         this.nroBus = 0;
         this.nomRuta = "";
         for (int i = 0; i < this.nroBus; i++)
         {
            regBus[i] = new Bus();
         }
         
         }

      // Setters y Getters 
      public int NroParadas { get => nroParadas; set => nroParadas = value; }
      public int NroBus { get => nroBus; set => nroBus = value; }
      public string NomRuta { get => nomRuta; set => nomRuta = value; }
      public Bus[] RegBus { get => regBus; set => regBus = value; }
      public Pasaje Tarifa { get => tarifa; set => tarifa = value; }
      public Parada[] Paradas { get => paradas; set => paradas = value; }

      // metodos

      public void mostRuta(){
         Console.WriteLine("Ruta:");
         Console.WriteLine(
            "\n\t- Nombre Ruta: "+this.nomRuta+
            "\n\t- Nro Paradas: "+this.nroParadas+
            "\n\t- Nro Buses: "+this.nroBus 
         );
         for (int i = 0; i < this.nroBus; i++) { regBus[i].mostBus(); }
      }
      public void leerRuta(){
         Console.Write("\t- Nombre Ruta: "); this.nomRuta = Console.ReadLine();
         Console.Write("\t- Nro Paradas: "); this.nroBus = int.Parse(Console.ReadLine());
         Console.Write("\t- Nro Buses: "); this.nroBus = int.Parse(Console.ReadLine());
         for (int i = 0; i < this.nroBus; i++) { 
            Console.WriteLine("\t- Registrando Bus: ");
            this.regBus[i] = new Bus(); this.regBus[i].addbus(); 
         }
      }

      public void readRuta(BinaryReader j){
         this.nomRuta = j.ReadString();
         this.nroParadas = j.ReadInt32();
         this.nroBus = j.ReadInt32();
         for (int i = 0; i < this.nroBus; i++) { this.regBus[i] = new Bus(); this.regBus[i].readBus(j); }

      }

      public void writeRuta(BinaryWriter j){
         j.Write(this.nomRuta);
         j.Write(this.nroParadas);
         j.Write(this.nroBus);
         for (int i = 0; i < this.nroBus; i++) { this.regBus[i].writeBus(j); }
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
