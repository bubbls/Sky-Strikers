using UnityEngine;

namespace Moon.Interaction
{
	public class AttractingPositions : MonoBehaviour
	{
		[SerializeField]
		private Color _gizmoColor;

		[SerializeField]
		private float _gizmoScale;

		public Vector3 GetClosestPosition(Vector3 position, out Transform closestTransform)
		{
			closestTransform = null;
			return default(Vector3);
		}

		private void OnDrawGizmos()
		{
		}
	}
}
