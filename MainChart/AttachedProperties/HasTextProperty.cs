using System.Windows;
using System.Windows.Controls;

namespace MainChart.AttachedProperties;

public class HasTextProperty:BaseAttachedProperty<HasTextProperty, bool>
{
    /// <summary>
    /// Sets the HasText property based on if the caller <see cref="PasswordBox"/> has any text
    /// </summary>
    /// <param name="sender"></param>
    public static void SetValue(DependencyObject sender)
    {
        SetValue(sender, ((PasswordBox)sender).SecurePassword.Length > 0);
    }
}
