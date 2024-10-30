using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace MainChart.Animation;

public static class FrameworkElementAnimations
{
    #region Slide In From Left

    /// <summary>
    /// Slides an element in from the left
    /// </summary>
    /// <param name="element">The element to animate</param>
    /// <param name="seconds">The time the animation will take</param>
    /// <param name="keepMargin">Whether to keep the element at the same width during animation</param>
    /// <param name="width">The animation width to animate to. If not specified the elements width is used</param>
    /// <returns></returns>
    public static async Task SlideAndFadeInFromLeftAsync(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true, int width = 0)
    {
        // Create the storyboard
        var sb = new Storyboard();

        // Add slide from left animation
        sb.AddSlideFromLeft(seconds, width == 0 ? element.ActualWidth : width, keepMargin: keepMargin);

        // Add fade in animation
        sb.AddFadeIn(seconds);

        // Start animating
        sb.Begin(element);

        // Make page visible
        element.Visibility = Visibility.Visible;

        // Wait for it to finish
        await Task.Delay((int)(seconds * 1000));
    }

    /// <summary>
    /// Slides an element out to the left
    /// </summary>
    /// <param name="element">The element to animate</param>
    /// <param name="seconds">The time the animation will take</param>
    /// <param name="keepMargin">Whether to keep the element at the same width during animation</param>
    /// <param name="width">The animation width to animate to. If not specified the elements width is used</param>
    /// <returns></returns>
    public static async Task SlideAndFadeOutToLeftAsync(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true, int width = 0)
    {
        // Create the storyboard
        var sb = new Storyboard();

        // Add slide to left animation
        sb.AddSlideToLeft(seconds, width == 0 ? element.ActualWidth : width, keepMargin: keepMargin);

        // Add fade in animation
        sb.AddFadeOut(seconds);

        // Start animating
        sb.Begin(element);

        // Make page visible
        element.Visibility = Visibility.Visible;

        // Wait for it to finish
        await Task.Delay((int)(seconds * 1000));
    }

    #endregion

    #region Slide In From Right

    /// <summary>
    /// Slides an element in from the right
    /// </summary>
    /// <param name="element">The element to animate</param>
    /// <param name="seconds">The time the animation will take</param>
    /// <param name="keepMargin">Whether to keep the element at the same width during animation</param>
    /// <param name="width">The animation width to animate to. If not specified the elements width is used</param>
    /// <returns></returns>
    public static async Task SlideAndFadeInFromRightAsync(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true, int width = 0)
    {
        // Create the storyboard
        var sb = new Storyboard();

        // Add slide from right animation
        sb.AddSlideFromRight(seconds, width == 0 ? element.ActualWidth : width, keepMargin: keepMargin);

        // Add fade in animation
        sb.AddFadeIn(seconds);

        // Start animating
        sb.Begin(element);

        // Make page visible
        element.Visibility = Visibility.Visible;

        // Wait for it to finish
        await Task.Delay((int)(seconds * 1000));
    }

    /// <summary>
    /// Slides an element out to the right
    /// </summary>
    /// <param name="element">The element to animate</param>
    /// <param name="seconds">The time the animation will take</param>
    /// <param name="keepMargin">Whether to keep the element at the same width during animation</param>
    /// <param name="width">The animation width to animate to. If not specified the elements width is used</param>
    /// <returns></returns>
    public static async Task SlideAndFadeOutToRightAsync(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true, int width = 0)
    {
        // Create the storyboard
        var sb = new Storyboard();

        // Add slide from right animation
        sb.AddSlideToRight(seconds, width == 0 ? element.ActualWidth : width, keepMargin: keepMargin);

        // Add fade in animation
        sb.AddFadeOut(seconds);

        // Start animating
        sb.Begin(element);

        // Make page visible
        element.Visibility = Visibility.Visible;

        // Wait for it to finish
        await Task.Delay((int)(seconds * 1000));
    }

