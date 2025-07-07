namespace Moon.Bootstrap
{
	internal class QosRegionResultSummary
	{
		public string Region;

		public int NumTimeouts;

		public int LatencyMs;

		public int ErrorCode;

		public static QosRegionResultSummary CreateFrom(QosRegionResult result)
		{
			return null;
		}
	}
}
