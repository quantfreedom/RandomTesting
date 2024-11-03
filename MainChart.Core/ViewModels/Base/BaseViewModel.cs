﻿using MainChart.Core.Expressions;
using System.ComponentModel;
using System.Linq.Expressions;

namespace MainChart.Core.ViewModels.Base;

public class BaseViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

    public void OnPropertyChanged(string name)
    {
        PropertyChanged(this, new PropertyChangedEventArgs(name));
    }

    #region Command Helpers

    protected async Task RunCommandAsync(Expression<Func<bool>> updatingFlag, Func<Task> action)
    {
        if (updatingFlag.GetPropertyValue())
            return;

        updatingFlag.SetPropertyValue(true);

        try
        {
            await action();
        }
        finally
        {
            updatingFlag.SetPropertyValue(false);
        }
    }

    #endregion
}