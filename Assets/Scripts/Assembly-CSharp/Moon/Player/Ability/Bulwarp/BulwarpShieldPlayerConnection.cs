using UnityEngine;

namespace Moon.Player.Ability.Bulwarp
{
	public class BulwarpShieldPlayerConnection : MonoBehaviour
	{
		[SerializeField]
		private LineRenderer _lineRenderer;

		[SerializeField]
		private Gradient _lineGradient;

		private Transform _shieldTransform;

		private Transform _handTransform;

		private int _gradientCount;

		public void Enable(Transform shieldTransform, Transform handTransform, BulwarpGhostPlaceable.PlacedState placedState)
		{
		}

		public void UpdateLineRenderer(float distance, float maxDistance)
		{
		}

		public void Disable()
		{
		}
	}
}
