using System;
using System.IO;
namespace PumaKatariConsola {
   [Serializable]
   public class Persona {
      private string nombre;
      private int  edad;
      public Persona(string nombre,int edad) { this.nombre = nombre; this.edad = edad; }
      public Persona(){ this.nombre = ""; this.edad = 0; } // Constructor vacio
      public int Edad { get { return this.edad; } set { this.edad = value; } }
      public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
      public void LeePersona(){
         Console.Write("\t\t- Nombre: "); this.nombre = Console.ReadLine();
         Console.Write("\t\t- Edad: "); this.edad =  int.Parse(Console.ReadLine());
      }
      public void MostPersona(){ Console.WriteLine("|\t- Nombre: "+this.nombre+"\n\t- Edad: "+this.edad ); } 

      public void RdPersona(BinaryReader j){ 
         this.nombre = j.ReadString(); 
         this.edad = j.ReadInt32(); 
      }
      public void WrPersona(BinaryWriter j){ 
         j.Write(this.nombre); 
         j.Write(this.edad); 
      }
   }
}
