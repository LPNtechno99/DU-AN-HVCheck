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

namespace GUI
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

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CbbChonCheDo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cbbChonCheDo.SelectedIndex == 0)
            {
                wdChayThuong wd = new wdChayThuong();
                wd.ShowDialog();
               
            }
            else if(cbbChonCheDo.SelectedIndex == 1)
            {
                wdChayThuong wd = new wdChayThuong();
                wd.ShowDialog();
            }
        }

        private void EventF1Push(object sender, ExecutedRoutedEventArgs e)
        {
            wdChayThuong wd = new wdChayThuong();
            wd.ShowDialog();
            
        }

        private void EventF2Push(object sender, ExecutedRoutedEventArgs e)
        {
            wdChayThuong wd = new wdChayThuong();
            wd.ShowDialog();
            
        }
    }
}
