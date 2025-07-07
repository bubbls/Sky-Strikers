using System.Collections.Generic;

namespace Moon.Bootstrap
{
	public abstract class CommandLineUtils
	{
		public static bool IsHeadlessMode()
		{
			return false;
		}

		public static List<(string, string)> GetArgumentList(string prefix)
		{
			return null;
		}

		public static bool TryGetArg(out string argValue, params string[] argNames)
		{
			argValue = null;
			return false;
		}
	}
}
