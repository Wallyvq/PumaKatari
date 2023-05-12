using System;
namespace PumaKatari_Consola {
   public class Linea {
      private int nroLineas, nroRutas;
      private string nomLinea;
      private Ruta[] ruta = new Ruta[7];
      public Linea(int nroLineas, int nroRutas, string nomLinea) {
         this.nroLineas = nroLineas;
         this.nroRutas = nroRutas;
         this.nomLinea = nomLinea;
      }

      // Getters y Setters
      public int NroRutas { get => nroRutas; set => nroRutas = value; }
      public int NroLineas { get => nroLineas; set => nroLineas = value; }
      public string NomLinea { get => nomLinea; set => nomLinea = value; }
      public Ruta[] Ruta { get => ruta; set => ruta = value; }

      // Metodos
      public void mostLinea(){
         Console.WriteLine(
            "Nro Lineas: "+this.nroLineas+
            "\nNombre Linea: "+this.nomLinea+
            "\nRutas: "
         );
         for (int i = 0; i < this.nroRutas; i++) { ruta[i].mostRuta(); }
      }
   }
}
