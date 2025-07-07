using TMPro;
using UnityEngine;

namespace Moon.Hub
{
	public class HofHighlightsEntry : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _indexText;

		[SerializeField]
		private TMP_Text _playerNameText;

		[SerializeField]
		private TMP_Text _scoreText;

		public void SetInfo(int index, string playerName, string score)
		{
		}

		public void Hide()
		{
		}
	}
}
