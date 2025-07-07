using System;
using UnityEngine;
using moveen.core;

namespace moveen.example
{
	[Serializable]
	public class SurfaceDetector1 : ISurfaceDetector
	{
		[Tooltip("The layer which will be used to detect surface. For example, create a layer for objects you want to walk on and name it as \"ground\" or \"terrain\"")]
		public LayerMask layer;

		public override Vector3 detect(Vector3 input, Vector3 normal)
		{
			return default(Vector3);
		}
	}
}
