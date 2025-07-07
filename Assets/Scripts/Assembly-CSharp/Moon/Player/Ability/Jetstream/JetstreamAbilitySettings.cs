using Chamber8.Framework.Common;
using UnityEngine;

namespace Moon.Player.Ability.Jetstream
{
	[CreateAssetMenu(menuName = "Moon/Ability/Create Jetstream Ability Settings", fileName = "JetstreamAbilitySettings", order = 2)]
	public class JetstreamAbilitySettings : SingleScriptableObject<JetstreamAbilitySettings, DefaultResourcePathProvider<JetstreamAbilitySettings>>
	{
		[SerializeField]
		private ExplosionConfiguration.ForceConfig _inputAuthorityForceConfig;

		public ExplosionConfiguration.ForceConfig InputAuthorityForceConfig => null;
	}
}
