using System;
using System.IO ;
using System.Numerics;
using System.Windows.Controls;

namespace PumaKatariConsola {
   public class ArchBus {
      private string nomArch; 
      public ArchBus(string nomArch) { this.nomArch = nomArch; }
      public void CrearRegBus(){ if (File.Exists(nomArch)) { File.Delete(nomArch); } }
      public void AdiBus( string placa,string idBus,string idConductor,string idApoyo,string nomRuta,string nroPj ) {
         
         Stream file = File.Open(nomArch, FileMode.OpenOrCreate);
         BinaryWriter write  = new BinaryWriter(file);
         
         try {
            Bus regBus = new Bus(placa,idBus,idConductor,idApoyo,nomRuta,int.Parse(nroPj));
            write.Seek(0,SeekOrigin.End);
            regBus.WrBus(write);
         }
         
         catch (Exception){ Console.WriteLine("\n--x-- Fin Registro Buses --x--\n"); }
         
         finally { file.Close(); }
      }
   }
}

