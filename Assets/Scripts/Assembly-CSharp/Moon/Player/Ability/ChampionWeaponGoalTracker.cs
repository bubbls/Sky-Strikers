using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Chamber8.Framework.Messaging;
using Fusion;
using Moon.Arena;
using Moon.MultiPlay;

namespace Moon.Player.Ability
{
	public class ChampionWeaponGoalTracker
	{
		private static readonly Location[] _validTrackingLocations;

		private static readonly Location[] _topScorerTrackingLocations;

		private IMessageSubscriber[] _messageSubscribers;

		private Location _cachedLocation;

		private PlayerRef _currentTopScorer;

		private byte _currentTopScore;

		private readonly Dictionary<PlayerRef, byte> _topScoringPlayers;

		public event Action OnRankedMatchPlayersConfirmed
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

		public event Action<PlayerRef, PlayerRef> UpdateTopScorer
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

		public event Action<PlayerRef, byte> OnPlayerRankedMatchGoalsChanged
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

		public event Action<PlayerRef> RequestClearTopScorerFromPlayer
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

		public event Action<PlayerRef> RequestPreviewWeaponFxForPlayer
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

		public event Action<List<PlayerRef>> RequestClearWeaponFxFromPlayers
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

		public void Dispose()
		{
		}

		private void TryRemoveTopScorer(PlayerRef playerRef, bool notify)
		{
		}

		public void HandlePlayerLeft(PlayerRef playerRef)
		{
		}

		private int HandleOnPlayerLocationChanged(IMessage<PlayerLocationChangedMessage> message)
		{
			return 0;
		}

		private int HandleOnMatchEvent(IMessage<MatchEventMessage> message)
		{
			return 0;
		}

		private void HandleGoalScored(PlayerRef playerRef)
		{
		}

		private void ClearTopScorers()
		{
		}

		private bool IsInValidLocation(PlayerRef playerRef, out bool isInTopScorerLocation)
		{
			isInTopScorerLocation = default(bool);
			return false;
		}

		private void TryUpdateTopScorer()
		{
		}
	}
}
