using System;
using DP.Takeaway.Utils;
using UnityEngine;

namespace Moon.CreativeMode
{
	[RequireComponent(typeof(GuidComponent))]
	public class Placeable : InPlaceList<Placeable>
	{
		[Flags]
		private enum State
		{
			None = 0,
			Moving = 1,
			Rotating = 2,
			Scaling = 4
		}

		private GuidComponent _guidComponent;

		private State _state;

		private Transform _interactorAnchor;

		private Transform _placeableAnchor;

		private Vector3 _interactingPosition;

		private Vector3 _placeableScale;

		public string GUID => null;

		protected override void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void SetPose(Pose worldPose)
		{
		}

		public Pose GetPose()
		{
			return default(Pose);
		}

		public void CancelOperations()
		{
		}

		public void ProcessInputAction(Transform head, Transform interactorTransform, MXRInputAction inputAction)
		{
		}

		private void ProcessMoving(Transform interactorTransform)
		{
		}

		private void ProcessRotating()
		{
		}

		private void ProcessScaling(Transform interactorTransform)
		{
		}
	}
}
