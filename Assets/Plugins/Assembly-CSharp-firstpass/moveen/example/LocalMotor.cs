using System;
using UnityEngine;
using moveen.core;
using moveen.descs;
using moveen.editor;
using moveen.utils;

namespace moveen.example
{
	[ExecuteInEditMode]
	public class LocalMotor : MoveenSkelBase
	{
		[Warning("DEPRECATED! Replace with GlobalMotor")]
		[Tooltip("Enable position following")]
		public bool move;

		[Tooltip("Movement dynamics")]
		public MotorBean posMotor;

		[NonSerialized]
		public Vector3 localSpeed;

		[ReadOnly]
		public Vector3 localAngularSpeed;

		[Tooltip("Enable rotation following")]
		public bool rotate;

		[Tooltip("Rotation dynamics")]
		public MotorBean rotationMotor;

		[Tooltip("Pursue target's local (instead of global) pos/rot")]
		public bool targetsLocal;

		private void updateLocal()
		{
		}

		public override void fixedTick(float dt)
		{
		}

		public override void setTarget(Vector3 targetPos, Quaternion targetRot)
		{
		}

		public override void tick(float dt)
		{
		}
	}
}
