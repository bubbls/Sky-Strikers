using Chamber8.Framework.Common;
using UnityEngine;

namespace Moon
{
	public class VelocityTracker : MonoBehaviour
	{
		[SerializeField]
		private Transform _trackingSpace;

		[SerializeField]
		private float _throwVelocityExpireTime;

		[SerializeField]
		private bool _drawGizmos;

		private bool _ignoreNextFrame;

		private Vector3 _lastPosition;

		private RingBuffer<Vector3> _velocityBuffer;

		private Vector3 _cachedPosition;

		private Vector3 _velocity;

		private Vector3 _cachedTotal;

		private int _capacity;

		private void Start()
		{
		}

		public void Clear()
		{
		}

		public void SetTrackingSpace(Transform space)
		{
		}

		private Vector3 GetPosition()
		{
			return default(Vector3);
		}

		private void FixedUpdate()
		{
		}

		public Vector3 ThrowVelocity()
		{
			return default(Vector3);
		}

		public void SetSmoothWindow(float smoothWindow)
		{
		}

		public void IgnoreNextFrame()
		{
		}

		private void OnDrawGizmos()
		{
		}

		private void DrawThrowVelocity()
		{
		}
	}
}
