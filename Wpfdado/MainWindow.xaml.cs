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

namespace Wpfdado
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random_generator = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Estrazione_Click(object sender, RoutedEventArgs e)
        {
            int crediti = int.Parse(txtCrediti.Text);
            if (crediti <= 0)
                MessageBox.Show("Inserisci un numero di crediti positivo");
            int RandomNumber = random_generator.Next(1, 7);
            int n = int.Parse(txtNum.Text);
            if (n >= 7 || n <= 0)
                MessageBox.Show("Numero non valido!");
            bool risposta;

            if (n == RandomNumber)
            {
                crediti = crediti * 2;
                txtCasuale.Text = ($"Il numero uscito è {RandomNumber}. Complimenti!Hai vinto!");
                txtCrediti.Text = ($"{crediti}");
                risposta = true;
            }
            else
            {
                crediti = crediti / 2;
                txtCasuale.Text = ($"Il numero uscito è {RandomNumber}. Ritenta!");
                txtCrediti.Text = ($"{crediti}");
                risposta = false;
            }
            if (crediti <= 0)
                txtCrediti.Text = "Non puoi più giocare, hai finito i crediti";
            dado.Source = new BitmapImage(new Uri($@"dadi\dado{RandomNumber}.png", UriKind.Relative));
            numdado.Source = new BitmapImage(new Uri($@"dadi\dado{n}.png", UriKind.Relative));
            if (risposta)
                face.Source = new BitmapImage(new Uri($@"faccine\smile.png", UriKind.Relative));
            else
                face.Source = new BitmapImage(new Uri($@"faccine\sad.png", UriKind.Relative));
        }
        private void Riprova_Click(object sender, RoutedEventArgs e)
        {
            txtNum.Clear();
            txtCasuale.Clear();
            txtCrediti.Clear();
            dado.Source = null;
            numdado.Source = null;
            face.Source = null;
        }

    }
}
