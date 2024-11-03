

using System.Security;

namespace MainChart.ViewModels.Base;

public interface IHavePassword
{
	SecureString SecurePassword { get; }
}
