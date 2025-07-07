using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Player.Pad
{
	public class PlayerPadProfileSummaryPage : PlayerStatsBoardPage
	{
		[Header("Player Info")]
		[SerializeField]
		private TMP_Text _playerNameText;

		[SerializeField]
		private TMP_Text _playerLevelText;

		[SerializeField]
		[Header("Rank Badge")]
		private Image _rankBadgeImage;

		[Header("Basic")]
		[SerializeField]
		private TMP_Text _playedMatchesText;

		[SerializeField]
		private TMP_Text _winRatioText;

		[Header("Rating")]
		[SerializeField]
		private PlayerStatsBoardGraphDrawer _graphDrawer;

		[SerializeField]
		private TMP_Text _ratingText;

		public override void UpdatePageData(PlayerSuitClass suitClass)
		{
		}

		private void SetRankBadge(string rankBadgeLevel)
		{
		}
	}
}
