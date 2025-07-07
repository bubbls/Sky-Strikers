using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace moveen.core
{
	[Serializable]
	public class JunctionSimpleSpider : JunctionBase
	{
		[Tooltip("Rotation axis. It defines \"up\" for this joint.\nIt is a good idea to keep this (0, 1, 0) and do an actual orientation with game object rotation.")]
		public Vector3 axisRel;

		[HideInInspector]
		public Vector3 axisAbs;

		[FormerlySerializedAs("axisForwardRel")]
		[FormerlySerializedAs("axisForward")]
		[Tooltip("Axis that takes precedence when the target is closer to the pole of the joint. It is a good idea to keep it (1, 0, 0) (if the axis is kept (0, 1, 0)) and do an orientation by the game object rotation.")]
		public Vector3 secondaryAxisRel;

		[HideInInspector]
		public Vector3 secondaryAxisAbs;

		[HideInInspector]
		public Vector3 lastResult;

		[Range(0.1f, 50f)]
		[Tooltip("Axis reaction speed if the target is around the equator")]
		public float rotSpeedAtEquator;

		[Range(0.1f, 50f)]
		[Tooltip("Axis reaction speed if the target is around the pole")]
		public float rotSpeedAtPole;

		[Range(0f, 10f)]
		[Tooltip("Precedence strength of the pole axis (0 - the pole axis is off)")]
		public float poleAxisStrength;

		public override void tick(float dt)
		{
		}

		public override void calcAbs(float dt, Vector3 pos, Quaternion rot)
		{
		}
	}
}
