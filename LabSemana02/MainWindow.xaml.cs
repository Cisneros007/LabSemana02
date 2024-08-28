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

namespace LabSemana02
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ingresos_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Salida_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1(); 
            window1.Show();
        }
        private void Conductores_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Transportistas_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Camiones_Click(object sender, RoutedEventArgs e)
        {
            RegistroCaminones camiones = new RegistroCaminones();
            camiones.Show();
        }

        private void Productos_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Cargas_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void IngresosReporte_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void SalidasReporte_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ListadeCamiones_Click(object sender, RoutedEventArgs e)
        {
            Lista_Camiones camioneslist = new Lista_Camiones();
            camioneslist.Show();
        }

        private void ListadeSalida_Click(object sender, RoutedEventArgs e)
        {
            ListaSalida salidalist = new ListaSalida();
            salidalist.Show();
        }
    }
}
