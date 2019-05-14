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

namespace HeadsOrTails
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

        private void Heads_Button_Click(object sender, RoutedEventArgs e)
        {
            SetImage("Images/Heads.bmp");
        }

        private void Tails_Button_Click(object sender, RoutedEventArgs e)
        {
            SetImage("Images/Tails.bmp");
        }

        private void SetImage(String path)
        {
            Image coinImage = new Image();
            coinImage.Source = new BitmapImage(new Uri(path, UriKind.Relative));
            ImageBox.Content = coinImage;
        }
    }
}
