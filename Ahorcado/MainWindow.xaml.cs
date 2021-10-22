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

namespace Ahorcado
{
    public partial class MainWindow : Window
    {
        string[] palabras = {"PALANCA", "DESTORNILLADOR", "TABERNA", "PENTAGONO", "PATO", "LARINGE", "CABEZA", "PELICANO", "TACON", "BOTE", "LIENZO", "CUADRADO", "PELOTA", "CANASTA", "PROGRAMA", "CODIGO", "LAMPARA", "PERSIANA", "LOCO", "CARAVANA"};

        public MainWindow()
        {
            InitializeComponent();

            AsignarPalabra();

            for (int i = 0; i < 27; i++) {
                Button letra = new Button
                {
                    Content = i.ToString(),
                    Style = (Style)this.Resources["BotonLetra"]
                };
                LetrasWrapPanel.Children.Add(letra);
                letra.Click += Letra_Click;
            }
        }

        public int GeneraRandom()
        {
            Random ran = new Random();
            int numeroRandom = ran.Next(0, 20);
            return numeroRandom;
        }

        public void AsignarPalabra()
        {
            PalabraTextBlock.Text = palabras[GeneraRandom()];
        }

        private void NuevaPartidaButton_Click(object sender, RoutedEventArgs e)
        {
            PalabraTextBlock.Text = palabras[GeneraRandom()];
        }

        private void Letra_Click(object sender, RoutedEventArgs e)
        {
            Button boton = (Button) sender;

            boton.IsEnabled = false;
        }
    }
}
