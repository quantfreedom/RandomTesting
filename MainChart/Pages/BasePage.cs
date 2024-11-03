using MainChart.Animation;
using MainChart.Core.ViewModels.Base;
using System.Windows;
using System.Windows.Controls;

namespace MainChart.Pages;

public class BasePage<VM>:Page
    where VM : BaseViewModel, new()
{

    #region Private Members

    private VM mViewModel;

    #endregion

    #region Public Properties

    public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.SlideAndFadeInFromRight;
    public PageAnimation PageUnloadAnimation { get; set; } = PageAnimation.SlideAndFadeOutToLeft;
    public float SlideSeconds { get; set; } = 0.8f;
    public VM ViewModel
    {
        get => mViewModel;
        set
        {
            if (mViewModel == value)
                return;

            mViewModel = value;

            this.DataContext = mViewModel;
        }
    }

    #endregion

        #region Constructor

    public BasePage()
    {
        if (this.PageLoadAnimation != PageAnimation.None)
            this.Visibility = Visibility.Collapsed;

        this.Loaded += BasePage_LoadedAsync;
        this.ViewModel = new VM();
    }

    #endregion

    #region Animation Load/Unload
    private async void BasePage_LoadedAsync(object sender, RoutedEventArgs e)
    {

        await AnimateInAsync();

    }

    public async Task AnimateInAsync()
    {
        if (this.PageLoadAnimation == PageAnimation.None)
            return;

        switch (this.PageLoadAnimation)
        {
            case PageAnimation.SlideAndFadeInFromRight:

                await this.SlideAndFadeInFromRightAsync(this.SlideSeconds);
                break;

        }
    }

    public async Task AnimateOutAsync()
    {
        if (this.PageUnloadAnimation == PageAnimation.None)
            return;

        switch (this.PageUnloadAnimation)
        {
            case PageAnimation.SlideAndFadeOutToLeft:

                await this.SlideAndFadeOutToLeftAsync(this.SlideSeconds);
                break;

        }
    }

    #endregion


}