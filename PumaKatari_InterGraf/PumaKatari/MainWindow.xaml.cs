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

namespace PumaKatari
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            //screens.Buses bus = new screens.Buses();
            //bus.ShowDialog();

            //Screens.DataFill.Datos_Bus bus = new Screens.DataFill.Datos_Bus();
            //bus.ShowDialog();
            
        }

        private void btnArchRF_click(object sender, RoutedEventArgs e)
        {
            Screens.Fechas_Recorrido fechas_Recorrido = new Screens.Fechas_Recorrido();
            fechas_Recorrido.ShowDialog();
        }

        private void btnArchBus_click(object sender, RoutedEventArgs e)
        {
            Screens.Registro_Buses buses = new Screens.Registro_Buses();
            buses.ShowDialog();
        }

        private void exit_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
