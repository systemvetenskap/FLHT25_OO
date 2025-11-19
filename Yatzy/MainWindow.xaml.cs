using System.Windows;
using System.Windows.Media;

namespace Yatzy
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

        private int CountOccurences(int[] values, int search)
        {
            int count = 0;
            foreach (int value in values)
            {
                if (value == search)
                {
                    count++;
                }
            }
            return count;
        }

        // Här kodar vi saker som ska hända när någon klickar på en knapp
        private void OnCalculateClick(object sender, RoutedEventArgs e)
        {
            // vi vill summera alla värden på yatzy

            // övre halvan, 1, 2, 3, 4 ,5 och 6

            // Vad är det vi behöver för att kunna beräkna summan?

            // användaren matar in heltal 1 --> 6

            // summan av flera heltal blir alltid ett heltal

            int ones = 0, twos = 0, threes = 0, fours = 0, fives = 0, sixes = 0, total = 0;

            string message;

            // Vi vill hämta värden från användaren. Inte hårdkoda

            // vi kan inte stoppa in en sträng i ett heltal
            // låt oss konvertera --> parse

            // Det är en metod. Alla metoder har ALLTID
            // en parentes

            // ibland ska det stå något inom parentesen

            ones = int.Parse(txtOnes.Text);
            twos = int.Parse(txtTwos.Text);

            total = ones + twos + threes + fours + fives + sixes;

            message = "hej vill du spela?";
            double mean = 3.6;
            txtMessage.Text = total.ToString();

            // Uppdrag
            // en spelare får bonus i yatzy om poängsumman överstiger ett gränsvärde

            // styrande satser

            // vi gör en if-sats
            // inom parentesen ska vi ha ett så kallat logiskt uttryck
            // jo, något som kan svara på frågan med ja eller nej

            // true, false
            if (total > 10)
            {
                // problem. ingen kodare gör såhär!
                //total = total + 50;
                // Såhär gör vi när vi ökar en variabel med ett visst värde
                total += 50;
                MessageBox.Show("Grattis du fick 50p bonus");
            }
            txtMessage.Text = $"Du fick {total} poäng";

            // läxa
            // gör en eller flera if-satser som kontrollerar att den summa användaren matar in är korrekt för en viss kategori
            // gör det för ettor och tvåor

            // om värdet är ogiltigt. Visa ett felmeddelande i en MessageBox
        }

        private int CountCategory(int category)
        {
            int[] dices = { 1, 2, 5, 6, 2 };
            int count = CountOccurences(dices, category);
            return count * category;
        }
        private void btnTwos_Click(object sender, RoutedEventArgs e)
        {
            int sum = CountCategory(2);
            
            
            int twos = 0;
            int numberOfDices = 8, maxValue;
            txtMessage.Text = numberOfDices.ToString();

            MessageBox.Show("hej");

            // x = 34;
            maxValue = 2 * numberOfDices;

            maxValue = (int)2.5;

            twos = int.Parse(txtTwos.Text);

            // kontrollera värdet. Är det rimligt?

            // fem tärningar
            // alla tvåor är intressanta. Alla andra är ointressanta

            // https://www.w3schools.com/cs/cs_operators_logical.php
            if (twos > maxValue || twos < 0)
            {
                txtMessage.Foreground = Brushes.Red;
                txtMessage.FontSize = 30;
                txtMessage.Text = "Felaktig inmatning";
            }

            if (twos > 0 && twos < maxValue)
            {
                txtMessage.Text = "Allt är korrekt";
            }
            txtMessage.FontSize = 30;
            // en jämförelse gör vi med dubbla ==
            if (twos == 2 || twos == 4 || twos == 6 || twos == 8 || twos == 10)
            {
                txtMessage.Foreground = Brushes.Black;
                txtMessage.Text = "Allt är korrekt";
            }
            else if (twos == 99)
            {
                txtMessage.Text = "WOW du hittade det hemliga numret";

            }
            else
            {
                txtMessage.Foreground = Brushes.Red;
                txtMessage.Text = "Felaktig inmatning";
            }
            // Skulle läraren kunna lära sig matte?!

            //if (twos < 0)
            //{
            //    txtMessage.Foreground = Brushes.Red;
            //    txtMessage.FontSize = 30;
            //    txtMessage.Text = "Felaktig inmatning";
            //}


        }

    }
}