using System.Runtime.InteropServices;
using Fusion;
using Moon.Shop;
using UnityEngine;

namespace Moon.Backpack
{
	[StructLayout((LayoutKind)2, Size = 416)]
	[NetworkStructWeaved(104)]
	public struct LotteryPrizeNetworkStruct : INetworkStruct
	{
		[FieldOffset(0)]
		public NetworkString<_64> FriendlyId;

		[FieldOffset(260)]
		public NetworkString<_32> StackId;

		[FieldOffset(392)]
		public Rarity Rarity;

		[FieldOffset(396)]
		public Vector3 Position;

		[FieldOffset(408)]
		public PlayerRef PlayerRef;

		[FieldOffset(412)]
		public int Amount;
	}
}
