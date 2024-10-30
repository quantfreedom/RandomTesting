using MainChart.DataModels;
using MainChart.Resizer;
using MainChart.ViewModels.Base;
using System.Windows;
using System.Windows.Input;

namespace MainChart.ViewModels;

public class WindowViewModel:BaseViewModel
{
    #region Private Members

    private Window mWindow;

    #endregion

    #region Public Properties

    public ApplicationPage CurrentPage { get; set; } = ApplicationPage.ChatPage;
    public bool Borderless { get { return (mWindow.WindowState == WindowState.Maximized || mDockPosition != WindowDockPosition.Undocked); } }

    // TODO: Add a way to set the resize border thickness
    public int ResizeBorder { get; set; } = 6;
    //public int ResizeBorder { get { return Borderless ? 0 : 6; } }
    public Thickness ResizeBorderThickness { get { return new(ResizeBorder); } }
    public int TitleHeight { get; set; } = 20;
    public GridLength TitleHeightGridLength { get { return new(TitleHeight + ResizeBorder); } }

    public string WindowTitle { get; set; } = " Chart Bitcoin Volume - 10 Mil";
    public double WindowMinimumWidth { get; set; } = 400;

    public double WindowMinimumHeight { get; set; } = 400;

    private WindowDockPosition mDockPosition = WindowDockPosition.Undocked;

    #endregion
    #region Commands

    public ICommand MinimizeCommand { get; set; }
    public ICommand MaximizeCommand { get; set; }
    public ICommand CloseCommand { get; set; }

    public ICommand MenuCommand { get; set; }

    #endregion

    #region Constructors

    public WindowViewModel() { }
    public WindowViewModel(Window window)
    {
        mWindow = window;

        mWindow.StateChanged += (sender, e) =>
        {
            WindowResized();
        };

        MinimizeCommand = new RelayCommand(() => mWindow.WindowState = WindowState.Minimized);
        MaximizeCommand = new RelayCommand(() => mWindow.WindowState ^= WindowState.Maximized);
        CloseCommand = new RelayCommand(() => mWindow.Close());
        MenuCommand = new RelayCommand(() => SystemCommands.ShowSystemMenu(mWindow, mWindow.PointToScreen(Mouse.GetPosition(mWindow))));
        // Fix window resize issue
        var resizer = new WindowResizer(mWindow);

        // Listen out for dock changes
        resizer.WindowDockChanged += (dock) =>
        {
            // Store last position
            mDockPosition = dock;

            // Fire off resize events
            WindowResized();
        };

    }

    private void WindowResized()
    {
        // Fire off events for all properties that are affected by a resize
        OnPropertyChanged(nameof(ResizeBorderThickness));
        OnPropertyChanged(nameof(WindowTitle));
        OnPropertyChanged(nameof(Borderless));
    }


    #endregion
}