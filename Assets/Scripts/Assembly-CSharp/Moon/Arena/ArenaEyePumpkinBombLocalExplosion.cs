using System.Collections.Generic;
using Fusion;
using UnityEngine;

namespace Moon.Arena
{
	public class ArenaEyePumpkinBombLocalExplosion : MonoBehaviour
	{
		[SerializeField]
		private float _explosionRadius;

		[SerializeField]
		private float _explosionVisualDuration;

		[SerializeField]
		private float _explosionDespawnDuration;

		[SerializeField]
		private float _explodingTick;

		[SerializeField]
		private Transform _visual;

		private List<LagCompensatedHit> _lagCompensatedHits;

		private PlayerRef _inputAuthority;

		private NetworkRunner _runner;

		private LayerMask _layerMask;

		private bool _hasStateAuthority;

		private int _currentExplodeTick;

		private int _explosionDespawnTick;

		public bool IsExplosionExpired { get; private set; }

		public void Initialize(PlayerRef inputAuthority, NetworkRunner runner, LayerMask layerMask, bool hasStateAuthority)
		{
		}

		public void Despawn()
		{
		}

		public void ExecuteFixedNetworkUpdate()
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
