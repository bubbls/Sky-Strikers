using System;
using System.Collections.Generic;
using DP.Takeaway.Sound;
using Moon.Player.Ability.Bulwarp;
using UnityEngine;

namespace Moon
{
	[CreateAssetMenu(menuName = "Moon/Theme Schemes/Weapon/Create Bulwarp Weapon Theme Scheme", fileName = "SuitWeapon_Bulwarp", order = 2)]
	public class BulwarpSuitWeaponVisualThemeScheme : SuitWeaponVisualThemeScheme
	{
		[Serializable]
		public class ShieldMaterials
		{
			public Material Default;

			public Material WaitingForPortal;

			public Material SpawningMaterial;

			public Material HologramMaterial;
		}

		[Space(5f)]
		[Header("Bulwarp Specific")]
		public BulwarpPlaceableShieldVisual ShieldVisual;

		public BulwarpPlaceablePortalVisual PortalVisual;

		public SoundInfo SfxPlayerTeleport;

		public SoundInfo SfxBallTeleport;

		public SoundInfo SfxGhostPlacementPerfect;

		public SoundInfo SfxGhostPlacementAcceptable;

		public SoundInfo SfxGhostPlacementUnacceptable;

		public SoundInfo SfxPortalActivated;

		public SoundInfo SfxShieldPlaced;

		public SoundInfo SfxShieldNoCharge;

		public SoundInfo SfxShieldCharged;

		public GameObject[] MuzzleFlashFx;

		public ShieldMaterials[] ShieldVisualMaterials;

		public override void GetObjectsToPreload(out List<GameObject> prewarmObjects)
		{
			prewarmObjects = null;
		}
	}
}
