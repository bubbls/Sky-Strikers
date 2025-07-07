using UnityEngine;

namespace Moon.Player.Ability.Bulwarp
{
	public class BulwarpSuitWeaponsGhosts : MonoBehaviour
	{
		[SerializeField]
		private BulwarpGhostPlaceableShield _ghostShield;

		[SerializeField]
		private BulwarpGhostPlaceablePortal _ghostPortal;

		[SerializeField]
		private BulwarpShieldPlayerConnection _shieldPlayerConnection;

		[SerializeField]
		private BulwarpPortalConnectionLine _portalConnectionLine;

		public BulwarpGhostPlaceableShield GhostShield => null;

		public BulwarpGhostPlaceablePortal GhostPortal => null;

		public void SetReferences(MBulwarpShield shield, MBulwarpStandalonePortal standalonePortal)
		{
		}

		private void OnDisable()
		{
		}

		public void UpdateGhostPortalConnectionLine()
		{
		}

		public void HideShieldPlayerConnection()
		{
		}

		public void SetPlaceableTheme(SuitWeaponVisualTheme suitWeaponVisualTheme)
		{
		}

		public void HideAll()
		{
		}
	}
}
