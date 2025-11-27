using System.Diagnostics;
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

namespace FL_figurer
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

            //// skapa ett objekt av typen rectangle
            //// synonymt med skapa en instans av rectangle
            //Rectangle rectangle = new();
            //rectangle.Height = 12;
            //rectangle.Width = 4;

            //Rectangle rectangle2 = new();
            //rectangle2.Height = 12;


            //Triangle triangle = new();
            //triangle.BaseLength = 12;
            //triangle.Height = 4;

            //double area = rectangle.GetArea();
            //double area2 = rectangle2.GetArea();
            //double area3 = triangle.GetArea();




        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Rectangle rectangle = new(width: 4, height: 12);
            Triangle triangle = new(length: 3, height: 11);
            Square square = new Square(side: 5);

            Shape[] myShapes = new Shape[4];
            myShapes[0] = rectangle;

            // Vi vill ha en lista!!!!!!
            List<Shape> shapes = new();
            shapes.Add(rectangle);
            shapes.Add(triangle);
            shapes.Add(square);

            lstShapes.ItemsSource = shapes;


            double area = 0;


            // lista = loop BFF
            foreach (Shape shape in shapes)
            {
                area += shape.GetArea();
            }
        }
    }
}