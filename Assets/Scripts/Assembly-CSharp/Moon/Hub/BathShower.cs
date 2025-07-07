using System;
using System.Runtime.CompilerServices;
using DP.Takeaway.Game;
using DP.Takeaway.Sound;
using Fusion;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Hub
{
	[NetworkBehaviourWeaved(0)]
	public class BathShower : NetworkBehaviour
	{
		[SerializeField]
		private ParticleSystem _showerParticle;

		[SerializeField]
		private Trigger _trigger;

		[SerializeField]
		private SoundInfo _soundInfo;

		private int _playersCount;

		private int _soundId;

		private static Changed<BathShower> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<BathShower> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<BathShower> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public event Action OnInteracted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public override void Spawned()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnEnter(Collider other)
		{
		}

		private void HandleOnExit(Collider other)
		{
		}

		[Rpc(RpcSources.All, RpcTargets.All)]
		private void Rpc_StartTakingShower()
		{
		}

		[Rpc(RpcSources.All, RpcTargets.All)]
		private void Rpc_StopTakingShower()
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(1, 7, 7)]
		protected unsafe static void Rpc_StartTakingShower_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(2, 7, 7)]
		[Preserve]
		protected unsafe static void Rpc_StopTakingShower_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
