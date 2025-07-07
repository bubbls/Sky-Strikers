using UnityEngine;

namespace Moon.Player.Ability.Bulwarp
{
	public class ArenaBulwarpBoundaryLine : MonoBehaviour
	{
		[SerializeField]
		private LineRenderer _lineRenderer;

		private Vector3[] _linePoints;

		private void Start()
		{
		}

		public Vector3 FindNearestPointAlongLine(Vector3 targetPosition)
		{
			return default(Vector3);
		}

		private Vector3 ProjectPointOntoLineSegment(Vector3 point, Vector3 lineStart, Vector3 lineEnd)
		{
			return default(Vector3);
		}

		public bool IsPointInsideLine(Vector3 point)
		{
			return false;
		}

		public bool IsAllPointsInLineArea(Transform[] points)
		{
			return false;
		}

		public bool IsAnyPointInLineArea(Transform[] points)
		{
			return false;
		}
	}
}
