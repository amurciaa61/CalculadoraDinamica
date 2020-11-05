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
            // margenes para cada boton
            int[,] margen = { {10,10,5,0},  //1
                              {5,10,5,5 },  //2
                              {5,10,10,5},  //3
                              {10,5,5,5 },  //4
                              {5,5,5,5 },   //5
                              {5,5,10,5 },  //6
                              {10,5,5,10 }, //7
                              {5,5,5,10},   //8
                              {5,5,10,10 }  //9
            };
            // Construimos los 9 botones (uno a uno y posicionandolo en el Grid)
            int numeroBoton = 0;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    numeroBoton++;
                    Button boton = FormaBoton(numeroBoton.ToString(),margen[numeroBoton - 1, 0], 
                                                                     margen[numeroBoton - 1, 1], 
                                                                     margen[numeroBoton - 1, 2],
                                                                     margen[numeroBoton - 1, 3]);
                    Grid.SetRow(boton, i);
                    Grid.SetColumn(boton, j);
                    rejilla.Children.Add(boton);
                }
            }          

        }
        // Construccion del boton
        public static Button FormaBoton(String numero,int margenLeft,int margenTop,int margenRight,int margenbottom)
        {
            Button boton = new Button();
            TextBlock texto = new TextBlock();
            Viewbox vb = new Viewbox();
            texto.Text = numero;
            vb.Child = texto;
            boton.Tag = numero;
            boton.Margin = new Thickness(margenLeft, margenTop, margenRight, margenbottom);
            boton.Content = vb;
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
