using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class ReceviedDataFromCamera : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private string _receviedString = "None";
        public string ReceviedString
        {
            get { return _receviedString; }
            set
            {
                _receviedString = value;
                OnPropertyChanged("ReceviedString");
            }
        }
        public enum StatusCheck { NONE, PASS, FAIL}
        private StatusCheck _resultCheck = 0;
        public StatusCheck ResultCheck
        {
            get { return _resultCheck; }
            set
            {
                _resultCheck = value;
                OnPropertyChanged("ResultCheck");
            }
        }
        private int _counterPass = 0;
        public int CounterPass
        {
            get { return _counterPass; }
            set
            {
                _counterPass = value;
                OnPropertyChanged("CounterPass");
            }
        }
        private int _counterFail = 0;
        public int CounterFail
        {
            get { return _counterFail; }
            set
            {
                _counterFail = value;
                OnPropertyChanged("CounterFail");
            }
        }

        public enum StateCam { RUN, STOP}
        private StateCam _stateCamera = StateCam.RUN;
        public StateCam StateCamera
        {
            get { return _stateCamera; }
            set
            {
                _stateCamera = value;
                OnPropertyChanged("StateCamera");
            }
        }

    }
}
