using UnityEngine;

namespace Moon.Player.Visual
{
	public class JetstreamHandVisual : PlayerSuitHandVisual
	{
		[SerializeField]
		private ParticleSystem[] _boostParticles;

		[SerializeField]
		private GameObject[] _particleObjectsToToggle;

		[SerializeField]
		private JetstreamBoostSoundPlayer _jetstreamBoostSoundPlayer;

		[Header("Animation")]
		[SerializeField]
		private Animator[] _boostAnimators;

		[SerializeField]
		private float _animationDuration;

		private static readonly int _velocity;

		protected override void InitializeInternal()
		{
		}

		public void ToggleBoostParticles(bool show)
		{
		}

		public void Reset()
		{
		}
	}
}
