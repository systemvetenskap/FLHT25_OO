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

namespace ColorSwapper
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

        private void OnRedClick(object sender, RoutedEventArgs e)
        {
            // objekt   egenskap  = tilldelas värde
            colorBox.Background = Brushes.Red;
            colorBox.Width *= 0.5;
        }

        private void OnGreenClick(object sender, RoutedEventArgs e)
        {

            /* I C# har vi användning av datatyper
             * en datatyp är till exempel ett heltal eller ett decimaltal
             */
            //https://www.w3schools.com/cs/cs_data_types.php

            // uppdrag. Vi vill skapa en låda som ska innhålla värdet 
            // för bredden och höjden av vår colorBox

            // Variabel
            // Datatypen   namnet och eventuellt vilket värde den ska ha

            // Vi deklarerar en variabel och tilldelar värde
            double widthAndHeight = 300;

            colorBox.Background = Brushes.Green;
            colorBox.Width = widthAndHeight;
            colorBox.Height = widthAndHeight;

        }
    }
}