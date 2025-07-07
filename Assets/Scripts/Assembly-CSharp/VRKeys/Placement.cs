using System;
using UnityEngine;

namespace VRKeys
{
	public class Placement : MonoBehaviour
	{
		[Serializable]
		public class PlacementSettings
		{
			public Vector3 position;

			public Quaternion rotation;

			public Vector3 scale;
		}

		public float minScale;

		public float maxScale;

		public Mallet leftMallet;

		public Mallet rightMallet;

		public HandCollider leftHandCollider;

		public HandCollider rightHandCollider;

		public PlacementSettings settings;

		private Keyboard keyboard;

		private Mallet.MalletHand positioningHand;

		private Vector3 previousPosition;

		private float previousRotationX;

		private Vector3 initialScale;

		private float applyScale;

		private float initialHandDistance;

		private float initialApplyScale;

		private string prefsKey;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void PositionWith(Vector3 handPosition, Quaternion handRotation, Mallet.MalletHand hand)
		{
		}

		private void Resize()
		{
		}

		private void ResetState()
		{
		}

		private void SaveChanges()
		{
		}
	}
}
