using System;
using System.Runtime.InteropServices;
using Fusion;
using Moon.Bootstrap;

namespace Moon
{
	[Serializable]
	[StructLayout((LayoutKind)2, Size = 56)]
	[NetworkStructWeaved(14)]
	public struct PlayerVisualsConfig : INetworkStruct
	{
		[FieldOffset(0)]
		public PlayerVisualsAvatarHeadData Head;

		[FieldOffset(8)]
		public PlayerVisualsAvatarBodyData Body;

		[FieldOffset(16)]
		public PlayerVisualsAvatarLegData Leg;

		[FieldOffset(24)]
		public PlayerVisualsSuitPartData Suit;

		[FieldOffset(32)]
		public PlayerVisualsSuitWeaponData SuitWeapon;

		[FieldOffset(40)]
		public PlayerVisualsBackpackData Backpack;

		[FieldOffset(48)]
		public PlayerVisualsNameTagData NameTag;

		public void ChangeSkinVisualsWithPreset(PlayerVisualsSkinPreset preset)
		{
		}

		public void ChangeHeldWeaponVisualsWithPreset(PlayerVisualsSuitWeaponPreset preset)
		{
		}

		public void ChangeHeldWeaponVisuals(PlayerVisualsSuitWeaponData suitWeaponData)
		{
		}

		public void ChangeHeadVisualsWithPreset(PlayerVisualsAvatarHeadPreset headPreset)
		{
		}

		public void ChangeBodyVisualsWithPreset(PlayerVisualsAvatarBodyPreset bodyPreset)
		{
		}

		public void ChangeLegVisualsWithPreset(PlayerVisualsAvatarLegPreset legPreset)
		{
		}

		public void ChangeBackpackVisualsWithPreset(PlayerVisualsBackpackPreset preset)
		{
		}

		public void ChangeBackpackVisuals(PlayerVisualsBackpackData backpackData)
		{
		}

		public void ChangeNameTagVisualsWithPreset(PlayerVisualsNameTagPreset nameTagPreset)
		{
		}

		public void CopyVisualConfig(PlayerVisualsConfig visualsConfig)
		{
		}

		public bool CanBeSaved()
		{
			return false;
		}

		public bool HasDifferentVisuals(PlayerVisualsConfig configToCompare)
		{
			return false;
		}

		public ConnectionTokenVisualsConfig ToConnectionTokenVisualsConfig()
		{
			return default(ConnectionTokenVisualsConfig);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
