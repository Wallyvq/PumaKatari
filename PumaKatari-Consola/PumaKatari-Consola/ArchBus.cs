using System;
using System.IO ;
namespace PumaKatariConsola {
   public class ArchBus {
      private string nomArch; 
      public ArchBus(string nomArch) { this.nomArch = nomArch; }
      public void CrearRegBus(){ if (File.Exists(nomArch)) { File.Delete(nomArch); } } 
      public void AdiBus(){
         string sw; int c = 0;
         Stream file = File.Open(nomArch, FileMode.OpenOrCreate);
         BinaryWriter write  = new BinaryWriter(file);
         Console.WriteLine("\n- REGISTRO DE BUSES (Limite 40): ");
         try {
            do {
               Console.WriteLine("-------------");
               Bus regBus = new Bus();
               regBus.LeeBus();
               write.Seek(0,SeekOrigin.End);
               regBus.WrBus(write);
               c++;
               if( c >= 40){ sw = "n"; Console.WriteLine("Alcanzaste el Limite de Buses"); }
               else{
                  Console.WriteLine("\n--x-- Desea Continuar s/n --x--");
                  Console.Write(" : "); sw = Console.ReadLine();
               } 
            } while ( sw == "s" );
         }
         catch (Exception){ Console.WriteLine("\n--x-- Fin Registro Buses --x--\n"); }
         finally { file.Close(); }
      }
      public void MostRegBus(){
         Stream file = File.Open(nomArch, FileMode.OpenOrCreate);
         BinaryReader read = new BinaryReader(file);
         Console.WriteLine("LISTADO DE BUSES: ");
         try{
            while (true) {
               Bus lisBus = new Bus();
               lisBus.RdBus(read);
               lisBus.MostBus();
            }
         }
         catch (System.Exception){ Console.WriteLine("\n--x-- Fin Listado Buses --x--\n"); }
         finally { file.Close(); }
      }

   }
}

