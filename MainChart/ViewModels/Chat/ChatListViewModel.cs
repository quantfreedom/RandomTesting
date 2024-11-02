using MainChart.ViewModels.Base;

namespace MainChart.ViewModels.Chat;

public class ChatListViewModel:BaseViewModel
{
    public List<ChatListItemViewModel> Items { get; set; }
}