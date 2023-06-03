using System;
using System.IO;
namespace PumaKatariConsola {
    [Serializable]
    public class Bus {
        private string placa, id, nomRuta;
        private int  nroPasajeros;
        private Empleado conductor, pApoyo;
        private Pasajero[] pasajeros = new Pasajero[50];
        public Bus(){}

        // Setters y Getters
        public string Placa { get { return this.placa;} set {this.placa = value;} }
        public string Id { get { return this.id; } set {this.id = value;} }
        public int NroPasajeros { get { return this.nroPasajeros; } set {this.nroPasajeros = value;} }
        public string NomRuta { get{ return this.nomRuta; } set { this.nomRuta = value; } }
        public Empleado Conductor { get { return this.conductor; } set {this.conductor = value;} }
        public Empleado PApoyo { get { return this.pApoyo; } set {this.pApoyo = value;} }
        public Pasajero[] Pasajeros { get { return this.pasajeros; } set {this.pasajeros = value; } }

        //  Metodos       
        public void MostBus(){
            Console.WriteLine( "\n\t- Datos del Bus: \n"+"\n\t\tPlaca: {0} \t|Id: {1} \t| Nro Ruta: {2}",this.placa,this.id,this.NomRuta);
            Console.WriteLine("\t\tEmpleados:\n ");
            conductor.mostEmpleado(); pApoyo.mostEmpleado();
            /* Console.WriteLine("\n\t\tPasajeros:\n ");
            for (int i = 0; i < this.nroPasajeros; i++) { pasajeros[i].mostPasajero(); } */
            Console.WriteLine("");
        }
        public void LeeBus(){
            Console.Write("\tPlaca: "); this.placa = Console.ReadLine();
            Console.Write("\tId: "); this.id = Console.ReadLine();
            Console.Write("\tNom Ruta: "); this.nomRuta = Console.ReadLine();
            Console.Write("\tNro Pasajeros: "); this.nroPasajeros = int.Parse(Console.ReadLine());
            Console.Write("\tConductor: \n"); conductor = new Empleado("Conductor") ;this.conductor.leer();
            Console.Write("\tPersonal Apoyo: \n"); pApoyo = new Empleado("Personal Apoyo"); this.pApoyo.leer();
        }
        public void AdiPasajero(Pasajero x, int i){ pasajeros[i] = x; }
        public void ReadBus(BinaryReader j){
            this.placa = j.ReadString();
            this.id = j.ReadString();
            this.nroPasajeros = j.ReadInt32();this.nomRuta = j.ReadString();
            this.conductor = new Empleado("conductor"); this.conductor.readEmpleado(j);
            this.pApoyo = new Empleado("Personal Apoyo"); this.pApoyo.readEmpleado(j);
            /* for (int i = 0; i < this.nroPasajeros; i++) {
                this.pasajeros[i] = new Pasajero();
                this.pasajeros[i].readPasajero(j);
            }  */
        }
        public void WriteBus(BinaryWriter j){
            j.Write(this.placa); j.Write(this.id); j.Write(this.nroPasajeros); j.Write(this.nomRuta);
            this.conductor.writeEmpleado(j); this.pApoyo.writeEmpleado(j);
            // for (int i = 0; i < this.nroPasajeros; i++) { this.pasajeros[i].writePasajero(j); }
        }

    }
}
