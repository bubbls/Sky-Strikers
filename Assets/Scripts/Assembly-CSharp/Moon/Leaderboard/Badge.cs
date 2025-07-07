using SVGImporter;
using TMPro;
using UnityEngine;

namespace Moon.Leaderboard
{
	public class Badge : FlagTheme
	{
		[SerializeField]
		private LeaderboardNames _leaderboardName;

		[SerializeField]
		private SVGImage _iconSvgImage;

		[SerializeField]
		private TMP_Text _textName;

		[SerializeField]
		private GameObject _questionMark;

		private BadgeLevels.Level _badgeLevel;

		private void Awake()
		{
		}

		public void Initialize()
		{
		}

		public void UpdateBadge(PlayerStatistics statistics)
		{
		}

		private void UpdateBadgeVisual()
		{
		}

		public void SetNotAvailable()
		{
		}

		protected override void UpdateThemeVisualInternal(FlagFrameConfiguration configuration)
		{
		}
	}
}
