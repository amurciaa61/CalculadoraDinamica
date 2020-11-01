using System.Windows;
using System.Windows.Controls;

namespace CalculadoraDinamica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string textoMostrar;
        public MainWindow()
        {
            InitializeComponent();
            textoMostrar = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string valor = (sender as Button).Tag.ToString();
            textoMostrar += valor;
            valorTextBlock.Text = textoMostrar;
        }
    }
}
