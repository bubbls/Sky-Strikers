using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using Fusion;
using Moon.Bootstrap;
using Moon.MultiPlay;
using TMPro;
using UnityEngine;

namespace Moon.Leaderboard
{
	public class PlayerStatsFrame : MonoBehaviour
	{
		[SerializeField]
		private bool _myStats;

		[SerializeField]
		private TMP_Text _textPlayerName;

		[SerializeField]
		private List<StatsEntry> _statsEntries;

		[SerializeField]
		private List<Badge> _badges;

		[SerializeField]
		private XpBar _xpBar;

		[SerializeField]
		private PlayerNameBoard _playerNameBoard;

		[SerializeField]
		private PlayerFlags _playerFlags;

		private HashSet<IMessageSubscriber> _subscribers;

		private int _currentPlayerId;

		public int PlayerId => 0;

		private void Start()
		{
		}

		public void HandleOnEnable()
		{
		}

		private int HandleOnPlayerInfoChanged(IMessage<PlayerInfoChangedMessage> message)
		{
			return 0;
		}

		private int HandleShutdown(IMessage<ShutdownMessage> message)
		{
			return 0;
		}

		private void SetNotAvailable(PlayerRef playerRef)
		{
		}

		private void ClearStatsFrame()
		{
		}

		public void SetPlayerStatsFrame(PlayerRef playerRef)
		{
		}

		private void UpdateThemeVisual(PlayerRef playerRef)
		{
		}

		private void RequestPlayerStats(PlayerRef playerRef)
		{
		}

		private int HandlePlayerStatisticsUpdated(IMessage<PlayerStatisticsUpdatedMessage> message)
		{
			return 0;
		}

		public void HandleOnDisable()
		{
		}
	}
}
