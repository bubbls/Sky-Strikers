using System.Collections.Generic;
using DP.Takeaway.Sound;
using Moon.Player.Visual;
using UnityEngine;

namespace Moon
{
	[CreateAssetMenu(menuName = "Moon/Theme Schemes/Weapon/Create Jetstream Weapon Theme Scheme", fileName = "SuitWeapon_Jetstream", order = 2)]
	public class JetstreamSuitWeaponVisualThemeScheme : SuitWeaponVisualThemeScheme, ISuitWeaponVisualThemeScheme
	{
		[Space(5f)]
		[Header("Jetstream Specific")]
		public PlayerSuitWeaponVisual _suitWeaponVisual;

		public FxExplosion FxBlastExplosion;

		public SoundInfo SfxSuckingNoBall;

		public SoundInfo SfxSuckingWithBall;

		public SoundInfo SfxExplosion;

		public SoundInfo SfxInBestShotRange;

		public SoundInfo SfxShotFromBestRange;

		public GameObject FxBallControl;

		public PlayerSuitWeaponVisual PlayerSuitWeaponVisual => null;

		public override void GetObjectsToPreload(out List<GameObject> prewarmObjects)
		{
			prewarmObjects = null;
		}
	}
}
