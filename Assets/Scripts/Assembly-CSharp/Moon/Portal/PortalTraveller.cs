using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.Portal
{
	public class PortalTraveller : MonoBehaviour
	{
		public delegate void PortalTravellerEvent(RenderedPortal fromPortal, float fromSide);

		public delegate bool TravellerCrossPortalRequest(TravellerPortal fromPortal, float fromSide);

		[SerializeField]
		private PortalTravellerDescription _description;

		public PortalTravellerDescription Description => null;

		public event PortalTravellerEvent OnClippingWithPortal
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

		public event TravellerCrossPortalRequest RequestCrossPortal
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

		public void NotifyClippingWithPortal(RenderedPortal portal, float side)
		{
		}

		public bool NotifyCrossedPortal(TravellerPortal portal, float side)
		{
			return false;
		}
	}
}
