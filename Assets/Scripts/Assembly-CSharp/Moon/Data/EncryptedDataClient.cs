namespace Moon.Data
{
	public class EncryptedDataClient : IEncryptedDataClient
	{
		private const string ClassName = "EncryptedDataClient";

		private readonly string _keyPath;

		private readonly string _storingDataPath;

		public EncryptedDataClient(string keyPath, string storingDataPath)
		{
		}

		public void SetString(string key, string value)
		{
		}

		public string GetString(string key, string defaultValue = "")
		{
			return null;
		}

		public bool HasKey(string key)
		{
			return false;
		}

		public void DeleteKey(string key)
		{
		}

		private void Log(string message)
		{
		}

		private void LogError(string message)
		{
		}
	}
}
