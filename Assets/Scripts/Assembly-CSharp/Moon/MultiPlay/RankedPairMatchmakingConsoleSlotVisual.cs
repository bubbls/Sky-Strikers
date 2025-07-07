using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.MultiPlay
{
	public class RankedPairMatchmakingConsoleSlotVisual : MonoBehaviour
	{
		[SerializeField]
		[Header("State")]
		private GameObject _emptyState;

		[SerializeField]
		private GameObject _hasPlayerState;

		[SerializeField]
		private GameObject _cantPairState;

		[SerializeField]
		private TMP_Text _rankedPairSlotPlayerNameText;

		[SerializeField]
		private TMP_Text _rankedPairSlotMMRText;

		[SerializeField]
		private TMP_Text _rankedPairRankTierText;

		[SerializeField]
		private Image _rankedPairPlayerRankIcon;

		public void SetEmptyState()
		{
		}

		public void UpdateRankedPairMatchmakingSlotUI(bool hasPlayer, string playerName = "", int playerMmr = 0)
		{
		}

		public void ToggleCantPairState(bool enable)
		{
		}
	}
}
