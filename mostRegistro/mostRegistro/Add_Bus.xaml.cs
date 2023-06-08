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
using System.IO;
namespace mostRegistro
{
    /// <summary>
    /// Lógica de interacción para Add_Bus.xaml
    /// </summary>
    public partial class Add_Bus : Window
    {
        public Add_Bus()
        {
            InitializeComponent();
        }
        private void btnAddBus(object sender, RoutedEventArgs e)
        {
            string placa = txtPlaca.Text;
            string idBus = txtIdBus.Text;
            string idConductor = txtIdConductor.Text;
            string idApoyo = txtIdApoyo.Text;
            string nomRuta = txtNomRuta.Text;
            string nroPasajeros = txtNroPasajeros.Text;
            ArchBus regBus = new ArchBus("RegBuses.dat");
            regBus.AdiBus(placa,idBus,idConductor,idApoyo,nomRuta,nroPasajeros);
            this.Close();
        }

    }
}
