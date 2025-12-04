using System.Windows;

namespace MusikhjalpenTenta
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
        int _votes = 0;

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //double vote = double.Parse(txtVote.Text);
            //int voteToInteger = int.Parse(txtVote.Text);
            //MessageBox.Show($"Din röst på låt {vote} har registreats som {(int)vote}");

            //txtVote.Text = vote.ToString();
            /*
             * 
             * när jag klickar på denna knapp ska antal önskningar öka
             */
            _votes++;
        }
        private int StringToValueConverter2(string input)
        {
            string[] numberParts = input.Split(" ");

            string[] test = new string[] { "hundratjugo", "fem" };
            // https://learn.microsoft.com/en-us/dotnet/api/system.string.split?view=net-10.0
            int sum = 0;
            // Jag har nu fått mina tal i olika delar
            // leta efter alla delar
            // summera
            foreach (string part in numberParts)
            {
                int value = StringToValueConverter(part);
                if (value == 0)
                {
                    return 0;
                }
                sum += StringToValueConverter(part);
            }


            return sum;
        }
        private int StringToValueConverter(string input)
        {
            string[] numbers = new string[]
 {
         "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio", "tio",
         "elva", "tolv", "tretton", "fjorton", "femton", "sexton", "sjutton", "arton", "nitton",
         "tjugo", "tjugoett", "tjugotvå", "tjugotre", "tjugofyra", "tjugofem", "tjugosex", "tjugosju", "tjugooåtta", "tjugonio",
         "trettio", "trettioett", "trettiotvå", "trettiotre", "trettiofyra", "trettiofem", "trettiosex", "trettiosju", "trettioåtta", "trettionio",
         "fyrtio", "fyrtioett", "fyrtiotvå", "fyrtiotre", "fyrtiofyra", "fyrtiofem", "fyrtiosex", "fyrtiosju", "fyrtioåtta", "fyrtionio",
         "femtio", "femtioett", "femtiotvå", "femtiotre", "femtiofyra", "femtiofem", "femtiosex", "femtiosju", "femtioåtta", "femtionio",
         "sextio", "sextioett", "sextiotvå", "sextiotre", "sextiofyra", "sextiofem", "sextiosex", "sextiosju", "sextioåtta", "sextionio",
         "sjuttio", "sjuttioett", "sjuttiotvå", "sjuttiotre", "sjuttiofyra", "sjuttiofem", "sjuttiosex", "sjuttiosju", "sjuttioåtta", "sjuttionio",
         "åttio", "åttioett", "åttiotvå", "åttiotre", "åttiofyra", "åttiofem", "åttiosex", "åttiosju", "åttioåtta", "åttionio",
         "nittio", "nittioett", "nittiotvå", "nittiotre", "nittiofyra", "nittiofem", "nittiosex", "nittiotosju", "nittioåtta", "nittionio",
         "hundra", "hundraett", "hundratvå", "hundratre", "hundrafyra", "hundrafem", "hundrasex", "hundrasju", "hundraåtta", "hundranio", "hundratio",
         "hundraelva", "hundratolv", "hundratretton", "hundrafjorton", "hundrafemton", "hundrasexton", "hundrasjutton", "hundraarton", "hundranitton",
         "hundratjugo", "hundratjugoett", "hundratjugotvå", "hundratjugotre", "hundratjugoFyra", "hundratjugofem", "hundratjugosex", "hundratjugosju", "hundratjugoåtta", "hundratjugonio",
         "hundratrettio", "hundratrettioett", "hundratrettiotvå", "hundratrettiotre", "hundratrettiofyra", "hundratrettiofem", "hundratrettiosex", "hundratrettiosju", "hundratrettioåtta", "hundratrettionio",
         "hundrafyrtio", "hundrafyrtioett", "hundrafyrtiotvå", "hundrafyrtiotre", "hundrafyrtiofyra", "hundrafyrtiofem", "hundrafyrtiosex", "hundrafyrtiosju", "hundrafyrtioåtta", "hundrafyrtionio",
         "hundrafemtio", "hundrafemtioett", "hundrafemtiotvå", "hundrafemtiotre", "hundrafemtiofyra", "hundrafemtiofem", "hundrafemtiosex", "hundrafemtiosju", "hundrafemtioåtta", "hundrafemtionio",
         "hundrasextio", "hundrasextioett", "hundrasextiotvå", "hundrasextiotre", "hundrasextiofyra", "hundrasextiofem", "hundrasextiosex", "hundrasextiosju", "hundrasextioåtta", "hundrasextionio",
         "hundrasjuttio", "hundrasjuttioett", "hundrasjuttitvå", "hundrasjuttitre", "hundrasjuttiofyra", "hundrasjuttiofem", "hundrasjuttiosex", "hundrasjuttiosju", "hundrasjuttioåtta", "hundrasjuttionio",
         "hundraåttio", "hundraåttioett", "hundraåttiotvå", "hundraåttiotre", "hundraåttiofyra", "hundraåttiofem", "hundraåttiosex", "hundraåttiosju", "hundraåttioåtta", "hundraåttionio",
         "hundranittio", "hundranittioett", "hundranittiotvå", "hundranittiotre", "hundranittiofyra", "hundranittiofem", "hundranittiosex", "hundranittiosju", "hundranittioåtta", "hundranittionio",
         "tvåhundra", "tvåhundraett", "tvåhundratvå", "tvåhundratre", "tvåhundrafyra", "tvåhundrafem", "tvåhundrasex", "tvåhundrasju", "tvåhundraåtta", "tvåhundranio","tvåhundratio"
 };
            int[] values = new int[numbers.Length];
            for (int i = 1; i <= values.Length; i++)
            {
                // [1, 2, 3]
                values[i - 1] = i;

            }
            /*
             * Jag vill leta efter ett visst tal i en lista
             * loopar och tittar
             * om jag hittar. returnera det som ett tal
             */
            // https://www.w3schools.com/cs/cs_arrays_loop.php
            int index = 1;
           // foreach (string number in numbers)
           for(int i =0; i< numbers.Length; i++)
            {
                string number = numbers[i];
                // Undersök!
                // är det numret jag söker efter hittat?
                if (number == input)
                {
                    return i+1;
                }
                index++;
            }
            int value = 0;

            return 0;
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // här ska vi hämta antalet önskningar
            int total = _votes * 50;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //int second = StringToValueConverter("ett");             // 1
            //int first = StringToValueConverter("hundratjugofem");   // 125
            //int third = StringToValueConverter("tvåhundratio");     // 210

            //int result = StringToValueConverter2("hundratjugofem"); // 125
            int result2 = StringToValueConverter2("hundratjugo feme"); // 0
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            SongHandler songHandler = new SongHandler();

            List<Artist> artists = songHandler.GetArtists();

            string artistName = songHandler.GetArtistNameByAlbum("25"); // "Adele"
            artistName = songHandler.GetArtistNameByAlbum("Divide"); // Ed
            artistName = songHandler.GetArtistNameByAlbum("sdfg"); // ingen
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            string[] names = {
    "Brita Zackari", "Christer Lundberg", "Daniel Adams-Ray",
    "Ehsan Noroozi", "Emil Hansius", "Emma Knyckare",
    "Farah Abadi", "Felix Sandman", "Gina Dirawi",
    "Jason Diakité", "Jason Diakitée", "Kalle Zackari Wahlström",
    "Klas Eriksson", "Kodjo Akolor", "Linnea Henriksson",
    "Little Jinder", "Martina Thun", "Molly Sandén",
    "Nour El Refai", "Oscar Zia", "Sarah Dawn Finer",
    "Sofia Dalén", "Tina Mehrafzoon", "Kitty Jutbring",
    "William Spetz", "Ametist Azordegan", "Anis Don Demina",
    "Assia Dahir", "Daniel Hallberg", "Henrik Torehammar",
    "Howlin' Pelle", "Linnea Henriksson", "Linnéa Wikblad",
    "Miriam Bryant", "Petter Askergren"
};

            int count = CountNamesByStartingLetter('A', names); // 3
        }

        private int CountNamesByStartingLetter(char letter, string[] names)
        {
            List<string> searchResult = new();
            int count = 0;
            string erik = "Erik";
            // ['E', 'r', 'i', 'k']
            char first = erik[0];

            foreach (string name in names)
            {
                if (name[0] == letter)
                {
                    count++;
                    searchResult.Add(name);
                }
            }

            return count;
        }
    }
}