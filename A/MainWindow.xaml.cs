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

namespace A
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            this.Close();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            HeightBox.Text = "ABCDEFG";
            HeightBox.Background = Brushes.Yellow;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            double w = double.Parse(WeightBox.Text);
            double h = double.Parse(HeightBox.Text) / 100;
            double bmi = w / (h * h);

            Answer.Text = bmi.ToString();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            HeightBox.Text = HeightBar.Value.ToString();
        }

        private void HeightBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            HeightBox.Text = HeightBar.Value.ToString();

            double w = double.Parse(WeightBox.Text);
            double h = double.Parse(HeightBox.Text) / 100;
            double bmi = w / (h * h);

            Answer.Text = bmi.ToString();
        }

        private void WeighBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsInitialized)
            {
                WeightBox.Text = WeightBar.Value.ToString();

                double w = double.Parse(WeightBox.Text);
                double h = double.Parse(HeightBox.Text) / 100;
                double bmi = w / (h * h);

                Answer.Text = bmi.ToString();
            }
        }
    }
}