    #endregion

    #region Slide In From Bottom

    /// <summary>
    /// Slides an element in from the bottom
    /// </summary>
    /// <param name="element">The element to animate</param>
    /// <param name="seconds">The time the animation will take</param>
    /// <param name="keepMargin">Whether to keep the element at the same height during animation</param>
    /// <param name="height">The animation height to animate to. If not specified the elements height is used</param>
    /// <returns></returns>
    public static async Task SlideAndFadeInFromBottomAsync(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true, int height = 0)
    {
        // Create the storyboard
        var sb = new Storyboard();

        // Add slide from bottom animation
        sb.AddSlideFromBottom(seconds, height == 0 ? element.ActualHeight : height, keepMargin: keepMargin);

        // Add fade in animation
        sb.AddFadeIn(seconds);

        // Start animating
        sb.Begin(element);

        // Make page visible
        element.Visibility = Visibility.Visible;

        // Wait for it to finish
        await Task.Delay((int)(seconds * 1000));
    }

    /// <summary>
    /// Slides an element out to the bottom
    /// </summary>
    /// <param name="element">The element to animate</param>
    /// <param name="seconds">The time the animation will take</param>
    /// <param name="keepMargin">Whether to keep the element at the same height during animation</param>
    /// <param name="height">The animation height to animate to. If not specified the elements height is used</param>
    /// <returns></returns>
    public static async Task SlideAndFadeOutToBottomAsync(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true, int height = 0)
    {
        // Create the storyboard
        var sb = new Storyboard();

        // Add slide to bottom animation
        sb.AddSlideToBottom(seconds, height == 0 ? element.ActualHeight : height, keepMargin: keepMargin);

        // Add fade in animation
        sb.AddFadeOut(seconds);

        // Start animating
        sb.Begin(element);

        // Make page visible
        element.Visibility = Visibility.Visible;

        // Wait for it to finish
        await Task.Delay((int)(seconds * 1000));
    }

    #endregion

    public static async Task SlideAndFadeInAsync(this FrameworkElement element, AnimationSlideInDirection direction, bool firstLoad, float seconds = 0.3f, bool keepMargin = true, int size = 0)
    {
        // Create the storyboard
        var sb = new Storyboard();

        // Slide in the correct direction
        switch (direction)
        {
            // Add slide from left animation
            case AnimationSlideInDirection.Left:
                sb.AddSlideFromLeft(seconds, size == 0 ? element.ActualWidth : size, keepMargin: keepMargin);
                break;
            // Add slide from right animation
            case AnimationSlideInDirection.Right:
                sb.AddSlideFromRight(seconds, size == 0 ? element.ActualWidth : size, keepMargin: keepMargin);
                break;
            // Add slide from top animation
            case AnimationSlideInDirection.Top:
                sb.AddSlideFromTop(seconds, size == 0 ? element.ActualHeight : size, keepMargin: keepMargin);
                break;
            // Add slide from bottom animation
            case AnimationSlideInDirection.Bottom:
                sb.AddSlideFromBottom(seconds, size == 0 ? element.ActualHeight : size, keepMargin: keepMargin);
                break;
        }
        // Add fade in animation
        sb.AddFadeIn(seconds);

        // Start animating
        sb.Begin(element);

        // Make page visible only if we are animating or its the first load
        if (seconds != 0 || firstLoad)
            element.Visibility = Visibility.Visible;

        // Wait for it to finish
        await Task.Delay((int)(seconds * 1000));
    }

