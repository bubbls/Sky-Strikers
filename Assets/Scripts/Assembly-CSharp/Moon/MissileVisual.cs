using Moon.Arena;
using UnityEngine;

namespace Moon
{
	public class MissileVisual : MonoBehaviour, IPrewarmable
	{
		[SerializeField]
		private PlayerMaterials _playerMaterials;

		[SerializeField]
		private AudioSource _missileSound;

		[SerializeField]
		private GameObject _predictedVisual;

		private bool _isInitialized;

		private Transform _transform;

		private ParticleSystem[] _particleSystems;

		public void Initialize()
		{
		}

		private void OnDisable()
		{
		}

		public void SetTeamColor(SuitVisualTheme visualTheme, TeamNo teamNo)
		{
		}

		public void TogglePredictedVisual(bool enable)
		{
		}

		public void ToggleFX(bool enable)
		{
		}

		public void UpdateTransform(Vector3 position, Vector3 forward)
		{
		}

		void IPrewarmable.Prewarm()
		{
		}
	}
}
