using Chamber8.Framework.Common;
using UnityEngine;

namespace Moon.Player.Ability.Bulwarp
{
	[CreateAssetMenu(menuName = "Moon/Ability/Create Bulwarp Ability Settings", fileName = "BulwarpAbilitySettings", order = 3)]
	public class BulwarpAbilitySettings : SingleScriptableObject<BulwarpAbilitySettings, DefaultResourcePathProvider<BulwarpAbilitySettings>>
	{
		public BulwarpSuitWeaponsGhosts SuitWeaponsGhosts;
	}
}
