using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace SimeHome.Models
{
    public class Sala : INotifyPropertyChanged
    {
        public string Num { get; set; }
        public string NumChamados { get; set; }

        private bool _isPressed;
        public bool IsPressed
        {
            get => _isPressed;
            set
            {
                _isPressed = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsPressed)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
