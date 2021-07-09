﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using ReSender.Annotations;

namespace ReSender.ViewModels
{
    public class Main : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public Main()
        {
        }
    }
}