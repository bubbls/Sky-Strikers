using System.Collections.Generic;

namespace Moon.Bootstrap
{
	public static class PhotonRegion
	{
		public enum Name
		{
			Auto = 0,
			Asia = 1,
			Japan = 2,
			Europe = 3,
			SouthAmerica = 4,
			SouthKorea = 5,
			USEast = 6,
			USWest = 7,
			China = 100
		}

		public enum Code
		{
			auto = 0,
			asia = 1,
			jp = 2,
			eu = 3,
			sa = 4,
			kr = 5,
			us = 6,
			usw = 7,
			ussc = 8,
			au = 9,
			cn = 100
		}

		private static readonly Dictionary<Name, string> NameStrings;

		private static readonly Dictionary<Code, string> CodeStrings;

		public static bool IncludeChinaRegion;

		public static Code Next(Code code)
		{
			return default(Code);
		}

		public static Code Prev(Code code)
		{
			return default(Code);
		}

		public static string GetNameString(Code code)
		{
			return null;
		}

		public static string GetCodeString(Name name)
		{
			return null;
		}

		public static string GetCodeString(Code code)
		{
			return null;
		}

		public static Name GetName(Code code)
		{
			return default(Name);
		}

		public static Name GetName(string codeString)
		{
			return default(Name);
		}

		public static Code GetCode(Name regionName)
		{
			return default(Code);
		}
	}
}
