using System;
using System.IO;
namespace PumaKatariConsola {
   [Serializable]
   public class Parada {
      // private int nroParada;
      private string ubicacion;
      public Parada() {  this.ubicacion = ""; }

      // Setters y Getters
      // public int NroParada { get => nroParada; set => nroParada = value; }
      public string Ubicacion { get => ubicacion; set => ubicacion = value; }
      // Metodos
       
      public void mostParada(){ 
         Console.WriteLine("\t- Ubicacion: {0}",this.ubicacion);
      }

      public void leerParada(){ Console.Write("\t\t- Ubicacion: ");this.ubicacion = Console.ReadLine(); }
      public void lecParada(BinaryReader j){
         // this.nroParada = j.ReadInt32();
         this.ubicacion = j.ReadString();
      }

      public void escParad(BinaryWriter j){
         // j.Write(this.nroParada);
         j.Write(this.ubicacion);
      }

   }
}