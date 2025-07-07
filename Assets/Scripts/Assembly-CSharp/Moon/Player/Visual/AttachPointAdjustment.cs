using System;
using UnityEngine;

namespace Moon.Player.Visual
{
	[Serializable]
	public class AttachPointAdjustment
	{
		[Flags]
		private enum AdjustmentType
		{
			Rotation = 1,
			Position = 2
		}

		[SerializeField]
		private Transform _transform;

		[SerializeField]
		private Vector3 _rotation;

		[SerializeField]
		private Vector3 _localPosition;

		[SerializeField]
		private AdjustmentType _adjustmentType;

		public void AdjustTransform()
		{
		}
	}
}
