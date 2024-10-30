using MainChart.ViewModels.Base;
using System.Windows.Input;

namespace MainChart.ViewModels;

public class ChatMessageListViewModel:BaseViewModel
{

	#region Public Properties

	public bool AttachementMenuVisible { get; set; }

	#endregion

	#region Public Commands

	public ICommand AttachementButtonCommand { get; set; }


	#endregion
	#region Constructor

	public ChatMessageListViewModel()
	{
		AttachementButtonCommand = new RelayCommand(AttachementButton);
	}

	#endregion
	#region Command Methods

	private void AttachementButton()
	{
		AttachementMenuVisible ^= true;
	}

	#endregion
}