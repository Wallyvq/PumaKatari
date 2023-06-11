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
    /// Lógica de interacción para Registro_Empleados.xaml
    /// </summary>
    public partial class Registro_Empleados : Window
    {
        public ArchEmpleado regEmp = new ArchEmpleado("RegistroEmpleados.dat");
        public Registro_Empleados()
        {
            InitializeComponent();
            ActualizarDatos();
        }

        private void btnCrearRegEmp_Click(object sender, RoutedEventArgs e)
        {
            regEmp.CrearRegEmpl();
            MessageBox.Show("Nuevo Registro De Empleados Creado");
        }

        private void btnAdicionarEmp_Click(object sender, RoutedEventArgs e)
        {
            DataFill.Datos_Empleado datEmp = new DataFill.Datos_Empleado();
            datEmp.ShowDialog();
            ActualizarDatos();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ActualizarDatos()
        {
            List<Empleado> listEmpleados = new List<Empleado>();
            Stream file = File.Open("RegistroEmpleados.dat", FileMode.OpenOrCreate);
            BinaryReader read = new BinaryReader(file);
            try
            {
                while (true)
                {
                    Empleado emp = new Empleado();
                    emp.RdEmpleado(read);
                    listEmpleados.Add(emp);
                }
            }
            catch (Exception) { Console.WriteLine("Fin Actualizacion Datos"); }
            finally { file.Close(); }

            dgEmpelados.ItemsSource = listEmpleados;
        }
    }
}
