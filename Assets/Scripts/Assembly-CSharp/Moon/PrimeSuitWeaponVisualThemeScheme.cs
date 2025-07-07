using DP.Takeaway.Sound;
using Moon.Player.Visual;
using UnityEngine;

namespace Moon
{
	[CreateAssetMenu(menuName = "Moon/Theme Schemes/Weapon/Create Prime Weapon Theme Scheme", fileName = "SuitWeapon_Prime", order = 2)]
	public class PrimeSuitWeaponVisualThemeScheme : SuitWeaponVisualThemeScheme, ISuitWeaponVisualThemeScheme
	{
		[Space(5f)]
		[Header("Prime Specific")]
		public PlayerSuitWeaponVisual _suitWeaponVisual;

		public SoundInfo SfxSwingBat;

		public PlayerSuitWeaponVisual PlayerSuitWeaponVisual => null;
	}
}
