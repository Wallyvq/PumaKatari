using System;
using System.IO;
namespace PumaKatariConsola {
   public class ArchRuta {
      private string nomArch;
      public ArchRuta(string nomArch) { this.nomArch = nomArch; }
      public void crearRegRuta(){ if (File.Exists(nomArch) ) { File.Delete(nomArch); } }
      public void adiRuta(){
         string sw; int c = 0;
         Stream file = File.Open(nomArch,FileMode.OpenOrCreate);
         BinaryWriter write = new BinaryWriter(file);
         Console.WriteLine("REGISTRO DE RUTAS (Limite 7): ");
         try {
            do {
               Ruta regRuta = new Ruta();
               regRuta.LeerRuta();
               write.Seek(0,SeekOrigin.End);
               regRuta.WriteRuta(write);
               c++;
               if( c >= 7){ sw = "n"; Console.WriteLine("Alcanzaste el Limite de Rutas"); }
               else{
                  Console.WriteLine("\n--x-- Desea Continuar s/n --x--");
                  Console.Write(" : "); sw = Console.ReadLine();
               }
            } while (sw == "s");
         }
         catch (Exception){ Console.WriteLine("--x-- Fin Registro Buses --x--"); }
         finally { file.Close(); }
      }
      public void mostRegRutas(){
         Stream file = File.Open(nomArch,FileMode.OpenOrCreate);
         BinaryReader read = new BinaryReader(file);
         Console.WriteLine("LISTADO DEL REGISTRO DE RUTAS: ");
         try{
            while(true){
               Ruta listRuta = new Ruta();
               listRuta.ReadRuta(read);
               listRuta.MostRuta();
            }
         }
         catch (System.Exception){ Console.WriteLine("--x-- Fin Listado Buses --x--"); }
         finally { file.Close(); }
      }
   }
}
