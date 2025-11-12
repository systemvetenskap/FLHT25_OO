using System.Windows;

namespace FL5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // detta är en så kallad field, fält
        // även kallat instansvariabel
        int _speed;

        // Vi skapar en slumpgenerator
        Random _random = new Random();

        // Detta är en "metod" som körs en och endast en gång
        // det vill säga när programmet startar!

        // det riktiga namnet är konstruktor
        public MainWindow()
        {
            InitializeComponent();

            // ge vår instansvariabel ett startvärde

            // om sommar. Högre hastighet
            int currentMonth = 5;

            if (currentMonth >= 10)
            {
                _speed = 70;
            }
            else
            {
                _speed = 90;
            }

            // vi vill slumpa en hastighet
            _speed = _random.Next(20, 91); // hastighet mellan 20 och 90 km i timmen

        }

        private void OnIncreaseClick(object sender, RoutedEventArgs e)
        {

            // öka
            _speed += 5;

            // vill vi enbart öka med ett?
            //_speed++;

        }

        private void OnDecreaseClick(object sender, RoutedEventArgs e)
        {

            _speed -= 5;

















            /*
            int currentSpeed = 125, speedLimit=70;

            bool looseLicence = false;
            if (currentSpeed > speedLimit)
            {
                // böter!!

                // om jag kör fortare än 30 km för mycket blir jag av med mitt körkort
                looseLicence = true;
                int test = 123;
                if (currentSpeed >= speedLimit + 30 )
                {
                    // du förlorar även ditt körkort

                    test += 22;
                }
                // här är den utanför sitt scope
                test = 11;
            }

            //Här är looseLicense utanför sitt scope
            if (looseLicence)
            {

            }
           
            */
        }

        private void OnShowSpeedClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_speed.ToString());

        }
    }
}