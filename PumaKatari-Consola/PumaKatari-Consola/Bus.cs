using System;
namespace PumaKatariConsola
{
    public class Bus
    {
      private int placa,id, nroPasajeros;
      private Empleado conductor, pApoyo;
      private Pasajero[] pasajeros = new Pasajero[50];

        public Bus(int placa, int id, int nroPasajeros,Empleado conductor, Empleado pApoyo) {
            this.placa = placa;
            this.id = id;
            this.nroPasajeros = nroPasajeros;
            this.conductor = conductor;
            this.pApoyo = pApoyo;
        }

        // Setters y Getters
        public int Placa { get => placa; set => placa = value; }
        public int Id { get => id; set => id = value; }
        public int NroPasajeros { get => nroPasajeros; set => nroPasajeros = value; }
        public Empleado Conductor { get => conductor; set => conductor = value; }
        public Empleado PApoyo { get => pApoyo; set => pApoyo = value; }
        public Pasajero[] Pasajeros { get => pasajeros; set => pasajeros = value; } 

        //  Metodos

        public void adiPasajero(Pasajero x, int i){ pasajeros[i] = x; }
        public void mostBus(){
            Console.WriteLine( "Bus: "+"\n\tPlaca: "+this.placa+"\t| Id: "+this.id+"\n" );

            Console.WriteLine("\tEmpleados:\n ");
            conductor.mostEmpleado(); pApoyo.mostEmpleado();

            Console.WriteLine("\n\tPasajeros:\n ");
            for (int i = 0; i < this.nroPasajeros; i++) { pasajeros[i].mostPasajero(); }

            Console.WriteLine("");
        }
    }
}
