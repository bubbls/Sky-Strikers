using System;

namespace Moon.Hub
{
	public class BathAnalyticsTrackingManager : HubAnalyticsTracking
	{
		private DateTime _bathStartDateTime;

		private int _actualBathDuration;

		protected override void HandleLocalPlayerVolumeChanged(bool hasPlayer)
		{
		}

		protected override void HandleOnSessionStartedInternal()
		{
		}

		protected override void HandleOnSessionEndedInternal()
		{
		}

		private void StartTracking()
		{
		}

		private void SetAttractionActualHubBathAreaDuration()
		{
		}
	}
}
