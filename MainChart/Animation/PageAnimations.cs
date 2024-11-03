using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace MainChart.Animation;

public static class PageAnimations
{
    public static async Task SlideAndFadeInFromRightAsync(this Page page, float seconds)
    {
        var sb = new Storyboard();
        sb.AddSlideFromRight(seconds, page.WindowWidth);
        sb.AddFadeIn(seconds);
        sb.Begin(page);
        page.Visibility = Visibility.Visible;
    }
    
    public static async Task SlideAndFadeOutToLeftAsync(this Page page, float seconds)
    {
        var sb = new Storyboard();
        sb.AddSlideToLeft(seconds, page.WindowWidth);
        sb.AddFadeOut(seconds);
        sb.Begin(page);
        page.Visibility = Visibility.Visible;
    }
}