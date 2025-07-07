using Moon.Framework.Leaderboard;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Leaderboard
{
	public class HofLeaderboardUIEntry : MonoBehaviour
	{
		[SerializeField]
		private Image? _boarder;

		[SerializeField]
		private Image? _inner;

		[SerializeField]
		private TMP_Text _textPlayerName;

		[SerializeField]
		private TMP_Text? _textValue;

		[SerializeField]
		private TMP_Text? _textPosition;

		[SerializeField]
		private LayoutElement? _layoutElement;

		public void Configure(LeaderboardEntry entry)
		{
		}

		public void Configure(HofLeaderboardUIEntryConfig config, LeaderboardEntry entry)
		{
		}

		private void UpdateLayoutConfig(HofLeaderboardUIEntryConfig config)
		{
		}

		public void Clear()
		{
		}

		public void ClearWithConfig(HofLeaderboardUIEntryConfig config)
		{
		}

		public void SetNoPosition()
		{
		}
	}
}
