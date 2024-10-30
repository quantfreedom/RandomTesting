﻿using System.ComponentModel;

namespace MainChart.ViewModels.Base;

public class BaseViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

    public void OnPropertyChanged(string name)
    {
        PropertyChanged(this, new PropertyChangedEventArgs(name));
    }
}