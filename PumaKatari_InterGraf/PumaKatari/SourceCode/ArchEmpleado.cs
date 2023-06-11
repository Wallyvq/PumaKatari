using System;
using System.IO;
namespace PumaKatariConsola {
   public class ArchEmpleado {
      private string nomArch;
      public ArchEmpleado(string nomArch) { this.nomArch = nomArch; }
      public void CrearRegEmpl(){ if (File.Exists(nomArch)) { File.Delete(nomArch); } }
      public void AdiEmpleado(string nombre, string edad, string id, string cargo){
         Stream file = File.Open(nomArch,FileMode.OpenOrCreate);
         BinaryWriter write = new BinaryWriter(file);
         try {
            Empleado conductor = new Empleado(nombre,int.Parse(edad),id,cargo); 
            write.Seek(0,SeekOrigin.End);
            conductor.WrEmpleado(write);
         }
         catch (Exception){ Console.WriteLine("\n--x-- Fin Registro Empleados --x--"); }
         finally { file.Close(); }
      }       
   }
}
