using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.Portal
{
	[RequireComponent(typeof(Collider))]
	public class TeleportVolume : MonoBehaviour
	{
		[SerializeField]
		protected TeleportVolume[] _otherVolumes;

		protected bool Disable { get; private set; }

		public event Action<PortalTraveller> BeforeTeleportAway
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

		public event Action<PortalTraveller> BeforeTeleportHere
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

		public event Action<PortalTraveller> OnTeleportedAway
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

		public event Action<PortalTraveller> OnTeleportedHere
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

		private void OnTriggerEnter(Collider other)
		{
		}

		protected virtual void HandleOnPortalTravellerEntered(PortalTraveller portalTraveller)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		protected virtual void HandleOnPortalTravellerExit(PortalTraveller portalTraveller)
		{
		}

		protected TeleportVolume GetOtherPlace()
		{
			return null;
		}

		protected void SetDisable(bool disable)
		{
		}

		protected void NotifyBeforeTeleportHere(PortalTraveller portalTraveller)
		{
		}

		protected void NotifyBeforeTeleportAway(PortalTraveller portalTraveller)
		{
		}

		protected void NotifyOnTeleportedHere(PortalTraveller portalTraveller)
		{
		}

		protected void NotifyOnTeleportedAway(PortalTraveller portalTraveller)
		{
		}
	}
}
