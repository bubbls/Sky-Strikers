using UnityEngine;

namespace Moon.GameActivity
{
	public class EffectController : MonoBehaviour
	{
		[SerializeField]
		private ParticleSystem _fx;

		public void Play()
		{
		}

		public void Stop()
		{
		}

		public void Stop(bool withChildren, ParticleSystemStopBehavior stopBehavior)
		{
		}
	}
}
