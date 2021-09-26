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

namespace _2._1.AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rn = new Random();
        int numeroAleatorio;


        public MainWindow()
        {
            InitializeComponent();
            numeroAleatorio = rn.Next(0, 101);
        }

        private void ButtonComprobar_Click(object sender, RoutedEventArgs e)
        {
            if (numeroAleatorio.ToString() == numeroTextBox.Text)
                ResultadoTextBlock.Text = "¡Has acertado!";
            else
            {
                if (numeroAleatorio < int.Parse(numeroTextBox.Text))
                    ResultadoTextBlock.Text = "Te has pasado";
                else
                    ResultadoTextBlock.Text = "Te has quedado corto";
            }
        }
        private void ButtonReiniciar_Click(object sender, RoutedEventArgs e)
        {
            numeroAleatorio = rn.Next(0, 101);
            ResultadoTextBlock.Text = "";
            numeroTextBox.Text = "";
        }
    }
}
