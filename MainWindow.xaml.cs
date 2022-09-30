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

namespace Tema2_Imagen
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

        private void radioButtonAlta_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Opacity = 1;
        }

        private void radioButtonMedia_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Opacity = 0.66;
        }

        private void radioButtonBaja_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Opacity = 0.33;
        }

        private void buttonRelleno_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.Fill;
        }

        private void buttonUniforme_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.Uniform;
        }

        private void buttonRellenoUniforme_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.UniformToFill;
        }

        private void buttonSinAjuste_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.None;
        }
    }
}
