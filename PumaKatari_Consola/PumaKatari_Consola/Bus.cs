using System;
namespace PumaKatari_Consola {
   public class Bus { 
      private int placa,id,capacidad;
      private Conductor conductor;
      private PersonalApoyo apoyo;
      public Bus(int placa, int id, int capacidad, Conductor conductor, PersonalApoyo apoyo) {
         this.placa = placa;
         this.id = id;
         this.capacidad = capacidad;
         this.conductor = conductor;
         this.apoyo = apoyo;
      }
      // Setters y Getters
      public PersonalApoyo Apoyo { get => apoyo; set => apoyo = value; }
      public Conductor Conductor { get => conductor; set => conductor = value; }
      public int Id { get => id; set => id = value;}
      public int Placa { get => placa; set => placa = value;}
      public int Capacidad { get => capacidad; set => capacidad = value;}
      
      // Metodos
      public void mostBus(){
         Console.WriteLine(
            "Id: "+this.id+
            "\nPlaca: "+this.placa+
            "\nCapacidad: "+this.capacidad
         );
         conductor.mostConductor();
         apoyo.mostPersApoyo();
      }
   }
}
