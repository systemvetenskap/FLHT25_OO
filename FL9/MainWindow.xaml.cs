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

namespace FL9
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
        public bool CanRideOnNextRound(int passengersInQue)
        {
            bool canRide = false;
            int numberOfaWaggons = 24, seatsPerWaggon = 2;

            canRide = passengersInQue +1 <= numberOfaWaggons * seatsPerWaggon; 
            return canRide;
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            int numberOfPassenger = 12;

            double balanceWeight = numberOfPassenger % 2;
            // Vi introducerar modulus = %

            // modulus kan du använda för att ta reda på om något
            // tal är jämnt delbart, eller om du vill veta decimalerna

            if (numberOfPassenger % 2 == 0)
            {
                MessageBox.Show("Karusellen är i balans");
            }
            else
            {
                MessageBox.Show("Karusellen är i obalans");

            }




        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // tilldela vår variabel ett värde
            int passengers = 47;
            bool canRideNow;
            canRideNow = CanRideOnNextRound(passengers);
            if (canRideNow)
            {
                MessageBox.Show("jag får åka");
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            // EN sträng är en uppsättning tecken
            // det betyder att en sträng egenligen är en array of chars

            // char = character = bokstav eller tecken
            // H20
            string test = "The quick brown fox jumps over the lazy dog";

            // [E] [r] [i] [k];
            foreach (char sign in test)
            {
                if (char.IsDigit(sign))
                {
                    int value = (int)char.GetNumericValue(sign);
                }
            }
            string sentence = "The quick brown b fox jumps over the lazy dog";
            char[] signs = { 'a', 'b', 'c', 'd','e', 'f','g', 'h','i', 'j' };
            bool letterIsFound = ContainsLetter(sentence, signs);
        }
        private bool ContainsLetter(string sentence, char[] letters)
        {
            int counter = 0;
            foreach (char letter in letters)
            {
                foreach (char sign in sentence)
                {
                    if (sign == letter)
                    {
                        counter++;
                        break;
                    }
                    
                }
            }
            return counter == letters.Length;

            // contiue och break!
        }
    }
}