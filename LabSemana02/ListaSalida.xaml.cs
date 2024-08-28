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

namespace LabSemana02
{
    public partial class ListaSalida : Window
    {
        public ListaSalida()
        {
            InitializeComponent();

            // Crear una lista de ListaSalida
            List<ListaSalidaItem> listaSalidaList = new List<ListaSalidaItem>
            {
                new ListaSalidaItem
                {
                    Fecha = "2024-08-27",
                    Peso = 12000,
                    Tipo_de_Auto = "Camión",
                    Nombre_Transportista = "Juan Pérez",
                    PesoIngreso = 15000,
                    PesoSalida = 12000,
                    Fecha_Y_Hora = "2024-08-27 14:30"
                },
                new ListaSalidaItem
                {
                    Fecha = "2024-08-27",
                    Peso = 9500,
                    Tipo_de_Auto = "Camión",
                    Nombre_Transportista = "María López",
                    PesoIngreso = 11000,
                    PesoSalida = 9500,
                    Fecha_Y_Hora = "2024-08-27 15:00"
                },
                new ListaSalidaItem
                {
                    Fecha = "2024-08-27",
                    Peso = 14000,
                    Tipo_de_Auto = "Camión",
                    Nombre_Transportista = "Carlos Sánchez",
                    PesoIngreso = 15000,
                    PesoSalida = 14000,
                    Fecha_Y_Hora = "2024-08-27 16:00"
                }
            };

            // Asignar la lista al DataGrid
            dgListaSalida.ItemsSource = listaSalidaList;
        }
    }

    // Clase de datos para la lista
    public class ListaSalidaItem
    {
        public string Fecha { get; set; }
        public int Peso { get; set; }
        public string Tipo_de_Auto { get; set; }
        public string Nombre_Transportista { get; set; }
        public int PesoIngreso { get; set; }
        public int PesoSalida { get; set; }
        public string Fecha_Y_Hora { get; set; }
    }
}