    public static async Task SlideAndFadeOutAsync(this FrameworkElement element, AnimationSlideInDirection direction, float seconds = 0.3f, bool keepMargin = true, int size = 0)
    {
        // Create the storyboard
        var sb = new Storyboard();

        // Slide in the correct direction
        switch (direction)
        {
            // Add slide to left animation
            case AnimationSlideInDirection.Left:
                sb.AddSlideToLeft(seconds, size == 0 ? element.ActualWidth : size, keepMargin: keepMargin);
                break;
            // Add slide to right animation
            case AnimationSlideInDirection.Right:
                sb.AddSlideToRight(seconds, size == 0 ? element.ActualWidth : size, keepMargin: keepMargin);
                break;
            // Add slide to top animation
            case AnimationSlideInDirection.Top:
                sb.AddSlideToTop(seconds, size == 0 ? element.ActualHeight : size, keepMargin: keepMargin);
                break;
            // Add slide to bottom animation
            case AnimationSlideInDirection.Bottom:
                sb.AddSlideToBottom(seconds, size == 0 ? element.ActualHeight : size, keepMargin: keepMargin);
                break;
        }

        // Add fade in animation
        sb.AddFadeOut(seconds);

        // Start animating
        sb.Begin(element);

        // Make page visible only if we are animating
        if (seconds != 0)
            element.Visibility = Visibility.Visible;

        // Wait for it to finish
        await Task.Delay((int)(seconds * 1000));

        // Make element invisible
        if (element.Opacity == 0)
            element.Visibility = Visibility.Hidden;
    }

    public static async Task FadeInAsync(this FrameworkElement element, bool firstLoad, float seconds = 0.3f)
    {
        // Create the storyboard
        var sb = new Storyboard();

        // Add fade in animation
        sb.AddFadeIn(seconds);

        // Start animating
        sb.Begin(element);

        // Make page visible only if we are animating or its the first load
        if (seconds != 0 || firstLoad)
            element.Visibility = Visibility.Visible;

        // Wait for it to finish
        await Task.Delay((int)(seconds * 1000));
    }

    /// <summary>
    /// Fades out an element
    /// </summary>
    /// <param name="element">The element to animate</param>
    /// <param name="seconds">The time the animation will take</param>
    /// <param name="firstLoad">Indicates if this is the first load</param>
    /// <returns></returns>
    public static async Task FadeOutAsync(this FrameworkElement element, float seconds = 0.3f)
    {
        // Create the storyboard
        var sb = new Storyboard();

        // Add fade in animation
        sb.AddFadeOut(seconds);

        // Start animating
        sb.Begin(element);

        // Make page visible only if we are animating or its the first load
        if (seconds != 0)
            element.Visibility = Visibility.Visible;

        // Wait for it to finish
        await Task.Delay((int)(seconds * 1000));

        // Fully hide the element
        element.Visibility = Visibility.Collapsed;
    }

    public static void MarqueeAsync(this FrameworkElement element, float seconds = 3f)
    {
        // Create the storyboard
        var sb = new Storyboard();

        // Run until element is unloaded
        var unloaded = false;

        // Monitor for element unloading
        element.Unloaded += (s, e) => unloaded = true;

        // Run a loop off the caller thread
        Task.Run(async () =>
        {
            // While the element is still available, recheck the size
            // after every loop in case the container was resized
            while (element != null && !unloaded)
            {
                // Create width variables
                var width = 0d;
                var innerWidth = 0d;

                try
                {
                    // Check if element is still loaded
                    if (element == null || unloaded)
                        break;

                    // Try and get current width
                    width = element.ActualWidth;
                    innerWidth = ((element as Border).Child as FrameworkElement).ActualWidth;
                }
                catch
                {
                    // Any issues then stop animating (presume element destroyed)
                    break;
                }

                Application.Current.Dispatcher.Invoke(() =>
                {
                    // Add marquee animation
                    sb.AddMarquee(seconds, width, innerWidth);

                    // Start animating
                    sb.Begin(element);

                    // Make page visible
                    element.Visibility = Visibility.Visible;
                });

                // Wait for it to finish animating
                await Task.Delay((int)seconds * 1000);

                // If this is from first load or zero seconds of animation, do not repeat
                if (seconds == 0)
                    break;
            }
        });
    }

}