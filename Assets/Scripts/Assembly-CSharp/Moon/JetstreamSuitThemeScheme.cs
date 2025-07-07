using DP.Takeaway.Sound;
using UnityEngine;

namespace Moon
{
	[CreateAssetMenu(menuName = "Moon/Theme Schemes/Suit/Create Jetstream Suit Theme Scheme", fileName = "Suit_Jetstream", order = 2)]
	public class JetstreamSuitThemeScheme : SuitVisualThemeScheme
	{
		[Header("Jetstream Specific")]
		[Space(5f)]
		public SoundInfo SfxBoostStart;

		public SoundInfo SfxBoostLoop;

		public SoundInfo SfxBoostEnd;

		public SoundInfo SfxBoostFilled;

		public SoundInfo SfxBoostEmpty;
	}
}
