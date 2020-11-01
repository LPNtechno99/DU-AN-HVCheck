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

namespace GUI
{
    /// <summary>
    /// Interaction logic for wdHienThiDuLieu.xaml
    /// </summary>
    public partial class wdHienThiDuLieu : Window
    {
        public wdHienThiDuLieu()
        {
            InitializeComponent();
        }

        private void EventEscPush(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void EventF5Push(object sender, ExecutedRoutedEventArgs e)
        {

        }
    }
}
