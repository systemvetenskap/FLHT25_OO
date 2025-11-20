using System.Windows;

namespace FL_kassa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double _totalSumma = 0;
        int _antalVaror = 0;

        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Om vi köper flera varor ger vi rabatt
        /// </summary>
        /// <returns>Rabattens storlek</returns>
        private double RabattAntalVaror()
        {
            double rabatt = 0;
            const int LowerLimit = 5;
            const int UpperLimit = 10;

            if (_antalVaror > LowerLimit & _antalVaror < UpperLimit)
            {
                rabatt = _totalSumma * 0.1;
            }
            else if (_antalVaror >= 10)
            {
                rabatt = _totalSumma * 0.2;
            }

            return rabatt;

        }
       /// <summary>
       /// Vi ger rabatt utifrån kriterier...
       /// </summary>
       /// <returns>rabattens storlek</returns>
        private double RabattTotalsumma()
        {
            double rabatt = 0;
            if (_totalSumma > 500 && _totalSumma < 1000)
            {
                rabatt = _totalSumma * 0.03;
            }
            else if (_totalSumma >= 1000 && _totalSumma < 2000)
            {
                rabatt = _totalSumma * 0.1;
            }
            else if (_totalSumma >= 2000)
            {
                rabatt = _totalSumma * 0.2;
            }
            return rabatt;
        }

        private int CalculateWaitingTime( int que)
        {
            return 0;
        }

        private double TotalRabatt()
        {
            double rabatt = 0;
            rabatt = RabattAntalVaror();
            rabatt += RabattTotalsumma();
            return rabatt;
        }
        private void btnSumma_Click(object sender, RoutedEventArgs e)
        {

            // hämta in summan från gränssnittet
            double pris = double.Parse(txtPris.Text);
            double rabatt = 0;

            // öka antalet köpta varor
            _antalVaror++;
            // öka totalsumman med priset på den scannade varan
            _totalSumma += pris;

           

            _totalSumma -= TotalRabatt();


            txtTotal.Text = _totalSumma.ToString();
        }
    }
}