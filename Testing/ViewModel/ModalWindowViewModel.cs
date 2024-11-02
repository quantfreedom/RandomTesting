using System.Windows;
using System.Windows.Input;
using Testing.ViewModel.Base;

namespace Testing.ViewModel;

public class ModalWindowViewModel:BaseViewModel
{
    public bool ModalVisible { get; set; } = false;
    public ICommand ShowModalCommand { get; set; }

    public ModalWindowViewModel()
    {
        ShowModalCommand = new RelayCommand(ShowModal);
    }

    public void ShowModal()
    {
        ModalVisible ^= true;
        OnPropertyChanged(nameof(ModalVisible));

    }

}