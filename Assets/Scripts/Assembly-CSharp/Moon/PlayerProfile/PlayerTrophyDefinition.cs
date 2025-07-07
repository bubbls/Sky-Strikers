using UnityEngine;

namespace Moon.PlayerProfile
{
	[CreateAssetMenu(fileName = "PlayerTrophyDefinition", menuName = "Moon/Trophies/Create PlayerTrophyDefinition")]
	public class PlayerTrophyDefinition : ScriptableObject
	{
		[SerializeField]
		private PlayerTrophyType _trophyType;

		[SerializeField]
		private string _trophyName;

		[SerializeField]
		[TextArea]
		private string _trophyDescription;

		[SerializeField]
		private Sprite _icon;

		public PlayerTrophyType TrophyType => default(PlayerTrophyType);

		public string TrophyName => null;

		public string TrophyDescription => null;

		public Sprite Icon => null;
	}
}
