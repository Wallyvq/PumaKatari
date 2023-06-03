using System;
using System.IO;
namespace PumaKatariConsola {
   [Serializable]
   public class Empleado : Persona {
      private int id;
      private string cargo;   
      public Empleado(string cargo) : base() { this.id = 0; this.cargo = cargo; }
      // Setters y Getters
      public int Id { get { return this.id; } set {this.id = value; } }
      public string Cargo { get { return this.cargo; } set {this.cargo = value; } }
      // metodos
      public void mostEmpleado(){
         Console.WriteLine("\tNombre: {0} \t| Edad: {1} \t| Id: {2} \t| Cargo: {3}",
         this.Nombre, this.Edad, this.id, this.cargo
         );
      }
      public void LeeEmpleado(){
         this.regPersona();
         Console.Write("\t\t\t- Id: "); this.id = int.Parse(Console.ReadLine());
      }
      public void RdEmpleado(BinaryReader j){ 
         base.lector(j);
         this.id = j.ReadInt32(); 
         this.cargo = j.ReadString(); 
      }
      public void WrEmpleado(BinaryWriter j){  
         base.escritor(j);
         j.Write(this.id); 
         j.Write(this.cargo); 
      }
   }
}
