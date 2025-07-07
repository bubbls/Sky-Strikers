using UnityEngine;

namespace Moon.Arena
{
	public class BallTrailSimulator : MonoBehaviour
	{
		private enum SimType
		{
			Vertical = 0,
			Horizontal = 1,
			Circle = 2
		}

		[SerializeField]
		private SimType _simType;

		[SerializeField]
		private float _amplitude;

		[SerializeField]
		private float _simulatedBallVelocity;

		[SerializeField]
		private float _simulationSpeed;

		[SerializeField]
		private float _radius;

		private Vector3 _startPos;

		private float _angle;

		public static bool HasInstance { get; private set; }

		public static BallTrailSimulator Instance { get; private set; }

		public float SimulatedBallVelocity => 0f;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}
	}
}
