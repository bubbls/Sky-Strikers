using System;
using UnityEngine;

namespace moveen.core
{
	[Serializable]
	public class MotorBean
	{
		[Tooltip("Coefficient: distance to wanted speed. (It is sometimes called \"Spring\")")]
		public float distanceToSpeed;

		[Tooltip("Maximum wanted speed. Motor will try to slow down if speed is too high")]
		public float maxSpeed;

		[Tooltip("Coefficient: wanted speed to acceleration.")]
		public float speedDifToAccel;

		[Tooltip("Maximum applicable acceleration. Not the force. Corresponds to the power of the motor, but not depends on the mass of the connected body. So you can scale mass without fixing the motor, but you do want to scale this parameter if you want the motor to seem weaker or stronger")]
		public float maxAccel;

		public float getAccel(float targetPos, float currentPos, float currentSpeed, float maxAccelMultiplier)
		{
			return 0f;
		}

		public float getAccel(float targetPos, float currentPos, float currentSpeed, float externalAccel, float maxAccelMultiplier)
		{
			return 0f;
		}

		public Vector3 getAccel(Vector3 targetPos, Vector3 currentPos, Vector3 currentSpeed, float maxAccelMultiplier = 1f)
		{
			return default(Vector3);
		}

		public void copyFrom(MotorBean other)
		{
		}

		public Vector3 getTorque(Quaternion currentRot, Quaternion wantedRot, Vector3 currentAngularSpeed, float maxAccelMultiplier = 1f)
		{
			return default(Vector3);
		}
	}
}
