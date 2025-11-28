using System.Windows;
using System.Windows.Controls;

namespace FL_egg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Farm _farm = new();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            _farm.BuyEggs(120);

            // Visa alla fertila ägg
            List<Egg> fertileEggs = _farm.GetAllEggs();
            lstEggs.ItemsSource = null;
            lstEggs.ItemsSource = fertileEggs;
        }

        private void lstEggs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Egg? selectedEgg = lstEggs.SelectedItem as Egg;

            if (selectedEgg is null)
            {
                return;
            }
            Chicken? chicken = _farm.HatchEgg(selectedEgg);
           //selectedEgg.Hatch();
            if (chicken is null)
            {
                MessageBox.Show("Det blev ingen kyckling");
            }
            else
            {
                MessageBox.Show($"Kycklingen {chicken.Name} med id {chicken.Id} har fötts");
            }
        }
    }
}