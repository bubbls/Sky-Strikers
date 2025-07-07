using System.Runtime.InteropServices;
using Fusion;

namespace Moon.Player.Ability
{
	[StructLayout((LayoutKind)2, Size = 60)]
	[NetworkStructWeaved(15)]
	public struct WeaponVisualRelatedData : INetworkStruct
	{
		[FieldOffset(0)]
		public OverlapShapeDescData ItemOsdData;
	}
}
