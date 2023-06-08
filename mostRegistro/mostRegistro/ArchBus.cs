using System;
using System.Collections.Generic;
using System.IO ;
using System.Windows;
using System.Windows.Documents;

namespace PumaKatariConsola {
   public class ArchBus {
      private string nomArch; 
      public ArchBus(string nomArch) { this.nomArch = nomArch; }
      public void CrearRegBus(){ if (File.Exists(nomArch)) { File.Delete(nomArch); } } 
      public void AdiBus(string placa,string idBus, string idCond, string idApoyo, string nomRuta, string nroP){
         
         Stream file = File.Open(nomArch, FileMode.OpenOrCreate);
         BinaryWriter write  = new BinaryWriter(file);
         try {
            Bus regBus = new Bus(placa,idBus,nomRuta,idCond,idApoyo,int.Parse(nroP)); 
            write.Seek(0,SeekOrigin.End);
            regBus.WrBus(write);
         }
         catch (Exception){  }
         finally { file.Close(); }
      }
   }
}

