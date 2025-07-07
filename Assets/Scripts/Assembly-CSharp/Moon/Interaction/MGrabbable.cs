using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Fusion;
using UnityEngine;

namespace Moon.Interaction
{
	[RequireComponent(typeof(NetworkEvents))]
	[NetworkBehaviourWeaved(1)]
	public abstract class MGrabbable : NetworkBehaviour, IGrabbable
	{
		private enum TargetInteractor
		{
			None = 0,
			AllPlayers = 1,
			GameMaster = 2,
			InputAuthority = 3
		}

		protected const string InitializeReason = "MGrabbable.Initialize";

		[SerializeField]
		private TargetInteractor _targetInteractor;

		[DefaultForProperty("NetworkedInteractionEnabled", 0, 1)]
		[SerializeField]
		private NetworkBool _NetworkedInteractionEnabled;

		private readonly HashSet<string> _interactionDisabledReasons;

		[SerializeField]
		private bool _hideHandOnGrab;

		[SerializeField]
		private bool _allowHandSwitching;

		[Tooltip("Players can only grab one of these objects at a time")]
		[SerializeField]
		private bool _isSingleGrab;

		[SerializeField]
		private bool _interactionEnabled;

		private NetworkEvents _networkEvents;

		private IGrabbableEventListener[] _eventListeners;

		private static Changed<MGrabbable> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MGrabbable> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MGrabbable> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public PlayerRef Grabber { get; private set; }

		public MGrabInteractor Interactor { get; private set; }

		[Networked]
		[NetworkedWeaved(0, 1)]
		public NetworkBool NetworkedInteractionEnabled
		{
			get
			{
				return default(NetworkBool);
			}
			private set
			{
			}
		}

		public bool IsGrabbed => false;

		public bool IsGrabbedByLocalPlayer => false;

		public bool HideHandOnGrab => false;

		public bool IsLocalGrabbable => false;

		public event Action OnGrabbed
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

		public event Action OnReleased
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

		public void Initialize()
		{
		}

		public void CleanAllAction()
		{
		}

		public override void Spawned()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		public void EnableInteraction(string reason)
		{
		}

		public void DisableInteraction(string reason)
		{
		}

		protected void ResetDisabledInteraction()
		{
		}

		public void Grab(MGrabInteractor interactor)
		{
		}

		public void ForceGrab(MGrabInteractor interactor)
		{
		}

		public void Release()
		{
		}

		private void HandleOnPlayerLeft(NetworkRunner runner, PlayerRef playerRef)
		{
		}

		private void HandleOnShutdown(NetworkRunner runner, ShutdownReason shutdownReason)
		{
		}

		private void DoRelease()
		{
		}

		private void HandleOnGrabbed(MGrabInteractor grabInteractor)
		{
		}

		protected abstract void HandleOnGrabbedInternal();

		protected abstract void HandleOnReleaseInternal();

		public virtual bool CanBeGrabbedByInteractor(MGrabInteractor interactor)
		{
			return false;
		}

		protected bool IsTargetPlayerType(MGrabInteractor interactor)
		{
			return false;
		}

		private bool CanSwitchHands(MGrabInteractor interactor)
		{
			return false;
		}

		private bool IsPlayerHoldingSameGrabbableType(MGrabInteractor interactor)
		{
			return false;
		}

		public virtual void PlayGrabRejected(MGrabInteractor interactor)
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
