using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.AI.BehaviorDesigner.Behaviors
{
	public class MobActions : MonoBehaviour
	{
		public enum FacingOption
		{
			FacingLookingDirection = 0,
			Stop = 1
		}

		[Preserve]
		public void Move(Transform target, Transform to, float moveSpeed)
		{
		}

		[Preserve]
		public void Face(Transform target, Transform to, float rotSpeed, Transform lookingDirection = null, float range = 180f, FacingOption facingEvenOutOfRange = FacingOption.FacingLookingDirection)
		{
		}

		[Preserve]
		public void RotateTo(Transform target, Transform to, float rotSpeed)
		{
		}

		[Preserve]
		public void Stick(Transform target, Transform to)
		{
		}
	}
}
