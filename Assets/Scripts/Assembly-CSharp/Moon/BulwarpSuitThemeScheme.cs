using DP.Takeaway.Sound;
using UnityEngine;

namespace Moon
{
	[CreateAssetMenu(menuName = "Moon/Theme Schemes/Suit/Create Bulwarp Suit Theme Scheme", fileName = "Suit_Bulwarp", order = 2)]
	public class BulwarpSuitThemeScheme : SuitVisualThemeScheme
	{
		[Header("Bulwarp Specific")]
		[Space(5f)]
		public SoundInfo SfxPlayerSlidingStart;

		public SoundInfo SfxPlayerSliding;

		public SoundInfo SfxPaddleEquipped;
	}
}
