using System;

namespace Moon.Hub
{
	public class HubArenaAnalyticsTracking : HubAnalyticsTracking
	{
		private DateTime _hubArenaStartTime;

		private int _hubArenaActualDuration;

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

		private void SetAttractionActualHubArenaDuration()
		{
		}
	}
}
