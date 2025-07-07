using System;
using UnityEngine;

namespace Moon.Player
{
	[Serializable]
	public class PlayerLocomotionConfiguration : ICloneable
	{
		public Vector3 JumpMultiplier;

		public float VelocityLimit;

		public float MaxJumpSpeed;

		public float RigidbodyDrag;

		public float RigidbodyMaxLinearVelocity;

		public Vector3 ConstantForce;

		public PhysicMaterial BodyColliderPhysicMaterial;

		public bool BodyColliderIsTrigger;

		public float HeadColliderRadius;

		public PhysicMaterial HeadColliderPhysicMaterial;

		public object Clone()
		{
			return null;
		}
	}
}
