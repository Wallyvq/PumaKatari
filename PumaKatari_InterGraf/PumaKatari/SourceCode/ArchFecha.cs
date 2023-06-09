using System;
using System.IO;
namespace PumaKatariConsola {
   public class ArchFecha {
      private string nomArch;
      public ArchFecha(string nomArch) { this.nomArch = nomArch; }
      public void CrearRegFecha(){ if (File.Exists(nomArch)) { File.Delete(nomArch); } } 
      public void AdiFecha(string idBus, string fecha){
         //string sw; 
         Stream file = File.Open(nomArch, FileMode.OpenOrCreate);
         BinaryWriter write  = new BinaryWriter(file);
         //Console.WriteLine("\n- REGISTRO FECHAS DE RECORRIDO DE BUSES: ");
         try {    
               Fecha regFecha = new Fecha(idBus,fecha);          
               write.Seek(0,SeekOrigin.End);
               regFecha.WrFecha(write);
         }
         catch (Exception){ Console.WriteLine("\n--x-- Fin Registro Buses --x--"); }
         finally { file.Close(); }
      }
      /*public void MostRegFecha(){
         Stream file = File.Open(nomArch, FileMode.OpenOrCreate);
         BinaryReader read = new BinaryReader(file);
        // Console.WriteLine("\n- LISTADO DE FECHAS DE RECORRIDO: \n");
         try{
            while (true) {
               Fecha mostFecha = new Fecha();
               mostFecha.RdFecha(read);
            }
         }
         catch (System.Exception){ Console.WriteLine("\n--x-- Fin Listado Fechas de Recorrido --x--\n"); }
         finally { file.Close(); }
      } */
   }
}
