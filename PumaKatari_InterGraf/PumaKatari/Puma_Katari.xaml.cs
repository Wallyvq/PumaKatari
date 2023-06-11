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

namespace PumaKatari {
    public partial class Puma_Katari : Window {
        public Puma_Katari() { 
            InitializeComponent(); 
        }
        private void btnRegRutas_Click(object sender, RoutedEventArgs e) {
            Screens.Registro_Rutas regRutas = new Screens.Registro_Rutas();
            regRutas.Show();
        }
        private void btnRegBuses_Click(object sender, RoutedEventArgs e) {
            Screens.Registro_Buses regBuses = new Screens.Registro_Buses();
            regBuses.ShowDialog();
        }
        private void btnRegEmpleados_Click(object sender, RoutedEventArgs e) {
            Screens.Registro_Empleados regEmpleados = new Screens.Registro_Empleados();
            regEmpleados.ShowDialog();
        }
        private void btnRegFechas_Click(object sender, RoutedEventArgs e) {
            Screens.Fechas_Recorrido regFechas = new Screens.Fechas_Recorrido();
            regFechas.ShowDialog();
        }
        private void btnTrayectoX_Click(object sender, RoutedEventArgs e) {
            Screens.TrayectoRuta trayectoRuta = new Screens.TrayectoRuta();
            trayectoRuta.ShowDialog();
        }
        private void btnRutaBuses_Click(object sender, RoutedEventArgs e) {
            Screens.BusesRuta busesRuta = new Screens.BusesRuta();
            busesRuta.ShowDialog();
        }
        private void btnListIngresos_Click(object sender, RoutedEventArgs e) {
            Screens.IngresosJornada listIngresos = new Screens.IngresosJornada();
            listIngresos.ShowDialog();
        }
        private void btnReportePasajeros_Click(object sender, RoutedEventArgs e) {
            Screens.ReporteNroPasajeros reporteNroPj = new Screens.ReporteNroPasajeros();
            reporteNroPj.ShowDialog();
        }
        private void Close_Click(object sender, RoutedEventArgs e) { 
            this.Close(); 
        }
    }
}
