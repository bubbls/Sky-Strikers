using System.Runtime.InteropServices;
using Fusion;
using Moon.Arena;

namespace Moon.Bootstrap
{
	[StructLayout((LayoutKind)0, Pack = 1, Size = 84)]
	public struct ConnectionToken
	{
		public NetworkString<_16> PlayFabId;

		public ConnectionTokenVisualsConfig VisualsConfig;

		public TeamNo TeamNo;

		public byte PlayerNo;

		public override string ToString()
		{
			return null;
		}
	}
}
