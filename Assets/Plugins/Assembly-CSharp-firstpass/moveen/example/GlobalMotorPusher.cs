using UnityEngine;
using UnityEngine.Serialization;

namespace moveen.example
{
	public class GlobalMotorPusher : MonoBehaviour, Startable
	{
		[Tooltip("Speed to add")]
		[FormerlySerializedAs("accel")]
		public Vector3 speedToAdd;

		[FormerlySerializedAs("localMotor")]
		[Tooltip("Target GameObject with LocalMotor. If null - this GameObject will be used")]
		public GlobalMotor motor;

		private void OnEnable()
		{
		}

		public void start()
		{
		}
	}
}
