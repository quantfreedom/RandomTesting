namespace MainChart.Core.ViewModels.Chat.Design;

public class ChatListItemDesignModel:ChatListItemViewModel
{

    public static ChatListItemDesignModel Instance => new ChatListItemDesignModel();
    public ChatListItemDesignModel()
    {
        Name = "Luke";
        Message = "This new chat app is awesome!";
        Initials = "LM";
        ProfilePictureRGB = "3099c5";
    }
}