using System;
using UnityEngine;
using moveen.core;
using moveen.utils;

namespace moveen.example
{
	[ExecuteInEditMode]
	public class GlobalMotor : OrderedMonoBehaviour
	{
		[Tooltip("Enable position following")]
		public bool move;

		[Tooltip("Movement dynamics")]
		public MotorBean posMotor;

		[NonSerialized]
		public Vector3 speed;

		[Tooltip("Enable rotation following")]
		public bool rotate;

		[Tooltip("Rotation dynamics")]
		public MotorBean rotationMotor;

		[NonSerialized]
		public Vector3 angleSpeed;

		[NonSerialized]
		public Rigidbody rb;

		[BindWarning]
		public Transform target;

		public override void OnEnable()
		{
		}

		public override void tick(float dt)
		{
		}

		public override void OnValidate()
		{
		}

		public override void fixedTick(float dt)
		{
		}
	}
}
