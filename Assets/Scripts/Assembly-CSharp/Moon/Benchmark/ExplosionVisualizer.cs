using UnityEngine;

namespace Moon.Benchmark
{
	public class ExplosionVisualizer : MonoBehaviour
	{
		private static ExplosionVisualizer _instance;

		[SerializeField]
		private Transform _explosionSphere;

		[SerializeField]
		private Transform _explosionSphereUpIndicator;

		[SerializeField]
		private Transform _ballVisual;

		[SerializeField]
		private Transform _ballHitPoint;

		[SerializeField]
		private LineRenderer _ballMoveDirLineRenderer;

		[SerializeField]
		private bool _visualizeBall;

		[SerializeField]
		private Transform _playerVisual;

		[SerializeField]
		private Transform _playerHitPoint;

		[SerializeField]
		private LineRenderer _playerMoveDirLineRenderer;

		[SerializeField]
		private bool _visualizePlayer;

		[SerializeField]
		private Transform _missileHitIndicator;

		private void Awake()
		{
		}

		public static void Clear()
		{
		}

		public static void SetExplosionPoint(Vector3 position, Vector3 upDirection, float radius)
		{
		}

		public static void VisualizeBallHitResult(Vector3 ballPosition, Vector3 hitPosition, Vector3 ballVelocity, Vector3 force)
		{
		}

		public static void VisualizePlayerHitResult(Vector3 playerPosition, Quaternion playerRotation, Vector3 hitPoint, Vector3 force)
		{
		}

		public static void SetMissileHitPosition(Vector3 hitPos)
		{
		}
	}
}
