using System.Runtime.InteropServices;
using TestAlgoritms.Services.Interfaces;

namespace TestAlgoritms.Services
{
	public class LocalizationService : ILocalizationService
	{
		private Dictionary<string, string> localizationDictionary = new Dictionary<string, string>();
		public LocalizationService() { }

		public string this[string name] => GetValue(name);

		public string this[string name, params string[] args] => GetValue(name, args);

		public event Action LocalizationChanged;

		private string GetValue(string value, string[] args = default)
		{
			if (localizationDictionary.ContainsKey(value))
				return localizationDictionary[value];

			return value;
		}

		private string GetLocalizedText()
		{
			var directoryPath = Directory.GetCurrentDirectory();
			var filePath = Path.Combine(directoryPath, "i18n.ini");

			try
			{
				using var reader = new StreamReader(filePath);
				while (!reader.EndOfStream)
				{
					return reader.ReadToEnd();
				}
			}
			catch (Exception ex) 
			{
				Console.WriteLine(ex.Message);
			}

			return string.Empty;
		}

		private void FillLocalizationDictionary()
		{
			var localizedText = GetLocalizedText();
			

		}

		public string[] GetLanguages()
		{
			throw new NotImplementedException();
		}
	}
}
