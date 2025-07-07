using System;

namespace AmplifyShaderPack
{
	[Serializable]
	public class VersionInfo
	{
		public const byte Major = 1;

		public const byte Minor = 0;

		public const byte Release = 3;

		public static byte Revision;

		public static int FullNumber => 0;

		public static string FullLabel => null;

		public static string StaticToString()
		{
			return null;
		}
	}
}
