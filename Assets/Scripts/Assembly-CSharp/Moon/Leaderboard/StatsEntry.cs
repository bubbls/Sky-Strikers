using SVGImporter;
using TMPro;
using UnityEngine;

namespace Moon.Leaderboard
{
	public class StatsEntry : FlagTheme
	{
		[SerializeField]
		private LeaderboardNames _leaderboardName;

		[SerializeField]
		private TMP_Text _textStatsName;

		[SerializeField]
		private TMP_Text _textStatsValue;

		[SerializeField]
		private SVGImage _frameSvgImage;

		public void SetNotAvailable()
		{
		}

		public void UpdateStats(PlayerStatistics stats)
		{
		}

		protected override void UpdateThemeVisualInternal(FlagFrameConfiguration configuration)
		{
		}
	}
}
