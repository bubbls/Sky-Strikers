using System.Collections.Generic;
using Moon.Arena;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Moon
{
	public class MatchSummaryTeamBoard : MonoBehaviour
	{
		[SerializeField]
		private TeamNo _teamNo;

		[SerializeField]
		private Image _backgroundImage;

		[SerializeField]
		private Color _winColor;

		[SerializeField]
		private Color _loseColor;

		[SerializeField]
		private Sprite _winSprite;

		[SerializeField]
		private Sprite _loseSprite;

		[SerializeField]
		private TMP_Text _matchResultText;

		[SerializeField]
		private TMP_Text _blueTeamScoreText;

		[SerializeField]
		private TMP_Text _blueTeamPossessionText;

		[SerializeField]
		private TMP_Text _redTeamScoreText;

		[SerializeField]
		private TMP_Text _redTeamPossessionText;

		[SerializeField]
		private MatchSummaryPlayerPanel _mvpPanel;

		[SerializeField]
		private List<MatchSummaryPlayerPanel> _playerPanels;

		[SerializeField]
		private GameObject _underDogFlag;

		public void SetData(MatchSummaryBoardManager.MatchSummaryBoardData teamBoardData)
		{
		}

		private void TogglePlayerPanel(MatchSummaryPlayerPanel playerPanel, bool enable)
		{
		}
	}
}
