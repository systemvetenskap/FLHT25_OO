using System.Windows;

namespace FL4
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
            // Poliskontroll

            int carSpeed = 90, speedLimit = 90;

            // Alla decimaler i koden måste vara punkter!
            double alcholLevel = 1, alcoholLimit = 0.2, alcoLimit2 = 1;

            bool isSober = alcholLevel < alcoholLimit;
            if (isSober != true)
            {
                // Fy, kontrollera oom jag är rattfull
            }

            // rattfylla har en gräns på 0.5
            if (!false)
            {
                // it's funny because its true
            }

            if (carSpeed != speedLimit)
            {
                // du kör antingen för fort eller för långsamt
            }

            if (carSpeed > speedLimit)
            {
                // Du kör för fort!
            }

            if (alcholLevel >= alcoholLimit )
            {
                // du är onykter!
                
                if(alcholLevel >= alcoLimit2)
                {
                    // Grov rattfylla
                }
                else
                {
                    // du kommer undan med det lägre straffet
                }
            }
            else
            {
                // bra du får köra vidare!
            }
        }
    }
}