using System.Printing;
using System.Windows;

namespace FL10
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int[] numbers = { 10, 23, 232, 2, 10 };

            int searchValue = 10;

            //if (ContainsValue(numbers, searchValue))
            //{
            //    MessageBox.Show("Ja, talet finns i listan");
            //}
            //else
            //{
            //    MessageBox.Show("Nej, talet finns inte i listan");

            //}
            string text = "Erik är idag och föreläser om metoder";
            string sentence = "The quick brown fox jumps over the lazy dog";
            string letters = "abcdefghijk*";

          

            foreach (char letter in letters)
            {
                bool result = ContainsValue(sentence, letter);
                if (result == false)
                {
                    // den finns inte
                }
            }

            // låt oss räkna
            int count = 0;

            count = CountOccurences(numbers, searchValue);

            string[] fruits = { "banan", "melon", "kiwi", "äpple" };
            string[] favorites = { "2citron", "k1wi", "äpple" };
            int total = 0;
            foreach (string fruit in favorites)
            {
               total += ExtractNumberFromWord(fruit);

            }



            bool partyOn = true;
            foreach (string fruit in favorites)
            {
                int counts = CountOccurences(fruits, fruit);

                if (!ContainsValue(fruits, fruit))
                {
                    partyOn = false;
                    break;
                }

            }
            if (!partyOn)
            {
                    MessageBox.Show("rackarns, vi måste handla");
            }
            
        }
        private int ExtractNumberFromWord(string word)
        {
            foreach (char sign in word)
            {
                if (char.IsDigit(sign))
                {
                    return (int)char.GetNumericValue(sign);
                }
            }
            return 0;
        }
        private bool ContainsValue(int[] values, int search)
        {
            foreach (int value in values)
            {
                if (value == search)
                {
                    return true;
                }
            }
            return false;
        }


        private bool ContainsValue(string senctence, char search)
        {
            foreach (char letter in senctence)
            {
                if (char.ToUpper(letter) == char.ToUpper(search))
                {
                    return true;
                }
            }
            return false;
        }

        private bool ContainsValue(string[] words, string search)
        {
            foreach (string word in words)
            {
                if (word == search)
                {
                    return true;
                }
            }
            return false;
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

        private int CountOccurences(string[] values, string search)
        {
            int count = 0;
            foreach (string value in values)
            {
                if (value == search)
                {
                    count++;
                }
            }
            return count;
        }

        private int CountOccurences(string senctence, char letter)
        {
            int count = 0;
            foreach (char sign in senctence)
            {
                if (sign == letter)
                {
                    count++;
                }
            }
            return count;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string sentence = "hej jag är en glad prick";
            // mål 
            string[] words = { "hej", "jag", "är" };
            words = SplitSentence(sentence);
        }

        private string[] SplitSentence(string sentence)
        {
            string[] words = new string[sentence.Length];
            int index = 0;
            string word = "";
            // när vi behöver index använd for
            for (int i = 0; i < sentence.Length; i++)
            {
                char sign = sentence[i];
                if (char.IsWhiteSpace(sign))
                {
                    words[index] = word;
                    word = string.Empty;
                    index++;
                }
                else
                {
                    word += sign;
                }
            }
            words[index] = word;
            return words;
        }
    }
}