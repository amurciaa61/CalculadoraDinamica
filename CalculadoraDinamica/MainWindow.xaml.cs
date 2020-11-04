using System;
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

        
            Grid rejilla = new Grid();
            RowDefinition row1 = new RowDefinition();
            RowDefinition row2 = new RowDefinition();
            RowDefinition row3 = new RowDefinition();
            ColumnDefinition col1 = new ColumnDefinition();
            ColumnDefinition col2 = new ColumnDefinition();
            ColumnDefinition col3 = new ColumnDefinition();
            rejilla.RowDefinitions.Add(row1);
            rejilla.RowDefinitions.Add(row2);
            rejilla.RowDefinitions.Add(row3);
            rejilla.ColumnDefinitions.Add(col1);
            rejilla.ColumnDefinitions.Add(col2);
            rejilla.ColumnDefinitions.Add(col3);

            int valor = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    valor++;
                    Button boton = FormaBoton(valor.ToString());
                    Grid.SetRow(boton, i);
                    Grid.SetColumn(boton, j);
                    rejilla.Children.Add(boton);
                }
            }
            Content = rejilla;
            

        }
        public static Button FormaBoton(String numero)
        {
            Button boton = new Button();
            TextBlock texto = new TextBlock();
            Viewbox vb = new Viewbox();
            texto.Text = numero;
            vb.Child = texto;
            boton.Tag = numero;
            boton.Margin = new Thickness(10, 10, 5, 0);
            return boton;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string valor = (sender as Button).Tag.ToString();
            textoMostrar += valor;
            valorTextBlock.Text = textoMostrar;
        }
    }
}
