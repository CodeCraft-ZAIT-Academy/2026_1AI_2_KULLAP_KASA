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

namespace Nakup
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private decimal celkovaCena = 0;
        public MainWindow()
        {
            InitializeComponent();
            NovyNakup();
        }

        private void Vypis(string nazov, decimal cena)
        {
            txtblocik.Text += nazov+ "    "+ cena + "€" + System.Environment.NewLine;
            celkovaCena += cena;
            lblSuma.Content = "Celková Suma: " + celkovaCena + "  €";
        }
        private void NovyNakup()
        {
            txtblocik.Text += "--------------------------- Bločik ---------------------------" + System.Environment.NewLine;
            celkovaCena = 0;
            lblSuma.Content = "CELKOVA SUMA: " + celkovaCena + " €";
        }

        private void btnKukla_Click(object sender, RoutedEventArgs e)
        {
            Vypis("Kukla", 2);
        }

        private void btnJazda_Click(object sender, RoutedEventArgs e)
        {
            Vypis("Jazda", 15);
        }

        private void btnKofola_Click(object sender, RoutedEventArgs e)
        {
            Vypis("Kofola", 2);
        }

        private void BtnJedlo_Click(object sender, RoutedEventArgs e)
        {
            Vypis("Jedlo", 10);
        }

        private void btnMagnetka_Click(object sender, RoutedEventArgs e)
        {
            Vypis("Magnetka", 5); 
        }

        private void btn1hPrenájom_Click(object sender, RoutedEventArgs e)
        {
            Vypis("1H Prenájom", 120);
        }

        private void btnNovyNakup_Click(object sender, RoutedEventArgs e)
        {
            txtblocik.Text = "";
            lblSuma.Content = "";
            celkovaCena = 0;
            NovyNakup();


        }
    }
}