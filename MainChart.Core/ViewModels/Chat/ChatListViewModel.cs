using MainChart.Core.ViewModels.Base;

namespace MainChart.Core.ViewModels.Chat;

public class ChatListViewModel:BaseViewModel
{
    public List<ChatListItemViewModel> Items { get; set; }
}