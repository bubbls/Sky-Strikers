using System;
using UnityEngine;
using moveen.core;

namespace moveen.example
{
	[Serializable]
	public class SurfaceDetector2 : ISurfaceDetector
	{
		[Tooltip("The layer which will be used to detect surface. For example, create a layer for objects you want to walk on and name it as \"ground\" or \"terrain\"")]
		public LayerMask layer;

		[Tooltip("Don't consider back surface as walkable")]
		public bool ignoreBackSurface;

		[Tooltip("A surface can be detected -beyond- origin point. This number states how far beyond detector have to look. Important to consider model size and ceilings height")]
		public float detectOffset;

		[Tooltip("How far detector should look. Important to consider step size")]
		public float maxDetectDistance;

		[Tooltip("Magic for low ceilings and crossed floors")]
		public float preferLowerThanHigher;

		[Tooltip("Maximum number of crosses detected. Consider simplification of your scene instead of increasing of this number")]
		public int bufferSize;

		[NonSerialized]
		private RaycastHit[] buffer;

		[NonSerialized]
		public bool resetMaxFoundHits;

		[NonSerialized]
		public int maxFoundHits;

		public override Vector3 detect(Vector3 input, Vector3 normal)
		{
			return default(Vector3);
		}
	}
}
