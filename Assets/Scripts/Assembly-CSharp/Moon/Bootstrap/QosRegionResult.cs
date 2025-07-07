using System.Collections.Generic;

namespace Moon.Bootstrap
{
	public class QosRegionResult
	{
		public string Region;

		public int LatencyMs;

		public IReadOnlyList<int> RawMeasurements;

		public int NumTimeouts;

		public int ErrorCode;
	}
}
