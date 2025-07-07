using System.Runtime.InteropServices;
using Fusion;

namespace Moon.Bootstrap
{
	[StructLayout((LayoutKind)2, Size = 264)]
	[NetworkStructWeaved(66)]
	public struct LatencyFusion : INetworkStruct
	{
		[FieldOffset(0)]
		public NetworkString<_64> Region;

		[FieldOffset(260)]
		public int LatencyMs;

		public LatencyFusion(Latency latency)
		{
			Region = default(NetworkString<_64>);
			LatencyMs = 0;
		}

		public Latency ToLatency()
		{
			return null;
		}
	}
}
