using Moon.PlayerProfile;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Moon
{
	public class MatchSummaryPlayerPanel : MonoBehaviour
	{
		[SerializeField]
		private GameObject _container;

		[SerializeField]
		[Header("Player Info")]
		private TMP_Text _playerNameText;

		[SerializeField]
		private TMP_Text _playerClassText;

		[Header("MMR")]
		[SerializeField]
		private Image _rankBadgeImage;

		[SerializeField]
		private TMP_Text _rankText;

		[SerializeField]
		private TMP_Text _mmrText;

		[SerializeField]
		private Image _mmrFillImage;

		[SerializeField]
		private TMP_Text _mmrChangeDifferenceText;

		[SerializeField]
		private GameObject _mmrChangeDifferenceWinStreak;

		[SerializeField]
		private TMP_Text _mmrChangeDifferenceWinStreakText;

		[SerializeField]
		private GameObject _mmrChangeDifferenceUnderdog;

		[SerializeField]
		private TMP_Text _mmrChangeDifferenceUnderdogText;

		[SerializeField]
		private TMP_Text _newMMRText;

		[Header("Player Stats")]
		[SerializeField]
		private TMP_Text _goalsText;

		[SerializeField]
		private TMP_Text _assistsText;

		[SerializeField]
		private TMP_Text _savesText;

		[SerializeField]
		private TMP_Text _clearsText;

		[SerializeField]
		private TMP_Text _shotsText;

		[SerializeField]
		private TMP_Text _playerPossessionText;

		[SerializeField]
		private TMP_Text _ratingText;

		[SerializeField]
		[Header("Avatar")]
		private MatchSummaryPlayerAvatar _playerAvatar;

		private const string ForfeitText = "-";

		public void SetPlayerData(MatchResult matchResult, MatchSummaryBoardManager.MatchSummaryPlayerData playerData)
		{
		}

		private void UpdateRankVisual(int mmr)
		{
		}

		private void SetRankBadge(string rankBadgeLevel)
		{
		}

		public void ToggleAvatar(bool enable)
		{
		}

		public void TogglePanel(bool enable)
		{
		}
	}
}
