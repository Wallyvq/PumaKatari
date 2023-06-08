using System;
using System.IO;
namespace PumaKatariConsola {
   [Serializable]
   public class Parada {
      private string ubicacion;
      public Parada() {  this.ubicacion = "Parque Urbano Central"; }
      public string Ubicacion { get { return this.ubicacion; } set { this.ubicacion = value; } }
      public void MostParada(){ Console.Write("\t{0}",this.ubicacion); }
      public void LeeParada(){ Console.Write("\t\t- Ubicacion: ");this.ubicacion = Console.ReadLine(); }
      public void RdParada(BinaryReader j){ this.ubicacion = j.ReadString(); }
      public void WrParada(BinaryWriter j){ j.Write(this.ubicacion); }
   }
}