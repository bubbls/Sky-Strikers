using DG.Tweening;
using DP.Takeaway.Sound;
using Moon.Arena;
using UnityEngine;

namespace Moon
{
	public class FxExplosion : MonoBehaviour, IPrewarmable
	{
		private static readonly int _propRimLightColor;

		private static readonly int _propBaseColor;

		[SerializeField]
		private SoundInfo _soundInfo;

		[SerializeField]
		private Transform _outerPivot;

		[SerializeField]
		private Transform _innerPivot;

		[SerializeField]
		private Renderer _innerRd;

		[SerializeField]
		private Renderer _outerRd;

		[SerializeField]
		private Transform _effectPivot;

		[SerializeField]
		private ParticleSystem[] _particleSystems;

		[SerializeField]
		private PlayerTeamObjectsGroup _teamObjectsGroup;

		[SerializeField]
		private bool _useWorldUp;

		private Sequence _tween;

		private Color _innerColor;

		private Color _outerColor;

		private bool _isInitialized;

		public void Initialize()
		{
		}

		public void SetTeamColor(TeamNo teamNo)
		{
		}

		public void Explode(Vector3 up, float radius, float radiusToPlayer, float delay)
		{
		}

		private void CreateDoTween(float radius, float delay)
		{
		}

		private void OnDestroy()
		{
		}

		private void OnDisable()
		{
		}

		public void Stop()
		{
		}

		void IPrewarmable.Prewarm()
		{
		}
	}
}
