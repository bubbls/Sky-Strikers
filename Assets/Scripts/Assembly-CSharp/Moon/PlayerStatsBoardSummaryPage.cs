using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Moon
{
	public class PlayerStatsBoardSummaryPage : PlayerStatsBoardPage
	{
		[Header("Player Info")]
		[SerializeField]
		private TMP_Text _playerNameText;

		[SerializeField]
		private TMP_Text _playerLevelText;

		[Header("Rank Badge")]
		[SerializeField]
		private Image _rankBadgeImage;

		[Header("Basic")]
		[SerializeField]
		private TMP_Text _playedMatchesText;

		[SerializeField]
		private TMP_Text _winRatioText;

		[Header("3 Key Stats")]
		[SerializeField]
		private TMP_Text _avgGoalsText;

		[SerializeField]
		private TMP_Text _totalGoalsText;

		[SerializeField]
		private TMP_Text _avgAssistsText;

		[SerializeField]
		private TMP_Text _totalAssistsText;

		[SerializeField]
		private TMP_Text _avgSavesText;

		[SerializeField]
		private TMP_Text _totalSavesText;

		[Header("Side Stats")]
		[SerializeField]
		private TMP_Text _avgShotsText;

		[SerializeField]
		private TMP_Text _totalShotsText;

		[SerializeField]
		private TMP_Text _avgPrecisionText;

		[SerializeField]
		private TMP_Text _avgECPMText;

		[SerializeField]
		private TMP_Text _energyEfficiencyText;

		[SerializeField]
		private TMP_Text _avgPlayerPossessionText;

		[SerializeField]
		[Header("Rating")]
		private PlayerStatsBoardGraphDrawer _graphDrawer;

		[SerializeField]
		private TMP_Text _ratingText;

		[Header("Bottom Bar Stats")]
		[SerializeField]
		private TMP_Text _totalHatTricksText;

		[SerializeField]
		private TMP_Text _totalShutoutsText;

		[SerializeField]
		private TMP_Text _mvpsText;

		[SerializeField]
		private TMP_Text _winScoreDiffText;

		[SerializeField]
		private TMP_Text _loseScoreDiffText;

		[SerializeField]
		private TMP_Text _highestWinStreakText;

		[SerializeField]
		private TMP_Text _avgClearsText;

		public override void UpdatePageData(PlayerSuitClass suitClass)
		{
		}

		private void SetRankBadge(string rankBadgeLevel)
		{
		}
	}
}
