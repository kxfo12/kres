using System.Diagnostics.Metrics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kres
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Kres> Kresy = new List<Kres>();
        public int counter = 0;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Kres overthrax = new Kres("Ovathrax", "The entity known as the Threnodian of War. Last seen in the Heart of the Crownless.", 432897, 2105);
            Kres leviathan = new Kres("Leviathan", "Threnodian in Rinascita.", 249956, 2233);
            Kresy.Add(overthrax);
            Kresy.Add(leviathan);
            zmienDane();
        }

        private void Poprzedni(object sender, RoutedEventArgs e)
        {
            if (counter == 0)
            {
                counter = Kresy.Count;
            }
            else
            {
                counter--;
            }
            zmienDane();
        }
        private void Nastepny(object sender, RoutedEventArgs e)
        {
            if (counter == Kresy.Count)
            {
                counter = 0;
            }
            else
            {
                counter++;
            }
            zmienDane();
        }
        public void zmienDane()
        {
            nazwa.Text = Kresy.ElementAt(counter).nazwa;
            opis.Text = Kresy.ElementAt(counter).opis;
            liczbaOfiar.Text = Kresy.ElementAt(counter).liczbaOfiar.ToString();
            rok.Text = Kresy.ElementAt(counter).rok.ToString();
        }
    }
}