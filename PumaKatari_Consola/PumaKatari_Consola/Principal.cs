using System;
namespace PumaKatari_Consola
{
   public class Principal
   {
      public static void Main()
      {
         Linea l1 = new Linea(/* 3,1,"Linea C" */);
         
         Ruta r1 = new Ruta(3);
         Ruta r2 = new Ruta(2);
         
         Conductor c1 = new Conductor("Juan Perez",35,21272,20202,"08-20",3500);
         Conductor c2 = new Conductor("Alan Brito",40,12324,30303,"08-20",3500);
         
         PersonalApoyo pa1 = new PersonalApoyo("Carlos Pinto",30,192834,13432,"08-20",2000);
         PersonalApoyo pa2 = new PersonalApoyo("Trini Gomez",35,13245,40404,"08-20",3100);

         Bus b1 = new Bus(1834,10101,50,c1,pa1);
         Bus b2 = new Bus(1244,11111,40,c2,pa2);
         
         r1.adiBus(b1); l1.adiRuta(r1);

         r2.adiBus(b2); l1.adiRuta(r2);

         l1.mostLinea();

      }
   }
}
