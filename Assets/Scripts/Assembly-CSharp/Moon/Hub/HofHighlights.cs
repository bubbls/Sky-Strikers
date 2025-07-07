using Moon.Leaderboard;
using TMPro;
using UnityEngine;

namespace Moon.Hub
{
	public class HofHighlights : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _topPlayersTitleText;

		[SerializeField]
		private HofHighlightsEntry[] _topPlayersEntries;

		[SerializeField]
		private ManualButton _switchTopPlayersButton;

		[SerializeField]
		private HofPlayerInfo[] _featuredPlayerInfos;

		private HofHighlightsData _hofHighlightsData;

		private int _highlightsIndex;

		private void Start()
		{
		}

		private void SwitchTopPlayersButton_OnPressed()
		{
		}

		private void SetupHighlights(HofHighlightTopPlayersCollection topPlayersCollection)
		{
		}
	}
}
