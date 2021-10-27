using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Artikal> Artikli { get; set; } = new();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Klik(object sender, RoutedEventArgs e)
        {
            Arti A = new();
            A.Owner = this;
            A.ShowDialog();

        }
    }

    public class Artikal
    {
        public string Sifra { get; set; } = "Nedzo";
        public string Naziv { get; set; } = "Vezba";
        public int Kolicina { get; set; } = 100;
        public decimal UlCena { get; set; } = 100;
        public decimal Marza { get; set; } =(decimal) 0.3;
        public decimal StopaPoreza { get; set; } = (decimal)0.1;
        public decimal IzlaznaCena { get; set; } = 143; 
        public decimal IzlaznaCenaSaPorezom { get; set; }
    }
}
