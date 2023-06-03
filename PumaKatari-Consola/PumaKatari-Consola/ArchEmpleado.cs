using System;
using System.IO;
namespace PumaKatariConsola {
   public class ArchEmpleado {
      private string nomArch;
      public ArchEmpleado(string nomArch) { this.nomArch = nomArch; }
      public void CrearRegEmpl(){ if (File.Exists(nomArch)) { File.Delete(nomArch); } }
      public void AdiEmpleado(){
         Stream file = File.Open(nomArch,FileMode.OpenOrCreate);
         BinaryWriter write = new BinaryWriter(file);
         string sw;
         Console.WriteLine("\n- REGISTRO DE EMPLEADOS: \n");
         try {
            do {   
               Empleado conductor = new Empleado("Conductor"); 
               Empleado pApoyo = new Empleado("Personal Apoyo");
               Console.WriteLine("\tDatos Conductor: "); 
               conductor.LeeEmpleado(); 
               Console.WriteLine("\tDatos Pers. Apoyo: "); 
               pApoyo.LeeEmpleado();
               write.Seek(0,SeekOrigin.End);
               conductor.WrEmpleado(write); pApoyo.WrEmpleado(write);
               Console.WriteLine("\n--x-- Desea Continuar s/n --x--");
               Console.Write(" : "); sw = Console.ReadLine();
            } while ( sw == "s");         
         }
         catch (Exception){ Console.WriteLine("\n--x-- Fin Registro Empleados --x--"); }
         finally { file.Close(); }
      }
      public void MostRegEmple(){
         Stream file = File.Open(nomArch, FileMode.OpenOrCreate);
         BinaryReader read = new BinaryReader(file);
         Console.WriteLine("\n- LISTA DE EMPLEADOS: \n");
         try{
            while (true) {
               Empleado conductor = new Empleado("Conductor"); 
               Empleado pApoyo = new Empleado("Personal Apoyo");
               conductor.RdEmpleado(read);
               pApoyo.RdEmpleado(read);
               conductor.mostEmpleado();
               pApoyo.mostEmpleado();
            }
         }
         catch (System.Exception){ Console.WriteLine("\n--x-- Fin Listado Empleados --x--\n"); }
         finally { file.Close(); }
      }
   }
}
