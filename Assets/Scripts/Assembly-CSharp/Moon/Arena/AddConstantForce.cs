using NaughtyAttributes;
using UnityEngine;

namespace Moon.Arena
{
	[RequireComponent(typeof(ConstantForce))]
	public class AddConstantForce : MonoBehaviour
	{
		[SerializeField]
		private Vector3 _force;

		[SerializeField]
		private Vector3 _torque;

		private ConstantForce _constantForce;

		public Vector3 Force => default(Vector3);

		private void Awake()
		{
		}

		public void SetConstantForce(Vector3 force)
		{
		}

		[Button("Update constant forces", EButtonEnableMode.Always)]
		private void UpdateConstantForce()
		{
		}
	}
}
