using Chamber8.Framework.Common;

namespace Moon
{
	public class FileCache : Singleton<FileCache>
	{
		private const string CacheFolderName = "FileCache";

		public byte[] GetCachedFile(string key)
		{
			return null;
		}

		public void CacheFile(string key, byte[] data)
		{
		}

		private string GetFilePathFromKey(string key)
		{
			return null;
		}

		private static string ConvertUrlToSafeFileName(string key)
		{
			return null;
		}
	}
}
