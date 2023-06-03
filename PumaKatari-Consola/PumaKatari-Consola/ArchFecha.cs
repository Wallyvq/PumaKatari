using System;
using System.IO;
namespace PumaKatariConsola {
   public class ArchFecha {
      private string nomArch;
      public ArchFecha(string nomArch) { this.nomArch = nomArch; }
      public void CrearRegFecha(){ if (File.Exists(nomArch)) { File.Delete(nomArch); } } 
      public void RegisFecha(){
         string sw; 
         Stream file = File.Open(nomArch, FileMode.OpenOrCreate);
         BinaryWriter write  = new BinaryWriter(file);
         Console.WriteLine("\n- REGISTRO FECHAS DE RECORRIDO DE BUSES: ");
         try {
            do {
               Fecha regFecha = new Fecha();
               regFecha.LeeFecha();
               write.Seek(0,SeekOrigin.End);
               regFecha.WrFecha(write);
               Console.WriteLine("\n--x-- Desea Continuar s/n --x--");
               Console.Write(" : "); sw = Console.ReadLine();
               
            } while (sw == "s");
         }
         catch (Exception){ Console.WriteLine("\n--x-- Fin Registro Buses --x--"); }
         finally { file.Close(); }
      }
      public void MostRegFecha(){
         Stream file = File.Open(nomArch, FileMode.OpenOrCreate);
         BinaryReader read = new BinaryReader(file);
         Console.WriteLine("\n- LISTADO DE FECHAS DE RECORRIDO: \n");
         try{
            while (true) {
               Fecha mostFecha = new Fecha();
               mostFecha.RdFecha(read);
               mostFecha.MostFecha();
            }
         }
         catch (System.Exception){ Console.WriteLine("\n--x-- Fin Listado Fechas de Recorrido --x--\n"); }
         finally { file.Close(); }
      }
   }
}
