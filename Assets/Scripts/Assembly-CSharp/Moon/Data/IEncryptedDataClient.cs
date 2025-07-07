namespace Moon.Data
{
	public interface IEncryptedDataClient
	{
		void SetString(string key, string value);

		string GetString(string key, string defaultValue = "");

		bool HasKey(string key);

		void DeleteKey(string key);
	}
}
