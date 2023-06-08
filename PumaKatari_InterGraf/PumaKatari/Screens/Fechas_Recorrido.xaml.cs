using PumaKatariConsola;
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
using System.Windows.Shapes;

namespace PumaKatari.Screens
{
    /// <summary>
    /// Lógica de interacción para Fechas_Recorrido.xaml
    /// </summary>
    public partial class Fechas_Recorrido : Window
    {
        public ArchFecha fechaRecorrida = new ArchFecha("FechaRecorrido.dat");
        public Fechas_Recorrido()
        {
            InitializeComponent();
        }
        private void btnCrearFR_Click(object sender, RoutedEventArgs e)
        {
            fechaRecorrida.CrearRegFecha();
            MessageBox.Show("Nuevo Archivo Fecha Recorrido Creada");
        }
        private void btnAdicionarFR_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMostrarFR_Click(object sender, RoutedEventArgs e)
        {

        }

        

        
    }
}
