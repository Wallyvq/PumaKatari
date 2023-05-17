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
         for (int i = 0; i < this.nroParadas; i++) { this.paradas[i] = new Parada(); }
         for (int i = 0; i < this.nroBus; i++){ this.regBus[i] = new Bus(); }
         this.tarifa = new Pasaje();
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
            "\n\t- Nombre Ruta: "+this.nomRuta //+
            /* "\n\t- Nro Paradas: "+this.nroParadas+ */
            /* "\n\t- Nro Buses: "+this.nroBus  */
         );
         Console.WriteLine("\t-Tarifa: "+this.tarifa.Tarifa);
         Console.WriteLine("\t- Paradas: \n");
         for (int i = 0; i < this.nroParadas; i++) { this.paradas[i].mostParada(i+1); }
         for (int i = 0; i < this.nroBus; i++) { this.regBus[i].mostBus(i+1); }
      }
      public void leerRuta(){
         Console.Write("\t- Nombre Ruta: "); this.nomRuta = Console.ReadLine();
         Console.Write("\t- Nro Paradas: "); this.nroParadas = int.Parse(Console.ReadLine());
         Console.Write("\t- Nro Buses: "); this.nroBus = int.Parse(Console.ReadLine());
         Console.WriteLine("\t- Agrega al Ubicacion de las Paradas: ");
         for (int i = 0; i < this.nroParadas; i++) { this.paradas[i] = new Parada(); this.paradas[i].leerParada(); }
         for (int i = 0; i < this.nroBus; i++) { 
            Console.WriteLine("\t- Registrando Bus: ");
            this.regBus[i] = new Bus(); this.regBus[i].addbus(); 
         }         
      }

      public void readRuta(BinaryReader j){
         this.nomRuta = j.ReadString();
         this.nroParadas = j.ReadInt32();
         this.nroBus = j.ReadInt32();
         this.tarifa.readPasaje(j);
         for (int i = 0; i < this.nroBus; i++) { this.regBus[i] = new Bus(); this.regBus[i].readBus(j); }
         for (int i = 0; i < this.nroParadas; i++) { this.paradas[i] = new Parada(); this.paradas[i].lecParada(j);}
      }
      public void writeRuta(BinaryWriter j){
         j.Write(this.nomRuta);
         j.Write(this.nroParadas);
         j.Write(this.nroBus);
         this.tarifa.writePasaje(j);
         for (int i = 0; i < this.nroBus; i++) { this.regBus[i].writeBus(j); }
         for (int i = 0; i < this.nroParadas; i++) { this.paradas[i].escParad(j); }
      }      
   }
}
