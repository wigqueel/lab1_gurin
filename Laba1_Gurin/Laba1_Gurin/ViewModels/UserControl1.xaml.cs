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

namespace Laba1_Gurin.ViewModels
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        #region Fields
        private long  nowyear = long.Parse(DateTime.Now.ToString("yyyy"));
        
        #endregion
        #region Properties
        public UserControl1()
        {
            InitializeComponent();
        }
        public long Now
        {
            get { return nowyear; }
            set
            {
                nowyear = value;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            long birthdate = long.Parse (DatePicker1.SelectedDate.Value.ToString("yyyy"));
            long a = nowyear - birthdate;
            string old = a.ToString();
            
            
            MessageBox.Show(old);
            
            
        }
        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {

            string text = DatePicker1.SelectedDate.ToString();
            TextBlock1.Text = text;
        }
        #endregion
    }
}
