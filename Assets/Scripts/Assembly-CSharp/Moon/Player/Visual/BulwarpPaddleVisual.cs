using Moon.AI.VisualScripting;
using Moon.Arena;
using UnityEngine;

namespace Moon.Player.Visual
{
	public class BulwarpPaddleVisual : MonoBehaviour, IWeaponVisualWithVelocityTracker, IWeaponVisual
	{
		[SerializeField]
		protected PlayerMaterials _playerMaterials;

		[SerializeField]
		private VelocityTracker _velocityTracker;

		[SerializeField]
		private OverlapShapeDesc _itemOsd;

		private bool _shouldShowWeapon;

		private bool _isWeaponSpawnedOnServer;

		private TeamNo _teamNo;

		private SuitVisualTheme _suitVisualTheme;

		public GameObject GameObject => null;

		public VelocityTracker VelocityTracker => null;

		public OverlapShapeDesc ItemOsd => null;

		public void Initialize(SuitVisualTheme visualTheme)
		{
		}

		public void EnableOutlineSilhouette()
		{
		}

		public void SetTeamColor(TeamNo teamNo)
		{
		}

		public void ToggleSpawnedOnServerVisuals(bool isSpawnedOnServer)
		{
		}

		public void Show()
		{
		}

		public void Hide(bool instant)
		{
		}

		public void ClearVelocityTracker()
		{
		}

		public Vector3 GetWeaponSpecificVelocity()
		{
			return default(Vector3);
		}

		public void DisableVelocityTracker()
		{
		}
	}
}
