using Moon.AI.VisualScripting;
using UnityEngine;

namespace Moon.Player.Ability.Jetstream
{
	public class JetstreamBallSuckerBallArea : MonoBehaviour
	{
		[SerializeField]
		private OverlapShapeDesc _overlapShapeDesc;

		[SerializeField]
		private float _startBoxOffset;

		[SerializeField]
		private Vector3 _minExtents;

		private Vector3 _targetOffset;

		private Vector3 _targetExtents;

		private Vector3 _ballDirection;

		private Vector3 _ballPoint;

		private Vector3 _currentExtents;

		private Vector3 _currentOffset;

		private bool _isInitialized;

		public OverlapShapeDesc OverlapShapeDesc => null;

		public void Initialize()
		{
		}

		public bool IsBallInArea(MBall ball)
		{
			return false;
		}

		public void SetScale(float t)
		{
		}
	}
}
