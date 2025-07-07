using System.Collections.Generic;
using DP.Takeaway.Sound;
using UnityEngine;

namespace Moon
{
	[CreateAssetMenu(menuName = "Moon/Theme Schemes/Suit/Create Prime Suit Theme Scheme", fileName = "Suit_Prime", order = 2)]
	public class PrimeSuitThemeScheme : SuitVisualThemeScheme
	{
		[Space(5f)]
		[Header("Prime Specific")]
		public GameObject[] MuzzleFlashFx;

		public MissileVisual MissileVisual;

		public SoundInfo SfxFireBullet;

		public FxExplosion MissileExplosionFx;

		public override void GetObjectsToPreload(out List<GameObject> prewarmObjects)
		{
			prewarmObjects = null;
		}
	}
}
