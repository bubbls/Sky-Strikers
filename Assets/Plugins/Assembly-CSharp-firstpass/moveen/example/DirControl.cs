using UnityEngine;
using moveen.utils;

namespace moveen.example
{
	public class DirControl : OrderedMonoBehaviour
	{
		[BindWarning]
		[Tooltip("Target GameObject to look at")]
		public Transform target;

		[Tooltip("Maximum allowed angle to rotate (degrees)")]
		public float maxAngle;

		[Tooltip("If target is at larger angle than this, DirControl will cease orientation and will return body to the initial orientation")]
		public float maxPrepareAngle;

		[ReadOnly]
		public float differenceDegrees;

		private Quaternion initialLocalRot;

		public override void OnEnable()
		{
		}

		public override void OnValidate()
		{
		}

		public override void tick(float dt)
		{
		}
	}
}
