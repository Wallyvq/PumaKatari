using System;
using System.IO;
namespace PumaKatariConsola {
   [Serializable]
   public class Parada {
      private string ubicacion;
      // Constructores
      public Parada() { } // Constructor vacio para el Cast
      // Constuctor Parametrizado para Adicionar un Objeto Bus al Archivo
      public Parada(string ubicacion){ this.ubicacion = ubicacion;}

      // Getter y Setter
      public string Ubicacion { get { return this.ubicacion; } set { this.ubicacion = value; } }
      public void RdParada(BinaryReader j){ this.ubicacion = j.ReadString(); } // Read Parada
      public void WrParada(BinaryWriter j){ j.Write(this.ubicacion); } //  Write Parada

      // Codigo sin Usar
      //public void MostParada(){ Console.Write("\t{0}",this.ubicacion); }
      //public void LeeParada(){ Console.Write("\t\t- Ubicacion: ");this.ubicacion = Console.ReadLine(); }
   }
}