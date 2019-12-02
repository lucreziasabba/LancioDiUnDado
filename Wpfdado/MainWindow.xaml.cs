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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Estrazione_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(txtNum.Text);
            Random random_generator = new Random();
            int RandomNumber = random_generator.Next(1,7);
            if (n == RandomNumber)
                txtCasuale.Text = ($"Il numero uscito è {RandomNumber}. Complimenti!Hai vinto!");
            else if (n != RandomNumber)
                txtCasuale.Text = ($"Il numero uscito è {RandomNumber}. Ritenta!");
        }

        private void Riprova_Click(object sender, RoutedEventArgs e)
        {
             txtNum.Clear();
            txtCasuale.Clear();
        }
    }
}
