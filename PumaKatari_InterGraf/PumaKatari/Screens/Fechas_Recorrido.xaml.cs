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
    /// <summary>
    /// Lógica de interacción para Fechas_Recorrido.xaml
    /// </summary>
    public partial class Fechas_Recorrido : Window
    {
        public ArchFecha fechaRecorrida = new ArchFecha("RegistroFechas.dat");
        public Fechas_Recorrido()
        {
            InitializeComponent();
            ActualizarLista();
        }
        private void btnCrearFR_Click(object sender, RoutedEventArgs e)
        {
            fechaRecorrida.CrearRegFecha();
            MessageBox.Show("Nuevo Archivo Fecha Recorrido Creada");
        }
        private void btnAdicionarFR_Click(object sender, RoutedEventArgs e)
        {
            DataFill.Fecha_Recorridos fechaRecorridos = new DataFill.Fecha_Recorridos();
            fechaRecorridos.ShowDialog();
            ActualizarLista();
        }
        private void ActualizarLista()
        {
            Stream file = File.Open("RegistroFechas.dat", FileMode.OpenOrCreate);
            BinaryReader read = new BinaryReader(file);
            List<Fecha> fechaList = new List<Fecha>();
            try
            {
                while (true)
                {
                    Fecha fecha = new Fecha();
                    fecha.RdFecha(read);
                    fechaList.Add(fecha);
                }
            }
            catch (Exception) { Console.WriteLine("-----"); }
            finally { file.Close(); }
            dgFechaRecorrido.ItemsSource = fechaList;
        }
        private void btnSalirFR_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
