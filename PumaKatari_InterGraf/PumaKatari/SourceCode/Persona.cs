using System;
using System.IO;
namespace PumaKatariConsola {
   [Serializable]
   public class Persona {
      private string nombre;
      private int  edad;
      // Constructores
      public Persona(){ this.nombre = ""; this.edad = 0; } // Constructor vacio para el Cast
      // Constuctor Parametrizado para Adicionar un Objeto Bus al Archivo

      // Getters y Setters
      public Persona(string nombre,int edad) { this.nombre = nombre; this.edad = edad; }
      public int Edad { get { return this.edad; } set { this.edad = value; } }
      public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
      // Read Persona
      public void RdPersona(BinaryReader j){ 
         this.nombre = j.ReadString(); 
         this.edad = j.ReadInt32(); 
      }
      // Write Persona
      public void WrPersona(BinaryWriter j){ 
         j.Write(this.nombre); 
         j.Write(this.edad); 
      }
      /* 
      public void LeePersona(){
         Console.Write("\t\t- Nombre: "); this.nombre = Console.ReadLine();
         Console.Write("\t\t- Edad: "); this.edad =  int.Parse(Console.ReadLine());
      }
      public void MostPersona(){ Console.WriteLine("|\t- Nombre: "+this.nombre+"\n\t- Edad: "+this.edad ); } 
      */

   }
}
