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

namespace FL1
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
            // F5 = kör programmet
            // F7 = gå till code behind

            // I den här "låda" hamnar vi om vi klickar på knappen
            // En låda = { } Ett kodblock

            // varje kodrad, eller statement, måste avslutas med ett semikolon

            // Nu vill vi skriva "Hello World"
            // Vi bygger en MessageBox
            MessageBox.Show("Hello World, idag var det halt");

            // Eftersom vår messagebox vill ha en text måste vi skriva orden inom "

            btnOk.Content = "Hej";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("EN annan låda, eller box, eller block");
        }
    }
}