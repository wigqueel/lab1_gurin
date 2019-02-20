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

namespace Laba1_Gurin
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string text = DatePicker1.SelectedDate.GetType().ToString();

            TextBlock1.Text = text;
        }
        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {

            string text = DatePicker1.SelectedDate.ToString();
            TextBlock1.Text = text;
        }
    }
}
