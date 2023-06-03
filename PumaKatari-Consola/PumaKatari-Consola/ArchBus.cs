using System;
using System.IO ;
namespace PumaKatariConsola {
   public class ArchBus {
      private string nomArch; 
      public ArchBus(string nomArch) { this.nomArch = nomArch; }
      public void crearRegBus(){ if (File.Exists(nomArch)) { File.Delete(nomArch); } } 
      public void adiBus(){
         string sw; int c = 0;
         Stream file = File.Open(nomArch, FileMode.OpenOrCreate);
         BinaryWriter write  = new BinaryWriter(file);
         Console.WriteLine("REGISTRO DE BUSES (Limite 40): ");
         try {
            do {
               Bus regBus = new Bus();
               regBus.LeeBus();
               write.Seek(0,SeekOrigin.End);
               regBus.WriteBus(write);
               c++;
               if( c >= 40){ sw = "n"; Console.WriteLine("Alcanzaste el Limite de Buses"); }
               else{
                  Console.WriteLine("\n--x-- Desea Continuar s/n --x--");
                  Console.Write(" : "); sw = Console.ReadLine();
               }
            } while (sw == "s");
         }
         catch (Exception){ Console.WriteLine("--x-- Fin Registro Buses --x--"); }
         finally { file.Close(); }
      }
      public void mostRegBus(){
         Stream file = File.Open(nomArch, FileMode.OpenOrCreate);
         BinaryReader read = new BinaryReader(file);
         Console.WriteLine("LISTADO DEL REGISTRO DE BUSES: ");
         try{
            while (true) {
               Bus lisBus = new Bus();
               lisBus.ReadBus(read);
               lisBus.MostBus();
            }
         }
         catch (System.Exception){ Console.WriteLine("--x-- Fin Listado Buses --x--"); }
         finally { file.Close(); }
      }

   }
}
