using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ReceviedDataFromCamera _camera;
        public ObservableCollection<ReceviedDataFromCamera> _objObser;
        public wdChayThuong()
        {
            InitializeComponent();

            _camera = new ReceviedDataFromCamera();
            _objObser = new ObservableCollection<ReceviedDataFromCamera>();
            _objObser.Add(_camera);
            this.lblPassFail.DataContext = _objObser;
            this.lblChuoiNhan.DataContext = _objObser;
            this.lblCounterPass.DataContext = _objObser;
            this.lblCounterFail.DataContext = _objObser;
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
        private void EventF9Push_Process(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void EventF10Push_Process(object sender, ExecutedRoutedEventArgs e)
        {

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _camera.ResultCheck = ReceviedDataFromCamera.StatusCheck.PASS;
            _camera.ReceviedString = "Namdepzai";
            _camera.CounterPass++;
        }

        private void TestFail_Click(object sender, RoutedEventArgs e)
        {
            _camera.ResultCheck = ReceviedDataFromCamera.StatusCheck.FAIL;
            _camera.ReceviedString = "RineXinhgai";
            _camera.CounterFail++;
        }

        
    }
}
