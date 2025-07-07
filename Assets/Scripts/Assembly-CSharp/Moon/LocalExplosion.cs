using System.Collections.Generic;
using Fusion;
using Moon.Arena;
using UnityEngine;

namespace Moon
{
	public class LocalExplosion : MonoBehaviour
	{
		private static readonly AnimationCurve DefaultLiftCurve;

		private NetworkRunner _runner;

		private Vector3 _upDirection;

		private IEnumerable<string> _cachedIdentifiers;

		private List<LagCompensatedHit> _hits;

		private AnimationCurve _cachedSelectedCurve;

		private AnimationCurve _cachedLiftCurve;

		private Vector3 _cachedAppliedForce;

		private Vector3 _cachedHitPoint;

		private GameObject _cachedRoot;

		private Vector3 _cachedHitDirection;

		private Vector3 _explosionPosition;

		private int _executedTicksCount;

		private int _explosionExpireTick;

		private int _cachedHitCount;

		private float _maxForceRadiusToPlayer;

		private float _cachedCurvePower;

		private bool _isConfigured;

		private bool _hasStateAuthority;

		private LayerMask _queryMask;

		private HittableHitInfo _cachedHittableHitInfo;

		private ExplosionConfiguration _explosionConfiguration;

		private FxExplosion _fxExplosion;

		public bool IsExpired { get; private set; }

		public PlayerRef InputAuthority { get; set; }

		public void Initialize(PlayerRef inputAuthority, NetworkRunner runner, ExplosionConfiguration explosionConfiguration, LayerMask queryMask, bool hasStateAuthority)
		{
		}

		public void LoadExplosionFx(FxExplosion explosionFx, TeamNo teamNo)
		{
		}

		public void SetUpDirection(Vector3 upDirection)
		{
		}

		public void SetRunner(NetworkRunner runner)
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public void UnloadFx()
		{
		}

		public void DoFixedNetworkUpdate()
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
