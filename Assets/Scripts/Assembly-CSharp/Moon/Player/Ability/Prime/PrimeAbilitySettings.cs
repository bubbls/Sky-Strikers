using Chamber8.Framework.Common;
using UnityEngine;

namespace Moon.Player.Ability.Prime
{
	[CreateAssetMenu(menuName = "Moon/Ability/Create Prime Ability Settings", fileName = "PrimeAbilitySettings", order = 1)]
	public class PrimeAbilitySettings : SingleScriptableObject<PrimeAbilitySettings, DefaultResourcePathProvider<PrimeAbilitySettings>>
	{
		[SerializeField]
		private MPrimeMissile _primeMissilePrefab;

		[SerializeField]
		private MissileConfig _missileConfig;

		[SerializeField]
		private float _explosionRadius;

		public MPrimeMissile PrimeMissilePrefab => null;

		public MissileConfig MissileConfig => null;

		public float ExplosionRadius => 0f;
	}
}
