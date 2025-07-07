using System.Collections.Generic;
using Fusion;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Arena
{
	[NetworkBehaviourWeaved(3)]
	public class ArenaEyePumpkinBomb : ArenaEyePumpkin
	{
		[DefaultForProperty("ShouldShowWarning", 1, 1)]
		private NetworkBool _ShouldShowWarning;

		[DefaultForProperty("IsExploded", 2, 1)]
		private NetworkBool _IsExploded;

		[SerializeField]
		private Hitbox _hitbox;

		[SerializeField]
		private float _explodeCountdownTime;

		[SerializeField]
		private float _warningTime;

		[SerializeField]
		private GameObject _rangeVisual;

		[SerializeField]
		private GameObject _bombLocalExplosionPrefab;

		private List<LagCompensatedHit> _lagCompensatedHits;

		private float _explodeCountdown;

		private bool _hasLocalExplosion;

		private ArenaEyePumpkinBombLocalExplosion _bombLocalExplosion;

		private static Changed<ArenaEyePumpkinBomb> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<ArenaEyePumpkinBomb> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<ArenaEyePumpkinBomb> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[NetworkedWeaved(1, 1)]
		[Networked(OnChanged = "OnShouldShowWarningChanged")]
		private NetworkBool ShouldShowWarning
		{
			get
			{
				return default(NetworkBool);
			}
			set
			{
			}
		}

		[Networked(OnChanged = "OnIsExplodedChanged")]
		[NetworkedWeaved(2, 1)]
		private NetworkBool IsExploded
		{
			get
			{
				return default(NetworkBool);
			}
			set
			{
			}
		}

		private TickTimer ExplodeCountdownTime { get; set; }

		private TickTimer WarningTime { get; set; }

		public override void Initialize(Vector3 direction, bool canSpawnSiplets = false)
		{
		}

		protected override void HandleOnSpawned()
		{
		}

		protected override void HandleOnDespawned()
		{
		}

		protected bool CheckIfIsPlayerInPumpkinArea()
		{
			return false;
		}

		protected override void HandleLifeTimeExpired()
		{
		}

		protected override void HandleServerFixedUpdateNetworkWhenOnTheGround()
		{
		}

		protected override void HandleServerFixedUpdateNetwork()
		{
		}

		private void StartCountdownExplosion()
		{
		}

		[Preserve]
		private static void OnShouldShowWarningChanged(Changed<ArenaEyePumpkinBomb> changed)
		{
		}

		private void ToggleRangeVisual()
		{
		}

		[Preserve]
		private static void OnIsExplodedChanged(Changed<ArenaEyePumpkinBomb> changed)
		{
		}

		private void TogglePumpkinVisual()
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}
	}
}
