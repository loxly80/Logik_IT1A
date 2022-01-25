using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Logik_IT1A
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

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Kruh_0_0.Fill.ToString()== "#FFF7F7F7")
            {
                Kruh_0_0.Fill = Brushes.Red;
            }
            else if (Kruh_0_0.Fill.ToString() == Brushes.Red.ToString())
            {
                Kruh_0_0.Fill = Brushes.Green;
            }
            else if (Kruh_0_0.Fill.ToString() == Brushes.Green.ToString())
            {
                Kruh_0_0.Fill = Brushes.Blue;
            }
            else if (Kruh_0_0.Fill.ToString() == Brushes.Blue.ToString())
            {
                Kruh_0_0.Fill = Brushes.Yellow;
            }
            else if (Kruh_0_0.Fill.ToString() == Brushes.Yellow.ToString())
            {
                Kruh_0_0.Fill = Brushes.Orange;
            }
            else if (Kruh_0_0.Fill.ToString() == Brushes.Orange.ToString())
            {
                Kruh_0_0.Fill = Brushes.Purple;
            }
            else
            {
                Kruh_0_0.Fill = Brushes.Red;
            }
        }
    }
}
