using System;

namespace Moon.Framework.Base
{
	public static class APIRequester
	{
		public enum Region : byte
		{
			CN = 0,
			Oversea = 1
		}

		private const string RegionCheckAPICall = "/ns/util/country/code";

		public static WebRequest RequestRegion(Action<bool, Region> callback)
		{
			return null;
		}

		private static void HandleOnRequestRegionDone(WebRequestResponseData responseData, Action<bool, Region> callback)
		{
		}
	}
}
