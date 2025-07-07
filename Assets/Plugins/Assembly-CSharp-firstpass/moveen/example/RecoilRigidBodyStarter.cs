using UnityEngine;
using UnityEngine.Serialization;

namespace moveen.example
{
	public class RecoilRigidBodyStarter : MonoBehaviour, Startable
	{
		[FormerlySerializedAs("accel")]
		[Tooltip("Speed to add")]
		public Vector3 speedToAdd;

		[FormerlySerializedAs("motor1")]
		[Tooltip("Target GameObject with Rigidbody. If null - this GameObject will be used")]
		public Rigidbody rigidBody;

		private void OnEnable()
		{
		}

		public void start()
		{
		}
	}
}
