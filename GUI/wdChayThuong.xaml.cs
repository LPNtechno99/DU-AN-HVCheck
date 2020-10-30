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
    /// Interaction logic for wdChayThuong.xaml
    /// </summary>
    public partial class wdChayThuong : Window
    {
        public wdChayThuong()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnCaiDat_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("OK");
        }
    }
}
