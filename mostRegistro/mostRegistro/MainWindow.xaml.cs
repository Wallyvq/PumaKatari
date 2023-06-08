using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using PumaKatariConsola;

namespace mostRegistro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ArchBus regBus = new ArchBus("RegBuses.dat");
      
        public MainWindow()
        {
      
            InitializeComponent();

        }

        private void btnCrearReg(object sender, RoutedEventArgs e)
        {
            regBus.CrearRegBus();
            MessageBox.Show("Nuevo Archivo Creado");
        }

        private void btnAdicionar(object sender, RoutedEventArgs e)
        {
            Add_Bus agregarBus = new Add_Bus(); 
            agregarBus.ShowDialog();

        }

        private void btnListar(object sender, RoutedEventArgs e)
        {
            Stream file = File.Open("RegBuses.dat", FileMode.OpenOrCreate);
            BinaryReader read = new BinaryReader(file);
            List<Bus> list = new List<Bus>();
            try
            {
                while (true)
                {
                    Bus lisBus = new Bus();
                    lisBus.RdBus(read);
                    list.Add(lisBus);
                }
                

            }
            catch (System.Exception) { Console.WriteLine("\n--x-- Fin Listado Buses --x--\n"); }
            finally { file.Close(); }

            dgBuses.ItemsSource = list;
        }

       

        
    }
}
