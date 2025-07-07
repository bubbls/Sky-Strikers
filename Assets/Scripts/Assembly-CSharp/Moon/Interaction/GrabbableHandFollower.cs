using UnityEngine;

namespace Moon.Interaction
{
	public class GrabbableHandFollower : MonoBehaviour, IGrabbableEventListener
	{
		[SerializeField]
		private Transform _followVisual;

		[SerializeField]
		private Transform _followVisualDefaultParent;

		[SerializeField]
		private LineRenderer _lineRenderer;

		[SerializeField]
		private Transform _lineRendererStartPoint;

		[SerializeField]
		private Transform _lineRendererEndPoint;

		[SerializeField]
		private Transform _offsetTransform;

		[SerializeField]
		private Transform _grabbedOffsetReference;

		private MGrabInteractor _interactor;

		private bool _isGrabbed;

		void IGrabbableEventListener.Initialize(bool isGrabbed, MGrabInteractor grabInteractor)
		{
		}

		public Vector3 FollowVisualPosition()
		{
			return default(Vector3);
		}

		private void LateUpdate()
		{
		}

		void IGrabbableEventListener.HandleOnGrabbed(MGrabInteractor grabInteractor)
		{
		}

		void IGrabbableEventListener.HandleOnRelease(MGrabInteractor grabInteractor)
		{
		}

		private void UpdateLineRenderer()
		{
		}
	}
}
