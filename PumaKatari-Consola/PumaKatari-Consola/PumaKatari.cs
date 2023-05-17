using System;
using System.IO;
namespace PumaKatariConsola {
   public class PumaKatari {
      
      private string nomArch;
      // private int nroRutas;
      private Ruta regRuta;
      public PumaKatari(string nomArch) { this.nomArch = nomArch; }

      // Metodos
      public void crear(){ if(File.Exists(nomArch)) {File.Delete(nomArch); } }
      public void adicionar(){
         string sw;
         Stream ruta = File.Open(nomArch,FileMode.OpenOrCreate);
         BinaryWriter escribe = new BinaryWriter(ruta);
         Console.WriteLine("--x-- Agregar Ruta --x--");
         try {
            do {
               regRuta = new Ruta();
               regRuta.leerRuta();
               escribe.Seek(0,SeekOrigin.End);
               regRuta.writeRuta(escribe);
               Console.WriteLine("\n--x-- Desea Continuar s/n --x--");
               Console.Write(" : ");
               sw = Console.ReadLine();  
            } while (sw == "s");
         }
         catch (Exception) { Console.WriteLine("Finish"); }
         finally{ ruta.Close(); }
      }

      public void list(){
         Stream ruta = File.Open(nomArch,FileMode.OpenOrCreate);
         BinaryReader lee = new BinaryReader(ruta);
         try {
            while (true) {
               regRuta = new Ruta();
               regRuta.readRuta(lee);
               regRuta.mostRuta();
            }
         }
         catch(Exception ){ Console.WriteLine("\n--x-- End List --x--\n"); }
         finally { ruta.Close(); }
      }

      
      
   }
}
