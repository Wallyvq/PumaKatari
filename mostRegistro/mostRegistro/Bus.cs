using System;
using System.IO;
namespace PumaKatariConsola {
    [Serializable]
    public class Bus {
        private string placa, id, nomRuta , idConductor, idPersApoyo;
        private int  nroPasajeros;
        //private Pasajero[] pasajeros = new Pasajero[50];
        public Bus(){}
        public Bus(string placa, string id, string nomRuta, string idConductor, string idPersApoyo, int nroPasajeros)
        {
            this.placa = placa;
            this.id = id;
            this.nomRuta = nomRuta;
            this.idConductor = idConductor;
            this.idPersApoyo = idPersApoyo;
            this.nroPasajeros = nroPasajeros;
        }
        public string Placa { get { return this.placa;} set {this.placa = value;} }
        public string Id { get { return this.id; } set {this.id = value;} }
        public int NroPasajeros { get { return this.nroPasajeros; } set {this.nroPasajeros = value;} }
        public string IdConductor { get { return this.idConductor; } set {this.idConductor = value;} }
        public string IdPersApoyo { get { return this.idPersApoyo; } set {this.idPersApoyo = value;} }
        public string NomRuta { get{ return this.nomRuta; } set { this.nomRuta = value; } }
        public void RdBus(BinaryReader j){
            this.placa = j.ReadString();
            this.id = j.ReadString();
            this.nroPasajeros = j.ReadInt32();
            this.nomRuta = j.ReadString();
            this.idConductor = j.ReadString();
            this.idPersApoyo = j.ReadString();
        }
        public void WrBus(BinaryWriter j){
            j.Write(this.placa); 
            j.Write(this.id); 
            j.Write(this.nroPasajeros); 
            j.Write(this.nomRuta);
            j.Write(this.idConductor);
            j.Write(this.idPersApoyo);   
        }
    }
}
