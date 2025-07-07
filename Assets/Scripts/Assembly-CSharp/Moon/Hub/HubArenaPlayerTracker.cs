using System;
using System.Collections.Generic;
using System.Diagnostics;
using Chamber8.Framework.Messaging;
using Fusion;
using Moon.MultiPlay;

namespace Moon.Hub
{
	[Serializable]
	public class HubArenaPlayerTracker : IDisposable
	{
		[Serializable]
		public class TrackingData
		{
			private readonly Stopwatch _stopwatch;

			public PlayerRef PlayerRef { get; private set; }

			public bool IsBeingTracked { get; private set; }

			public double TotalElapsedSeconds => 0.0;

			public TrackingData(PlayerRef playerRef, bool startTracking)
			{
			}

			public void ToggleTracking(bool trackingEnabled)
			{
			}
		}

		private IMessageSubscriber _arenaLocationEventsSubscription;

		private List<TrackingData> _playerTimeInArenaTracker;

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		private void ConnectionManager_OnPlayerLeftEvent(PlayerRef playerRef)
		{
		}

		public void HandleOnNewMatchStarted()
		{
		}

		public int GetTotalPlayersInArena()
		{
			return 0;
		}

		private int HandleOtherPlayerLocationChanged(IMessage<PlayerLocationChangedMessage> message)
		{
			return 0;
		}

		public void StopTracking()
		{
		}

		public Dictionary<PlayerRef, string> GetPlayersForReward(float timeInArenaForReward)
		{
			return null;
		}

		private void RemovePlayer(PlayerRef playerRef)
		{
		}

		private bool TryGetTrackedData(PlayerRef playerRef, out TrackingData trackingData)
		{
			trackingData = null;
			return false;
		}

		private void TryAdd(PlayerRef playerRef, TrackingData trackingData)
		{
		}
	}
}
