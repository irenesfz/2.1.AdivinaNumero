using System;
using System.Windows;


namespace _2._1.AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int numeroAleatorio;
        Random rn = new Random();

        public int CreaNumeroRandom()
        {
            return rn.Next(0, 101);
        }
        public MainWindow()
        {
            InitializeComponent();
            numeroAleatorio = CreaNumeroRandom();
        }

        private void ButtonComprobar_Click(object sender, RoutedEventArgs e)
        {
            if (numeroAleatorio.ToString() == NumeroTextBox.Text)
                ResultadoTextBlock.Text = "¡Has acertado!";
            else
            {
                if (numeroAleatorio < int.Parse(NumeroTextBox.Text))
                    ResultadoTextBlock.Text = "Te has pasado";
                else
                    ResultadoTextBlock.Text = "Te has quedado corto";
            }
        }
        private void ButtonReiniciar_Click(object sender, RoutedEventArgs e)
        {
            numeroAleatorio = CreaNumeroRandom();
            ResultadoTextBlock.Text = String.Empty;
            NumeroTextBox.Clear();
        }
    }
}
