using System;
using System.IO;
namespace PumaKatariConsola {
   [Serializable]
   public class Fecha {
      private string fechaReg, idBus;
      public Fecha() { }
      public string FechaReg { get { return this.fechaReg; }  set { this.fechaReg = value; } }
      public string IdBus { get { return this.idBus; } set { this.idBus = value; } }
      public void LeeFecha(){
         Console.Write("\t- Feha: "); this.fechaReg = Console.ReadLine();
         Console.Write("\t- ID Bus: "); this.idBus = Console.ReadLine();
      }
      public void MostFecha(){
         Console.WriteLine("\t Fecha: {0} \t| ID Bus: {1}",this.fechaReg,this.idBus);
      }
      public void RdFecha(BinaryReader j){
         this.fechaReg = j.ReadString();
         this.idBus = j.ReadString();
      }
      public void WrFecha(BinaryWriter j){
         j.Write(this.fechaReg);
         j.Write(this.idBus);
      }
   }
}
