using System;
using System.Collections.Generic;
using System.IO;
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
        private string job_path = @"C:\Microscan\Vscape\Jobs\";
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

        private void EventF1Push_Process(object sender, ExecutedRoutedEventArgs e)
        {
            cbbChonCheDoChay.SelectedIndex = 0;
        }

        private void EventF2Push_Process(object sender, ExecutedRoutedEventArgs e)
        {
            cbbChonCheDoChay.SelectedIndex = 1;
            wdKiemTra wd = new wdKiemTra();
            wd.ShowDialog();
        }

        private void EventF3Push_Process(object sender, ExecutedRoutedEventArgs e)
        {
            wdHienThiDuLieu wd = new wdHienThiDuLieu();
            wd.ShowDialog();
        }
        private void getFileNames()
        {
            DirectoryInfo di = new DirectoryInfo(job_path);
            FileSystemInfo[] smFiles = di.GetFiles("*.avp");
            int i = 0;
            string fileName = "";
            cbbCongViec.Items.Clear();
            while (i < smFiles.Length)
            {
                fileName = smFiles[i].ToString();
                this.cbbCongViec.Items.Add(fileName.Substring(0, fileName.Length));
                i++;
            }
            cbbCongViec.Text = smFiles[0].ToString().Substring(0, smFiles[0].ToString().Length);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            getFileNames();
        }
    }
}
