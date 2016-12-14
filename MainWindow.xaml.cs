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

namespace Szyfr
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string schowek = null;
        int przesuniecie = 0;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void przycKonwert_Click(object sender, RoutedEventArgs e)
        {
            schowek = Convert.ToString(Textbox.Text);
            przesuniecie = int.Parse(liczbaBox.Text);
            KonwerterCezar Szyfruj = new KonwerterCezar(schowek , przesuniecie);
            Wyswietlacz.Content = "Zaszyfrowany tekst: " + Szyfruj.Konwersja();  //- wyswietlanie
        }

    }
}
