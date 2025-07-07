using UnityEngine;

namespace Moon.Player.Ability.Jetstream
{
	public class JetstreamBallSuckerBallSlowArea : JetstreamBallSuckerBallArea
	{
		[SerializeField]
		private float _ballVelocitySlowdown;

		private bool _isSlowed;

		public void Reset()
		{
		}

		public void TrySlowBall(MBall ball)
		{
		}
	}
}
