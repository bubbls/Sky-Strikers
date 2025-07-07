using UnityEngine;

namespace Moon.Arena
{
	public class ArenaEyeLookAtBall : MonoBehaviour
	{
		[SerializeField]
		private Transform _originTransform;

		[SerializeField]
		private Transform _idleLookAtTransform;

		[SerializeField]
		private float _speed;

		public void UpdateEyePositionToIdle()
		{
		}

		public void UpdateEyePosition(Vector3 lookAtPosition)
		{
		}

		private void UpdateLookAtDirection(Vector3 targetPosition)
		{
		}
	}
}
