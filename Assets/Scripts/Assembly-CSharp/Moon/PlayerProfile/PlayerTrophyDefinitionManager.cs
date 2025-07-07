using UnityEngine;

namespace Moon.PlayerProfile
{
	[CreateAssetMenu(fileName = "PlayerTrophyDefinitionManager", menuName = "Moon/Trophies/Create PlayerTrophyDefinitionManager")]
	public class PlayerTrophyDefinitionManager : ScriptableObject
	{
		[SerializeField]
		private PlayerTrophyDefinition[] _trophyDefinitions;

		public PlayerTrophyDefinition[] TrophyDefinitions => null;
	}
}
