using System;
using System.IO;
namespace PumaKatariConsola {
   [Serializable]
   public class Empleado : Persona {
      private string cargo, id;   
      public Empleado(string cargo) : base() { this.cargo = cargo; }
      public string Id { get { return this.id; } set {this.id = value; } }
      public string Cargo { get { return this.cargo; } set {this.cargo = value; } }
      public void mostEmpleado(){
         Console.WriteLine("\tNombre: {0}\t\t| Edad: {1} \t| Id: {2} \t| Cargo: {3}",
         this.Nombre, this.Edad, this.id, this.cargo
         );
      }
      public void LeeEmpleado(){
         this.LeePersona();
         Console.Write("\t\t- Id: "); this.id = Console.ReadLine();
      }
      public void RdEmpleado(BinaryReader j){ 
         base.RdPersona(j);
         this.id = j.ReadString(); 
         this.cargo = j.ReadString(); 
      }
      public void WrEmpleado(BinaryWriter j){  
         base.WrPersona(j);
         j.Write(this.id); 
         j.Write(this.cargo); 
      }
   }
}
