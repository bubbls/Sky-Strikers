using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DP.Takeaway.Utils;
using Fusion;
using Moon.Arena;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon
{
	[RequireComponent(typeof(Hittable))]
	[SimulationBehaviour(Stages = SimulationStages.Forward, Modes = (SimulationModes.Server | SimulationModes.Host))]
	[NetworkBehaviourWeaved(5)]
	public abstract class MPowerUp : NetworkBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CBeforeDespawn_003Ed__45 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public MPowerUp _003C_003E4__this;

			public Action complete;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[SerializeField]
		[Header("Once = True, After consumed, despawn immediately, it will not respawn")]
		private bool _once;

		[SerializeField]
		private float _timeBeforeDespawn;

		[SerializeField]
		[Header("Respawn after consumed")]
		private float _regenerationDuration;

		[SerializeField]
		[Header("AutoDespawn = True, After spawned, despawn after a while")]
		private bool _autoDespawn;

		[SerializeField]
		private float _autoDespawnDuration;

		[DefaultForProperty("Generated", 0, 1)]
		private NetworkBool _Generated;

		[DefaultForProperty("Enabled", 1, 1)]
		private NetworkBool _Enabled;

		[DefaultForProperty("LastConsumer", 2, 1)]
		private PlayerRef _LastConsumer;

		[DefaultForProperty("RegenerationTimer", 3, 1)]
		private TickTimer _RegenerationTimer;

		[DefaultForProperty("DespawnTimer", 4, 1)]
		private TickTimer _DespawnTimer;

		[SerializeField]
		private TeamNo _teamNo;

		[SerializeField]
		private bool _affectedByRegenMultiplier;

		private static Changed<MPowerUp> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MPowerUp> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MPowerUp> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked(OnChanged = "OnGeneratedChanged")]
		[NetworkedWeaved(0, 1)]
		protected NetworkBool Generated
		{
			get
			{
				return default(NetworkBool);
			}
			private set
			{
			}
		}

		[NetworkedWeaved(1, 1)]
		[Networked(OnChanged = "OnEnabledChanged")]
		protected NetworkBool Enabled
		{
			get
			{
				return default(NetworkBool);
			}
			private set
			{
			}
		}

		[NetworkedWeaved(2, 1)]
		[Networked]
		protected PlayerRef LastConsumer
		{
			get
			{
				return default(PlayerRef);
			}
			private set
			{
			}
		}

		[NetworkedWeaved(3, 1)]
		[Networked]
		protected TickTimer RegenerationTimer
		{
			get
			{
				return default(TickTimer);
			}
			private set
			{
			}
		}

		[Networked]
		[NetworkedWeaved(4, 1)]
		protected TickTimer DespawnTimer
		{
			get
			{
				return default(TickTimer);
			}
			private set
			{
			}
		}

		protected bool IsSpawned { get; private set; }

		protected virtual void Awake()
		{
		}

		public override void Spawned()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleResetPowerUp(GameObject _)
		{
		}

		private void HandleDisablePowerUp(GameObject _)
		{
		}

		[Preserve]
		private static void OnGeneratedChanged(Changed<MPowerUp> changed)
		{
		}

		[Preserve]
		private static void OnEnabledChanged(Changed<MPowerUp> changed)
		{
		}

		protected abstract void ToggleVisuals(bool show);

		protected abstract ICommand GetPowerUpCommand(MHitter hitter, out int amount);

		protected abstract void UpdateVisual(bool wasGenerated);

		private void PowerUp(MHitter hitter)
		{
		}

		private void NotifyConsumedBy(PlayerRef playerRef, int amount, int diff)
		{
		}

		[AsyncStateMachine(typeof(_003CBeforeDespawn_003Ed__45))]
		private void BeforeDespawn(Action complete)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.Proxies)]
		private void Rpc_NotifyBeforeDespawn()
		{
		}

		private void HandleOnHit(MHitter hitter, HittableHitInfo hitInfo)
		{
		}

		private void RegenerateImmediate()
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		protected virtual void WillDespawnPowerUp()
		{
		}

		protected float GetModifiedRegenerationDuration()
		{
			return 0f;
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(1, 1, 4)]
		protected unsafe static void Rpc_NotifyBeforeDespawn_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
