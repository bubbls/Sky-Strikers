using System;

namespace Moon.Hub
{
	public class BarAnalyticsTracking : HubAnalyticsTracking
	{
		private DateTime _barStartTime;

		private int _actualBarDuration;

		protected override void HandleLocalPlayerVolumeChanged(bool hasPlayer)
		{
		}

		protected override void HandleOnSessionStartedInternal()
		{
		}

		protected override void HandleOnSessionEndedInternal()
		{
		}

		private void SetAttractionActualHubBarDuration()
		{
		}

		private void StartTracking()
		{
		}
	}
}
