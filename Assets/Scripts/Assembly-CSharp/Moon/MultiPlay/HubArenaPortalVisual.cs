using UnityEngine;

namespace Moon.MultiPlay
{
	public class HubArenaPortalVisual : MonoBehaviour
	{
		[SerializeField]
		private GameObject _teleportInActiveVisuals;

		[SerializeField]
		private GameObject _teleportActiveVisuals;

		[SerializeField]
		private PortalLifetimeVisual[] _portalLifetimeVisuals;

		[SerializeField]
		private Transform _visualsContainer;

		[SerializeField]
		private AnimationCurve _activePortalSizeCurve;

		[SerializeField]
		private AnimationCurve _inactivePortalSizeCurve;

		[SerializeField]
		private float _portalSizeChangeSpeed;

		[SerializeField]
		private Transform _portalToPointConnectionVisual;

		[SerializeField]
		private float _connectionVisualScaleOffset;

		[SerializeField]
		private bool _showConnectionLine;

		private float _portalLifetimeRemainingNormalized;

		private float _portalTargetScale;

		private AnimationCurve _targetCurve;

		public void Initialize()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void LateUpdate()
		{
		}

		public void ToggleActivePortalVisuals(bool enable)
		{
		}

		public void VisualizeCharge(float charge)
		{
		}

		public void SetPortalConnectPoint(Vector3 targetPosition)
		{
		}

		public void HidePortalConnectionVisual()
		{
		}
	}
}
