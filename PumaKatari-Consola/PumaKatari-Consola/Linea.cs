using System;
namespace PumaKatariConsola {
   public class Linea {
      
      private int nroLinea, nroRutas, nroBuses;
      private string nomLinea;
      private Ruta[] rutas = new Ruta[7];
      private Bus[] bus = new Bus[40];

      public Linea(int nroLinea, int nroRutas, int nroBuses, string nomLinea) {
            this.nroLinea = nroLinea;
            this.nroRutas = nroRutas;
            this.nroBuses = nroBuses;
            this.NomLinea = nomLinea;
      }

      // Setters y Getters
      public int NroLinea { get => nroLinea; set => nroLinea = value; }
      public int NroRutas { get => nroRutas; set => nroRutas = value; }
      public int NroBuses { get => nroBuses; set => nroBuses = value; }
      public string NomLinea { get => nomLinea; set => nomLinea = value; }
      public Ruta[] Rutas { get => rutas; set => rutas = value; }
      public Bus[] Bus { get => bus; set => bus = value; }
   }
}
