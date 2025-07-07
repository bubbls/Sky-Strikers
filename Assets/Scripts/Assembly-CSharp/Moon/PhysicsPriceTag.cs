using UnityEngine;

namespace Moon
{
	[ExecuteInEditMode]
	public class PhysicsPriceTag : MonoBehaviour
	{
		[SerializeField]
		private int _pointsCount;

		[SerializeField]
		[ContextMenuItem("Refresh Visuals", "DrawLineRender")]
		private LineRenderer _lineRenderer;

		[SerializeField]
		private Transform _bezierCurvePoint1;

		[SerializeField]
		private Transform _bezierCurvePoint2;

		[SerializeField]
		private Transform _bezierCurvePoint3;

		private void LateUpdate()
		{
		}

		private void DrawLineRender()
		{
		}

		private void DrawQuadraticBezierCurve(Vector3 point1, Vector3 point2, Vector3 point3)
		{
		}
	}
}
