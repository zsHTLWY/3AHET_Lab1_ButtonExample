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

namespace PersonalButtons
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Background = Brushes.White;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.DarkBlue;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.DeepPink;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Purple;
        }
    }
}
