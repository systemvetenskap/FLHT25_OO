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

namespace FL2
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

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            // vi gör en variabel
            // Den här variabeln är av datatypen string som har en text
            // en text är egentligen en sammansättning av olika tecken
            string name = "df980q345809 pufvjkl";
            name = "7";

            // En variabel kan byta värde. Ersättas med ett nytt
            name = "Erik";
            
            // hämta värdet från gränssnittet
            name = txtName.Text;


            txtName.FontSize = 50;
            txtName.Height = 95;
            txtName.Width = 200;
            // Mål:
            // Hej <namnet>, hoppas du mår bra!
           
            // För att lyckas måste vi göra en stränginterpolation
            string message = $"Hej {name}, hoppas du mår bra!";

            // Kan jag slå samman strängar också med plus + ?

            message = "Solen skiner på dig " + name + " och även på alla andra. Men namnet" + name + "var snyggt";

            message = $"Solen skiner på {name} och även på andra";
            // MessageBox.Show(message);

            // tilldela värde till gränssnittet
            txtMessage.Text = message;
            // Clean code
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(txtName.Text);
        }
    }
}