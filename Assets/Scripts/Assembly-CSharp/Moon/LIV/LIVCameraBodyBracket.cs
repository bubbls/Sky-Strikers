using Moon.Interaction;
using UnityEngine;

namespace Moon.LIV
{
	public class LIVCameraBodyBracket : LocalGrabbable
	{
		[SerializeField]
		private GameObject _container;

		[SerializeField]
		private float _checkDistance;

		[SerializeField]
		private Vector3 _leftHandGrabOffset;

		[SerializeField]
		private Vector3 _rightHandGrabOffset;

		[SerializeField]
		private Vector3 _grabRotation;

		private float _grabOutTimer;

		private float _distance;

		private bool _isLeftHand;

		public bool CanInteract { get; private set; }

		protected override void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnLIVCameraReleased()
		{
		}

		private void HandleOnPutBackOnBodyBracket()
		{
		}

		private void HandleOnForcePlacedInWorld()
		{
		}

		protected override void HandleOnGrabbedInternal()
		{
		}

		public override bool CanBeGrabbedByInteractor(MGrabInteractor interactor)
		{
			return false;
		}

		protected override void HandleOnReleaseInternal()
		{
		}

		private void Toggle(bool enable)
		{
		}
	}
}
