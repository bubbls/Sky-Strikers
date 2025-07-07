using UnityEngine;
using moveen.descs;
using moveen.utils;

namespace moveen.example
{
	public class MoveenBridle1 : MonoBehaviour
	{
		[Tooltip("Driven animation")]
		[BindWarning]
		public MoveenStepper5 moveenStepper5;

		[Tooltip("Coefficient to convert distance to speed")]
		public float distanceToSpeed;

		[Tooltip("Maximum speed dictated by this bridle")]
		public float maxSpeed;

		public bool dbgRotation;

		public void FixedUpdate()
		{
		}

		public void OnDrawGizmos()
		{
		}
	}
}
