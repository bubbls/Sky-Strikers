using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using Fusion;
using Moon.Arena;
using Moon.MultiPlay;

namespace Moon.PlayerProfile
{
	[SimulationBehaviour(Stages = SimulationStages.Forward, Modes = SimulationModes.Server)]
	public class MPlayerStatsTracker : SimulationBehaviour, ISpawned, IDespawned
	{
		private List<PlayerStatsHandler> _handlers;

		private readonly HashSet<IMessageSubscriber> _subscribers;

		private PlayerRef _playerRef;

		private IMessageSubscriber _messageSubscriber;

		private bool CanLogStats()
		{
			return false;
		}

		private bool IsMatchInProgress()
		{
			return false;
		}

		public string CurrentMatchId()
		{
			return null;
		}

		public void Spawned()
		{
		}

		public void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		private int HandlePlayerAction(IMessage<PlayerActionMessage> message)
		{
			return 0;
		}

		private int HandleMatchEvent(IMessage<MatchEventMessage> message)
		{
			return 0;
		}

		private int HandleOtherPlayerLocationChanged(IMessage<PlayerLocationChangedMessage> locationChangedMessage)
		{
			return 0;
		}

		private int HandlePlayerEnergyCollected(IMessage<PlayerEnergyCollectedMessage> locationChangedMessage)
		{
			return 0;
		}

		private int HandlePlayerAbilityInflicted(IMessage<PlayerAbilityMessageData> playerAbilityMessage)
		{
			return 0;
		}

		private int HandlePlayerPossessionChanged(IMessage<object> message)
		{
			return 0;
		}

		public void HandlePlayerAmmoStatusChanged(WeaponType weaponType, MAmmoBox.Status status)
		{
		}
	}
}
