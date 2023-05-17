using System;
using System.IO;
namespace PumaKatariConsola {
    [Serializable]
    public class Bus {
        private int placa,id, nroPasajeros;
        private Empleado conductor, pApoyo;
        private Pasajero[] pasajeros = new Pasajero[50];
        public Bus(){ this.placa = 0; this.id = 0; }

        // Setters y Getters
        public int Placa { get => placa; set => placa = value; }
        public int Id { get => id; set => id = value; }
        public int NroPasajeros { get => nroPasajeros; set => nroPasajeros = value; }
        public Empleado Conductor { get => conductor; set => conductor = value; }
        public Empleado PApoyo { get => pApoyo; set => pApoyo = value; }
        public Pasajero[] Pasajeros { get => pasajeros; set => pasajeros = value; } 

        //  Metodos

        
        public void mostBus(){
            Console.WriteLine( "Bus: "+"\n\tPlaca: "+this.placa+"\t| Id: "+this.id+"\n" );
            Console.WriteLine("\tEmpleados:\n ");
            conductor.mostEmpleado(); pApoyo.mostEmpleado();
            Console.WriteLine("\n\tPasajeros:\n ");
            for (int i = 0; i < this.nroPasajeros; i++) { pasajeros[i].mostPasajero(); }
            Console.WriteLine("");
        }

        public void regBus(){
            Console.Write("Placa: "); this.placa = int.Parse(Console.ReadLine());
            Console.Write("Id: "); this.id = int.Parse(Console.ReadLine());
            Console.Write("Nro Pasajeros: "); this.nroPasajeros = int.Parse(Console.ReadLine());
            Console.Write("Conductor: \n"); conductor = new Empleado("Conductor") ;this.conductor.leer();
            Console.Write("Personal Apoyo: \n"); pApoyo = new Empleado("Personal Apoyo"); this.pApoyo.leer();
        }

        public void pjAleatorio(){
            string[] tipoPersona = new string[]{"estandar","estudiante","discapacidad","adulto mayor","estandar"};
            string[] nombres = new string[]{"Sofia","Lucas","Diego","Max","Zoe","Leo","Rex","Ben","Mia","Ana"};

            Random rnd = new Random();

            for (int i = 0; i < this.NroPasajeros; i++) { 
                int iNom = rnd.Next(nombres.Length); 
                int iTipopj = rnd.Next(tipoPersona.Length);
                int edad = rnd.Next(18,60); 
                if( tipoPersona[iTipopj] == "estudiante"){ edad = rnd.Next(5,18); }
                else if(tipoPersona[iTipopj] == "adulto mayor"){ edad = rnd.Next(60,80); } 
                Pasajero pj = new Pasajero(nombres[iNom],edad,tipoPersona[iTipopj]);
                adiPasajero(pj,i);
            }
        }
        public void adiPasajero(Pasajero x, int i){ pasajeros[i] = x; }

        public void readBus(BinaryReader j){
            this.placa = j.ReadInt32();
            this.id = j.ReadInt32();
            this.nroPasajeros = j.ReadInt32();
            this.conductor = new Empleado("conductor"); this.conductor.readEmpleado(j);
            this.pApoyo = new Empleado("Personal Apoyo"); this.pApoyo.readEmpleado(j);

            for (int i = 0; i < this.nroPasajeros; i++) {
                this.pasajeros[i] = new Pasajero();
                this.pasajeros[i].readPasajero(j);
            }
        }

        public void writeBus(BinaryWriter j){
            j.Write(this.placa); j.Write(this.id); j.Write(this.nroPasajeros);
            this.conductor.writeEmpleado(j); this.pApoyo.writeEmpleado(j);
            
            for (int i = 0; i < this.nroPasajeros; i++) { this.pasajeros[i].writePasajero(j); }
        }


        
        /* public void asignarTarifa(){
            for (int i = 0; i < this.nroPasajeros; i++){
                if(pasajeros[i].TipoPasajero == "estudiante" || pasajeros[i].TipoPasajero == "adulto mayor" || pasajeros[i].TipoPasajero == "discapacidad"){
                    pasajeros[i].Tarifa.Tarifa = 1 ;
                }
            }
        } */
    }
}
