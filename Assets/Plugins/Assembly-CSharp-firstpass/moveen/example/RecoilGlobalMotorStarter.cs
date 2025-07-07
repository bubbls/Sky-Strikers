using UnityEngine;
using UnityEngine.Serialization;

namespace moveen.example
{
	public class RecoilGlobalMotorStarter : MonoBehaviour, Startable
	{
		[FormerlySerializedAs("accel")]
		[Tooltip("Speed to add")]
		public Vector3 speedToAdd;

		[FormerlySerializedAs("motor1")]
		[Tooltip("Target GameObject with GlobalMotor. If null - this GameObject will be used")]
		public GlobalMotor globalMotor;

		private void OnEnable()
		{
		}

		public void start()
		{
		}
	}
}
