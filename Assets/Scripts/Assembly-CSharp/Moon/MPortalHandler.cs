using System;
using System.Runtime.CompilerServices;
using Fusion;
using Moon.Portal;
using UnityEngine;

namespace Moon
{
	[NetworkBehaviourWeaved(0)]
	public abstract class MPortalHandler : NetworkBehaviour
	{
		[SerializeField]
		protected TravellerPortal _portal;

		[SerializeField]
		protected LayerMask _disablePortalLayers;

		[SerializeField]
		protected LayerMask _destroyPortalLayers;

		[SerializeField]
		private Collider _collider;

		[SerializeField]
		protected MPortalHandler _linkedPortal;

		private static Changed<MPortalHandler> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MPortalHandler> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MPortalHandler> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public Transform TeleportPoint => null;

		public event Action<int> OnPortalDisableRequested
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

		public event Action<int> OnPortalDestroyRequested
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

		private void Portal_OnTravellerEnter(TravellerPortal portal, PortalTraveller portalTraveller)
		{
		}

		public void SetLinkedPortal(MPortalHandler portalHandler)
		{
		}

		protected abstract void HandleTeleport(GameObject go);

		protected void NotifyAboutObjectTeleported(int layer)
		{
		}

		public void DisableTrigger()
		{
		}

		public void EnableTrigger()
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
