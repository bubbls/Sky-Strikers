using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using Fusion;
using Moon.Arena;
using Moon.Bootstrap;
using Moon.MultiPlay;
using NaughtyAttributes;
using UnityEngine;

namespace Moon.ReportingSystem
{
	public class PlayerListConsole : MonoBehaviour
	{
		[SerializeField]
		protected List<NewPlayerEntryBase> _playerEntries;

		[SerializeField]
		private bool _moveLocalPlayerToBeginning;

		private IMessageSubscriber[] _subscribers;

		private PlayerInfoChangedMessage _playerInfoChangedMessage;

		private PlayerRTTChangedMessage _playerRttChangedMessage;

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		private void UpdatePlayerEntries()
		{
		}

		private void UpdatePlayerEntry(NewPlayerEntryBase playerEntry, PlayerRef playerRef)
		{
		}

		private void HidePlayerEntries()
		{
		}

		private void HandleRequestReport(PlayerRef playerRef, BadBehaviour badBehaviour)
		{
		}

		private void HandleRequestChangePlayerNo(PlayerRef playerRef, int playerNo)
		{
		}

		private int HandlePlayerRemoved(IMessage<PlayerRemovedMessage> arg)
		{
			return 0;
		}

		private int HandlePlayerAdded(IMessage<PlayerAddedMessage> message)
		{
			return 0;
		}

		private int HandleMatchEvent(IMessage<MatchEventMessage> message)
		{
			return 0;
		}

		private int HandlePlayerInfoChanged(IMessage<PlayerInfoChangedMessage> message)
		{
			return 0;
		}

		private int HandlePlayerInitialized(IMessage<PlayerInitializedMessage> message)
		{
			return 0;
		}

		private int HandlePlayerRTTChangedMessage(IMessage<PlayerRTTChangedMessage> message)
		{
			return 0;
		}

		private void HandleNotifyReportContextMenuShown(NewPlayerEntryBase requestingEntry)
		{
		}

		private void HandleRequestChangePlayerTeam(PlayerRef playerRef)
		{
		}

		private void HandleRequestKickPlayer(PlayerRef playerRef)
		{
		}

		private void HandleRequestToggleVoice(PlayerRef playerRef)
		{
		}

		private NewPlayerEntryBase FindPlayerEntry(PlayerRef playerRef)
		{
			return null;
		}

		private int HandleConnChanged(IMessage<ConnChangedMessage> arg)
		{
			return 0;
		}
	}
}
