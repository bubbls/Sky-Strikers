using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.PlayerProfile
{
	public class PlayerTrophy : MonoBehaviour
	{
		[SerializeField]
		private PlayerTrophyType _trophyType;

		[SerializeField]
		private TMP_Text _nameText;

		[SerializeField]
		private TMP_Text _statsText;

		[SerializeField]
		private TMP_Text _descriptionText;

		[SerializeField]
		private Image _icon;

		public PlayerTrophyType TrophyType => default(PlayerTrophyType);

		public void Initialize(PlayerTrophyDefinition trophyDefinition)
		{
		}

		public void UpdateStats(string stats)
		{
		}
	}
}
