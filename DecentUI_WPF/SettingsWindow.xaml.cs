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
using System.Windows.Shapes;

namespace DecentUI_WPF
{
    /// <summary>
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MoveSliders();

        }

        private void redSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var MW = Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow;

            MW.reds = (byte)redSlider.Value;

            redLabel.Content = MW.reds;

            MW.Background = new SolidColorBrush(Color.FromArgb(MW.transperecys, MW.reds, MW.greens, MW.blues)); 
        }

        private void greenSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var MW = Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow;

            MW.greens = (byte)greenSlider.Value;

            greenLabel.Content = MW.greens;

            MW.Background = new SolidColorBrush(Color.FromArgb(MW.transperecys, MW.reds, MW.greens, MW.blues));
        }

        private void blueSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var MW = Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow;

            MW.blues = (byte)blueSlider.Value;

            blueLabel.Content = MW.blues;

            MW.Background = new SolidColorBrush(Color.FromArgb(MW.transperecys, MW.reds, MW.greens, MW.blues));
        }

        private void transperencySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var MW = Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow;

            MW.transperecys = (byte)transperencySlider.Value;

            transperencyLabel.Text = Convert.ToString(MW.transperecys); 

            MW.Background = new SolidColorBrush(Color.FromArgb(MW.transperecys, MW.reds, MW.greens, MW.blues));
        }

        private void transperencyLabel_TextChanged(object sender, TextChangedEventArgs e)
        {
            var MW = Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow;

            MW.transperecys = Convert.ToByte(transperencyLabel.Text);

            MW.Background = new SolidColorBrush(Color.FromArgb(MW.transperecys, MW.reds, MW.greens, MW.blues));
        }

        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void MoveSliders()
        {
            var MW = Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow;          

            transperencySlider.Value = (int)MW.transperecys;
            redSlider.Value = (int)MW.reds;
            greenSlider.Value = (int)MW.greens;
            blueSlider.Value = (int)MW.blues;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //MainWindow MW = new MainWindow();
            double newColor = Math.Round(transperencySlider.Value,0);
            int newNumber = (int)newColor;
            //
            // MW.Background = new SolidColorBrush(Color.FromArgb((byte)newNumber, 0xFF, 0, 0));
            var targetWindow = Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow;
            targetWindow.Background = new SolidColorBrush(Color.FromArgb((byte)newNumber, 0xFF, 0, 0));
            //labelonhere.Content = (byte)newNumber;
            
            
        }

    }
}
