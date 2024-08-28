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
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
      
        public Window1()
        {
            InitializeComponent();
        }

        private void ButtonAceptar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Textonumeros_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            // Verifica si el carácter ingresado es un número
            e.Handled = !IsTextAllowed(e.Text);
        }

        private static bool IsTextAllowed(string text)
        {
            // Permite solo números
            return text.All(char.IsDigit);
        }
    }
}
