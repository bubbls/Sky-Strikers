using UnityEngine;

namespace Moon.Benchmark
{
	public class BallHitBenchmarkMessageData : IMessageData
	{
		public MBall Ball;

		public Vector3 ThrowVelocity;

		public Vector3 ControllerVelocity;

		public Vector3 PlayerBodyVelocity;

		public float VelocityMultiplier;

		public float PlayerBodyVelocityMultiplier;

		public Vector3 AppliedForce;
	}
}
