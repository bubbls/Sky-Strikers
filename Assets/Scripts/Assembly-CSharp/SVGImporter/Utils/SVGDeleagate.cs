using System;

namespace SVGImporter.Utils
{
	public static class SVGDeleagate
	{
		public static bool IsRegistered(Delegate source, Action compare)
		{
			return false;
		}

		public static bool IsRegistered<T>(Delegate source, Action<T> compare)
		{
			return false;
		}

		public static bool IsRegistered<T1, T2>(Delegate source, Action<T1, T2> compare)
		{
			return false;
		}

		public static bool IsRegistered<T1, T2, T3>(Delegate source, Action<T1, T2, T3> compare)
		{
			return false;
		}

		public static bool IsRegistered<T1, T2, T3, T4>(Delegate source, Action<T1, T2, T3, T4> compare)
		{
			return false;
		}
	}
}
