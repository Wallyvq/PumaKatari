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

namespace PumaKatari.Screens.DataFill
{
    /// <summary>
    /// Lógica de interacción para Datos_Empleado.xaml
    /// </summary>
    public partial class Datos_Empleado : Window
    {
        public Datos_Empleado()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            string nombre = txtNombreEmp.Text;
            string edad = txtEdadEmp.Text;
            string idEmp = txtIdEmp.Text;
            string cargo = txtCargoEmp.Text;

            ArchEmpleado regEmpleado = new ArchEmpleado("RegistroEmpleados.dat");
            regEmpleado.AdiEmpleado(nombre, edad, idEmp,cargo);
            this.Close();

        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
