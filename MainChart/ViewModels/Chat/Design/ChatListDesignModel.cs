namespace MainChart.ViewModels.Chat.Design;

public class ChatListDesignModel:ChatListViewModel
{

    public static ChatListDesignModel Instance => new ChatListDesignModel();
    public ChatListDesignModel()
    {
        Items =
        [
            new ChatListItemViewModel {
                Initials = "LM",
                Name = "Luke",
                Message = "This chat app is awesome! I bet it will be fast too",
                ProfilePictureRGB = "3099c5",
                NewContentAvailable = true,
            },
            new ChatListItemViewModel {
                Initials = "NO",
                Name = "Nina",
                Message = "I know right, I'm so excited to start using it!",
                ProfilePictureRGB = "ff0000"
                },
            new ChatListItemViewModel {
                Initials = "JG",
                Name = "John",
                Message = "Hey dude, how's it going?",
                ProfilePictureRGB = "00ff00",
                IsSelected = true,
                },
            new ChatListItemViewModel {
                Initials = "LM",
                Name = "Luke",
                Message = "This chat app is awesome! I bet it will be fast too",
                ProfilePictureRGB = "3099c5",
            },
            new ChatListItemViewModel {
                Initials = "NO",
                Name = "Nina",
                Message = "I know right, I'm so excited to start using it!",
                ProfilePictureRGB = "ff0000"
                },
            new ChatListItemViewModel {
                Initials = "JG",
                Name = "John",
                Message = "Hey dude, how's it going?",
                ProfilePictureRGB = "00ff00"
                },
            new ChatListItemViewModel {
                Initials = "LM",
                Name = "Luke",
                Message = "This chat app is awesome! I bet it will be fast too",
                ProfilePictureRGB = "3099c5",
            },
            new ChatListItemViewModel {
                Initials = "NO",
                Name = "Nina",
                Message = "I know right, I'm so excited to start using it!",
                ProfilePictureRGB = "ff0000"
                },
            new ChatListItemViewModel {
                Initials = "JG",
                Name = "John",
                Message = "Hey dude, how's it going?",
                ProfilePictureRGB = "00ff00"
                },
            new ChatListItemViewModel {
                Initials = "LM",
                Name = "Luke",
                Message = "This chat app is awesome! I bet it will be fast too",
                ProfilePictureRGB = "3099c5",
            },
            new ChatListItemViewModel {
                Initials = "NO",
                Name = "Nina",
                Message = "I know right, I'm so excited to start using it!",
                ProfilePictureRGB = "ff0000"
                },
            new ChatListItemViewModel {
                Initials = "JG",
                Name = "John",
                Message = "Hey dude, how's it going?",
                ProfilePictureRGB = "00ff00"
                },
            new ChatListItemViewModel {
                Initials = "LM",
                Name = "Luke",
                Message = "This chat app is awesome! I bet it will be fast too",
                ProfilePictureRGB = "3099c5",
            },
            new ChatListItemViewModel {
                Initials = "NO",
                Name = "Nina",
                Message = "I know right, I'm so excited to start using it!",
                ProfilePictureRGB = "ff0000"
                },
            new ChatListItemViewModel {
                Initials = "JG",
                Name = "John",
                Message = "Hey dude, how's it going?",
                ProfilePictureRGB = "00ff00"
                },
            new ChatListItemViewModel {
                Initials = "LM",
                Name = "Luke",
                Message = "This chat app is awesome! I bet it will be fast too",
                ProfilePictureRGB = "3099c5",
            },
            new ChatListItemViewModel {
                Initials = "NO",
                Name = "Nina",
                Message = "I know right, I'm so excited to start using it!",
                ProfilePictureRGB = "ff0000"
                },
            new ChatListItemViewModel {
                Initials = "JG",
                Name = "John",
                Message = "Hey dude, how's it going?",
                ProfilePictureRGB = "00ff00"
                },
        ];
    }
}