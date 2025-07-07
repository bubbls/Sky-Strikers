using System;
using UnityEngine;

namespace moveen.core
{
	[Serializable]
	public class Wheel
	{
		public float maxSpeed;

		[Tooltip("TODO")]
		public float wheelRotationByBodyDir;

		[Tooltip("The ability of the wheel to get the leg into the comfort position by rotating itself. 0 - the only way is by stepping. 10 - pretty strong ability.")]
		public float wheelRotationByComfort;

		[Tooltip("TODO")]
		public float wheelRotationByComfortSpeed;

		[Tooltip("The ratio of the wheel to steer in the direction of movement. 0 - steer the way the body looks and leave other directions to stepping. 1 - wheel looks at speed direction.")]
		public float wheelRotationByBodySpeed;

		public float wheelAcceleration;

		public float wheelBreak;
	}
}
