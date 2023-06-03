using System;
using System.IO;
namespace PumaKatariConsola {
   public class ArchRuta {
      private string nomArch;
      public ArchRuta(string nomArch) { this.nomArch = nomArch; }
      public void CrearRegRuta(){ if (File.Exists(nomArch) ) { File.Delete(nomArch); } }
      public void AdiRuta(){
         string sw; int c = 0;
         Stream file = File.Open(nomArch,FileMode.OpenOrCreate);
         BinaryWriter write = new BinaryWriter(file);
         Console.WriteLine("\n- REGISTRO DE RUTAS (Limite 7): ");
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
         catch (Exception){ Console.WriteLine("\n--x-- Fin Registro Rutas --x--\n"); }
         finally { file.Close(); }
      }
      public void MostRegRutas(){
         Stream file = File.Open(nomArch,FileMode.OpenOrCreate);
         BinaryReader read = new BinaryReader(file);
         Console.WriteLine("\n- LISTADO DEL REGISTRO DE RUTAS: ");
         try{
            while(true){
               Ruta listRuta = new Ruta();
               listRuta.ReadRuta(read);
               listRuta.MostRuta();
            }
         }
         catch (System.Exception){ Console.WriteLine("\n--x-- Fin Listado Buses --x--\n"); }
         finally { file.Close(); }
      }
   }
}
