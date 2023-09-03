using System.Runtime.CompilerServices;

namespace TestAlgoritms.Services.Interfaces
{
	public interface ILocalizationService
	{
		string this[string name] { get; }
		string this[string name, params string[] args] { get; }

		public event Action LocalizationChanged;

		string[] GetLanguages();
	}
}
