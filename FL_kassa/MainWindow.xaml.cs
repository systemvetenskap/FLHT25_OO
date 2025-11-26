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

            /* Egenskaper som beskriver en vara
             * pris
             * pris per liter
             * pris per meter
             * pris per enhet
             * namn
             * varutyp
             * rabatt
             */
            // pris

            // datatyp namn och eventuellt startvärde
            string name = "Erik";
            //Product product = new Product("Test");

            // Vi tilldelar ett värde till egenskapen  Country
            // för detta utnyttjar vi vår {set;}
            //product.Country = "Sverige";
            

            // hämta värdet från vår {get};
            //MessageBox.Show($"Den här varan kommer från {product.Country}");

            //if (product.IsEcological)
            //{
            //    MessageBox.Show($"Den här varan kommer är ekologisk");
            //}


            //if (product.IsEcological && product.Country == "Sverige")
            //{

            //}
            Random random = new Random();




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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product(123, "Apelsin");

            // Nu har jag skapat ett objekt, product

            // Men den har inga egenskaper satta

            // Variant 1
            // använd punktnotation
           // product.Price = 2.50;
            product.Weight = 200;
            product.IsEcological = false;
            product.Country = "Belgien";

            product.Country="asfsalöjkdfjaslökdjas";

            product.SetPrice(1234);
            product.SetPrice(12);
            product.SetPrice(1322);
            product.SetPrice(88);
            product.SetPrice(823);
            product.SetPrice(2348);
            product.SetPrice(8448);
            product.SetPrice(84368);

            // sätt två. Object Initializer
            Product product2 = new Product(1223, "Älgkött")
            {
                Country = "Norge",
                IsEcological = true,
                //Price = 100
            };
            product2.SetPrice(500);
            // variant tre
            // använd konstruktor
            string name = "Gurka";
            Product product3 = new Product(234, name);
            product3.SetPrice(-123123);
            Product product4 = new Product(134, "Goda grytan");

        }
    }
}