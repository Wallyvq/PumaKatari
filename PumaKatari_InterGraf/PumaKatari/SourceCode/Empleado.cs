using System;
using System.IO;
namespace PumaKatariConsola {
   [Serializable]
   public class Empleado : Persona {
      private string cargo, id;   
      // Constructores
      public Empleado() : base() {  } // Constructor vacio para el Cast
      // Constuctor Parametrizado para Adicionar un Objeto Bus al Archivo
      public Empleado(string nombre, int edad ,string id, string cargo) : base(nombre,edad) {
         this.id = id;
         this.cargo = cargo;
      }
      // Getters y Setters
      public string Id { get { return this.id; } set {this.id = value; } }
      public string Cargo { get { return this.cargo; } set {this.cargo = value; } }

      // Read Empleado
      public void RdEmpleado(BinaryReader j){ 
         base.RdPersona(j);
         this.id = j.ReadString(); 
         this.cargo = j.ReadString(); 
      }
      // Write Empleado
      public void WrEmpleado(BinaryWriter j){  
         base.WrPersona(j);
         j.Write(this.id); 
         j.Write(this.cargo); 

      }
      // Codigo Sin Usar
      /*
      public void mostEmpleado(){
         Console.WriteLine("\tNombre: {0}\t\t| Edad: {1} \t| Id: {2} \t| Cargo: {3}",
         this.Nombre, this.Edad, this.id, this.cargo
         );
      }
      public void LeeEmpleado(){
         this.LeePersona();
         Console.Write("\t\t- Id: "); this.id = Console.ReadLine();
      }
      */
   }
}
