using System.Collections.Generic;
using System.Windows;

namespace LabSemana02
{
    /// <summary>
    /// Lógica de interacción para Lista_Camiones.xaml
    /// </summary>
    public partial class Lista_Camiones : Window
    {
        public Lista_Camiones()
        {
            InitializeComponent();

            // Crear una lista de camiones
            List<Camiones> camionesList = new List<Camiones>
            {
                new Camiones() { Peso_maximo = 15000, Peso_minimo = 5000, Placa = "ABC123" },
                new Camiones() { Peso_maximo = 20000, Peso_minimo = 8000, Placa = "XYZ789" },
                new Camiones() { Peso_maximo = 18000, Peso_minimo = 6000, Placa = "LMN456" }
            };

            // Asignar la lista al DataGrid
            dgCamiones.ItemsSource = camionesList;
        }
    }
}
