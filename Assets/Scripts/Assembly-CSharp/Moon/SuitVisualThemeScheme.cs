using System.Collections.Generic;
using DP.Takeaway.Sound;
using Moon.Arena;
using Moon.Player.Visual;
using UnityEngine;

namespace Moon
{
	[CreateAssetMenu(menuName = "Moon/Theme Schemes/Suit/Create Generic Suit Theme Scheme", fileName = "Suit_Generic", order = -1)]
	public class SuitVisualThemeScheme : VisualThemeScheme, IPrewarmScheme
	{
		[Header("Common")]
		[Space(5f)]
		public PlayerSuitArmVisual SuitArmVisual;

		public PlayerSuitHandVisual LeftHand;

		public PlayerSuitHandVisual RightHand;

		public PlayerMaterial[] TeamMaterials;

		public SoundInfo SfxChangeVisual;

		public GameObject[] ChangeLocationTeleportFx;

		public GameObject[] TeleportToFieldFx;

		public GameObject[] BornTeleportFx;

		public Sprite[] PlayerPortraits;

		public SoundInfo SfxHitHard;

		public SoundInfo SfxHitSoft;

		public BallHitFX BallHitFx;

		public virtual void GetObjectsToPreload(out List<GameObject> prewarmObjects)
		{
			prewarmObjects = null;
		}
	}
}
