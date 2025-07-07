using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Fusion;
using Moon.AI.VisualScripting;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Interaction
{
	[OrderAfter(new Type[] { typeof(HitboxManager) })]
	[NetworkBehaviourWeaved(2)]
	public class MGrabInteractor : NetworkBehaviour
	{
		[SerializeField]
		[DefaultForProperty("GrabbedObject", 0, 2)]
		private MGrabbable _GrabbedObject;

		[SerializeField]
		private bool _isLeft;

		public Func<Transform> GetGrabAttachPointDelegate;

		private Transform _thisTransform;

		[SerializeField]
		private OverlapShapeDesc _grabbableDetectArea;

		private IDistanceRestrictedGrabbable _distanceRestrictedGrabbable;

		private bool _isGrabbingDistanceLimitedObj;

		private List<LagCompensatedHit> _hits;

		private DelayedGrabbableTrigger _currentDelayedGrabbableTrigger;

		private float _delayedGrabbableTriggerHoldExpireTime;

		private static Changed<MGrabInteractor> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MGrabInteractor> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MGrabInteractor> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[NetworkedWeaved(0, 2)]
		[Networked(OnChanged = "OnGrabbedObjectChanged")]
		public MGrabbable GrabbedObject
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		private LocalGrabbable LocalGrabbedObject { get; set; }

		public bool IsHoldingObject => false;

		public bool IsHoldingObjectLocally { get; private set; }

		public bool IsLeft => false;

		public bool ShouldHideHand => false;

		public Transform GrabAttachPoint => null;

		private Transform ThisTransform => null;

		public event Action<bool> OnToggleHandVisualsRequested
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

		public event Action<MGrabInteractor> OnGrabbed
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

		public event Action<MGrabInteractor, MGrabbable> OnReleased
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

		public override void FixedUpdateNetwork()
		{
		}

		public void TryNetworkGrab()
		{
		}

		public void TryEnterGrabbableTriggers()
		{
		}

		public void TryExitGrabbableTriggers()
		{
		}

		public bool AttemptLocalGrabCheck()
		{
			return false;
		}

		private bool HasGrabbableInRange(out IGrabbable grabbable)
		{
			grabbable = null;
			return false;
		}

		private bool HasGrabbableTriggerInRange(out IGrabbableTrigger grabbableTrigger)
		{
			grabbableTrigger = null;
			return false;
		}

		[Preserve]
		private static void OnGrabbedObjectChanged(Changed<MGrabInteractor> changed)
		{
		}

		private void RaiseGrabbedEvent()
		{
		}

		private void RaiseReleasedEvent(MGrabbable oldGrabbedObject)
		{
		}

		public void Release()
		{
		}

		private void OnDisable()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		private void ReleaseInternal()
		{
		}

		private void SendToggleHandVisualsRequest(bool show)
		{
		}

		public void ForceGrab(MGrabbable mGrabbable)
		{
		}

		public void ForceRelease()
		{
		}

		[Rpc(RpcSources.InputAuthority, RpcTargets.StateAuthority, InvokeResim = true)]
		private void RPC_ForceRelease()
		{
		}

		[Rpc(RpcSources.InputAuthority, RpcTargets.StateAuthority, InvokeResim = true)]
		private void Rpc_RequestForceGrab(MGrabbable grabbable)
		{
		}

		private void TryExitCurrentDelayedGrabbableTrigger()
		{
		}

		public void TryLocalGrab()
		{
		}

		public void ForceLocalGrab(LocalGrabbable grabbable)
		{
		}

		public void ForceReleaseLocalGrabbedObject()
		{
		}

		private void UpdateIsHoldingObjectLocally(bool isHoldingObjectLocally)
		{
		}

		[Rpc(RpcSources.InputAuthority, RpcTargets.StateAuthority, InvokeResim = true, Channel = RpcChannel.Reliable)]
		private void Rpc_UpdateIsGrabbedLocally(bool isHoldingObjectLocally)
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[NetworkRpcWeavedInvoker(1, 2, 1)]
		[Preserve]
		protected unsafe static void RPC_ForceRelease_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(2, 2, 1)]
		[Preserve]
		protected unsafe static void Rpc_RequestForceGrab_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(3, 2, 1)]
		protected unsafe static void Rpc_UpdateIsGrabbedLocally_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
