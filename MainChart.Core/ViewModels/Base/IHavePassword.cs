

using System.Security;

namespace MainChart.Core.ViewModels.Base;

public interface IHavePassword
{
	SecureString SecurePassword { get; }
}
