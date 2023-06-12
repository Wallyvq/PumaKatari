using PumaKatariConsola;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PumaKatari.Screens
{

    public partial class BusesRuta : Window
    {
        public BusesRuta()
        {
            InitializeComponent();
        }

        
        // Este es el metodo MostBusLinea
        private void btnMostBusLinea_Click(object sender, RoutedEventArgs e)
        {
            
            List<Bus> listBus= new List<Bus>();
            Stream file = File.Open("RegistroBuses.dat", FileMode.OpenOrCreate);
            BinaryReader read = new BinaryReader(file);
            try {
                while(true) {
                    Bus bus = new Bus();
                    bus.RdBus(read);
                    if ( bus.NomRuta == txtBuscarRuta.Text) {
                        listBus.Add(bus);
                    }                    
                }
            }
            catch (Exception ){ Console.WriteLine("--x-- Fin Mostrar Buses Linea/ Ruta X --x--"); }
            finally { file.Close(); }

            dgBusesRuta.ItemsSource = listBus;
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
