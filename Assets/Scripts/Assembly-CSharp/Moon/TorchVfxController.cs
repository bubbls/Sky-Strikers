using UnityEngine;

namespace Moon
{
	public class TorchVfxController : MonoBehaviour
	{
		[SerializeField]
		private ParticleSystem[] _fireTrailParticles;

		private bool _enabled;

		private Transform _vfxFollowPoint;

		private Transform _transform;

		public void Initialize(Transform vfxFollowPoint, Vector3 scale)
		{
		}

		private void LateUpdate()
		{
		}

		private void SyncPosition()
		{
		}

		public void Enable()
		{
		}

		public void Disable()
		{
		}

		public void PlayFireParticles()
		{
		}

		public void StopFireParticles()
		{
		}
	}
}
