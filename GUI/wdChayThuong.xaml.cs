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
using Visionscape.Extension;
using TT_ClientSocketLibrary;

namespace GUI
{
    /// <summary>
    /// Interaction logic for wdChayThuong.xaml
    /// </summary>
    public partial class wdChayThuong : Window
    {
        private string job_path = @"C:\Microscan\Vscape\Jobs\";
        private string VisionDevice = "";

        public ReceviedDataFromCamera _camera;
        public ObservableCollection<ReceviedDataFromCamera> _objObser;
        private Connection _cameraMV40;
        private ClientSocket MicroscanLink;

        public wdChayThuong()
        {
            InitializeComponent();

            MicroscanLink = new ClientSocket();
           

            _camera = new ReceviedDataFromCamera();
            _objObser = new ObservableCollection<ReceviedDataFromCamera>();
            _objObser.Add(_camera);
            this.lblPassFail.DataContext = _objObser;
            this.lblChuoiNhan.DataContext = _objObser;
            this.lblCounterPass.DataContext = _objObser;
            this.lblCounterFail.DataContext = _objObser;
            this.btnChay.DataContext = _objObser;
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
            _cameraMV40 = new Connection();
            _cameraMV40.ConnectionEventCallback += _cameraMV40_ConnectionEventCallback;
        }

        private void _cameraMV40_ConnectionEventCallback(Enum_ConnectionEvent e, object obj)
        {
            switch (e)
            {
                case Enum_ConnectionEvent.DISCOVERED_NEW_CAMERA:
                    Application.Current.Dispatcher.Invoke(new
                         Action(() =>
                         {
                             Visionscape.Devices.VsDeviceClass dev = obj as Visionscape.Devices.VsDeviceClass;
                             if (dev.Name != null)
                             {
                                 VisionDevice = dev.Name;
                             }

                         }));
                    
                    break;
                case Enum_ConnectionEvent.DISCOVERED_CAMERA:
                    _cameraMV40.ConnectJob(job_path + cbbCongViec.Text);
                    break;
                case Enum_ConnectionEvent.CONNECTED_JOB:
                    _cameraMV40.DownloadJob();
                    break;
                case Enum_ConnectionEvent.DOWNLOADING_JOB:
                    break;
                case Enum_ConnectionEvent.DOWNLOADED_JOB:
                    _cameraMV40.ConnectIO();
                    _cameraMV40.ConnectReport();
                    break;
                case Enum_ConnectionEvent.CONNECTED_REPORT:
                    break;
                case Enum_ConnectionEvent.RECEIVED_REPORT:
                    break;
                case Enum_ConnectionEvent.RECEIVED_IMAGE:
                    Visionscape.Communications.InspectionReport report = obj as Visionscape.Communications.InspectionReport;
                    Application.Current.Dispatcher.Invoke(new Action(() =>
                    {
                        //Update Image
                        imgBuffer.DataContext = report.Images[0];

                        //Update Tool Data
                        foreach (Visionscape.Communications.InspectionReportValue result in report.Results)
                        {
                            try
                            {
                                if (result.NameSym == "Snapshot1.HiLevelTool1.OCRX1.OutStr")
                                {
                                    _camera.ReceviedString = result.AsString;
                                }

                            }
                            catch
                            {

                            }
                            if(report.InspectionStats.Passed)
                            {
                                _camera.CounterPass++;
                            }
                            else
                            {
                                _camera.CounterFail++;
                            }
                        }
                    }));
                    break;
                case Enum_ConnectionEvent.CONNECTED_IO:
                    break;
                case Enum_ConnectionEvent.TRIGGERED_IO:
                    break;
                case Enum_ConnectionEvent.STATECHANGED_IO:
                    break;
                case Enum_ConnectionEvent.DISCONNECTED_DEVICE:
                    break;
                case Enum_ConnectionEvent.DISCONNECTED_JOB:
                    break;
                case Enum_ConnectionEvent.DISCONNECTED_REPORT:
                    break;
                case Enum_ConnectionEvent.DISCONNECTED_IO:
                    break;
                case Enum_ConnectionEvent.DISCONNECTED_ALL:
                    break;
                case Enum_ConnectionEvent.ERROR:
                    break;
                default:
                    break;
            }
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

        bool _flagInspection;
        private void btnChay_Click(object sender, RoutedEventArgs e)
        {
            if (!_flagInspection)
            {
                _cameraMV40.ConnectCamera(VisionDevice);
                _camera.StateCamera = ReceviedDataFromCamera.StateCam.STOP;
                _flagInspection = true;
            }
            else
            {
                _cameraMV40.DisconnectAll();
                _camera.StateCamera = ReceviedDataFromCamera.StateCam.RUN;
                _flagInspection = false;
            }
        }
    }
}
