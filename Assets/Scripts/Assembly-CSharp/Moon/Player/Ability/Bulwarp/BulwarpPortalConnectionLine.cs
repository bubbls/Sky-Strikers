using UnityEngine;

namespace Moon.Player.Ability.Bulwarp
{
	public class BulwarpPortalConnectionLine : MonoBehaviour
	{
		[SerializeField]
		private LineRenderer _connectionLine;

		private BulwarpGhostPlaceable _ghostShield;

		private MBulwarpShield _bulwarpShield;

		private BulwarpGhostPlaceable _ghostPortal;

		private MBulwarpStandalonePortal _standalonePortal;

		private bool _isShowingConnectionLine;

		private Transform _connectionLineStartPoint;

		private Transform _connectionLineEndPoint;

		public void Initialize(BulwarpGhostPlaceableShield ghostPlaceableShield, MBulwarpShield bulwarpShield, BulwarpGhostPlaceablePortal ghostPlaceablePortal, MBulwarpStandalonePortal standalonePortal)
		{
		}

		public void Dispose()
		{
		}

		private void LateUpdate()
		{
		}

		public void UpdateGhostPortalConnectionLine()
		{
		}

		private void ShowConnectionLine(Transform startPoint, Transform endPoint)
		{
		}

		private void HideConnectionLine()
		{
		}
	}
}
