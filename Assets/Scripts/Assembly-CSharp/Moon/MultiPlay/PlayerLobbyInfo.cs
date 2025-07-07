using System.Runtime.InteropServices;
using Fusion;

namespace Moon.MultiPlay
{
	[StructLayout((LayoutKind)2, Size = 260)]
	[NetworkStructWeaved(65)]
	public struct PlayerLobbyInfo : INetworkStruct
	{
		[FieldOffset(0)]
		public NetworkString<_64> LobbyId;
	}
}
