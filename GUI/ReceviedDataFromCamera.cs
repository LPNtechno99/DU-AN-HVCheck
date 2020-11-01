﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class ReceviedDataFromCamera
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private string _receviedString;
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
    }
}
