using System.Collections.Generic;
using UnityEngine;

namespace Moon.Portal
{
	public class ProcessEngagedTravellers : MonoBehaviour
	{
		private class TravellerInfo
		{
			public TravellerPortal Portal;

			public float LastSide;
		}

		[SerializeField]
		private bool _notifyTravellerCrossedPortal;

		private readonly Dictionary<PortalTraveller, TravellerInfo> _travellers;

		private readonly Dictionary<PortalTraveller, (TravellerPortal from, TravellerPortal to)> _crossedTravellers;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandlePortalAdded(TravellerPortal portal)
		{
		}

		private void HandlePortalWillRemove(TravellerPortal portal)
		{
		}

		private void HandleTravellerEnter(TravellerPortal portal, PortalTraveller portalTraveller)
		{
		}

		private void HandleTravellerExit(TravellerPortal portal, PortalTraveller portalTraveller)
		{
		}

		private void Update()
		{
		}

		private void UpdateTravellerContext(PortalTraveller traveller, TravellerInfo travellerInfo)
		{
		}

		private void NotifyCrossedPortal(PortalTraveller traveller, TravellerInfo travellerInfo)
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
