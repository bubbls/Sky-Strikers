using UnityEngine;

namespace Moon.Player.Visual
{
	public class AnimationByVelocity : MonoBehaviour
	{
		[SerializeField]
		private PlayerVisualsVelocityTracker _velocityTracker;

		[SerializeField]
		private Animator _animator;

		private static readonly int _velocity;

		private void LateUpdate()
		{
		}
	}
}
