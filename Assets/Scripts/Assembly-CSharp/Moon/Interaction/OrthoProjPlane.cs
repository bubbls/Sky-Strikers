using NaughtyAttributes;
using UnityEngine;

namespace Moon.Interaction
{
	public class OrthoProjPlane : MonoBehaviour
	{
		[SerializeField]
		private bool _hasProjBoundary;

		[SerializeField]
		[ShowIf("_hasProjBoundary")]
		private Vector2 _boundary;

		[SerializeField]
		private bool _drawSolidGizmo;

		[SerializeField]
		private Color _gizmoColor;

		[SerializeField]
		[HideIf("_hasProjBoundary")]
		private float _gizmoScale;

		public bool GetClosestPointOnPlane(Vector3 position, out Vector3 projectedPosition)
		{
			projectedPosition = default(Vector3);
			return false;
		}

		private void OnDrawGizmos()
		{
		}
	}
}
