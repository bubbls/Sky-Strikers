using System.Collections.Generic;
using DP.Takeaway.Sound;
using Moon.Arena;
using UnityEngine;

namespace Moon
{
	[CreateAssetMenu(menuName = "Moon/Theme Schemes/Weapon/Create Generic Weapon Theme Scheme", fileName = "SuitWeapon_Generic", order = -1)]
	public class SuitWeaponVisualThemeScheme : VisualThemeScheme, IPrewarmScheme
	{
		[Header("Common")]
		[Space(5f)]
		public PlayerMaterial[] TeamMaterials;

		public BallHitFX BallHitFx;

		public GameObject[] GoalScoredFx;

		public SoundInfo SfxChangeVisual;

		public SoundInfo SfxEquip;

		public SoundInfo SfxHitHard;

		public SoundInfo SfxHitSoft;

		public SoundInfo SfxGoal;

		public SoundInfo SfxNoAmmo;

		public SoundInfo SfxLastAmmoUsed;

		public virtual void GetObjectsToPreload(out List<GameObject> prewarmObjects)
		{
			prewarmObjects = null;
		}
	}
}
