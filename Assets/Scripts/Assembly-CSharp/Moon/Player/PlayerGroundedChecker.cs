using UnityEngine;

namespace Moon.Player
{
	public class PlayerGroundedChecker : MonoBehaviour
	{
		[SerializeField]
		private float _groundedCheckOffset;

		[SerializeField]
		private float _groundedCheckRayLength;

		private readonly RaycastHit[] _hits;

		private Ray _cachedRay;

		public bool IsGrounded { get; private set; }

		private void LateUpdate()
		{
		}

		private void CheckIfGrounded()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
