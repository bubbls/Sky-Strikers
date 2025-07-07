using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using DP.Takeaway.Sound;
using Fusion;
using Moon.Bootstrap;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.Arena
{
	public class MTeamConsole : MonoBehaviour
	{
		[SerializeField]
		private List<PlayerEntry> _playerEntries;

		[SerializeField]
		private SoundInfo _playerJoinedSfx;

		[SerializeField]
		private SoundInfo _sfxSwitchTeam;

		[SerializeField]
		private Material[] _teamBtnMaterials;

		private IMessageSubscriber[] _subscribers;

		private bool _dirty;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private int HandlePlayerLocationChanged(IMessage<PlayerLocationChangedMessage> message)
		{
			return 0;
		}

		private int HandlePlayerInfoChanged(IMessage<PlayerInfoChangedMessage> message)
		{
			return 0;
		}

		private int HandlePlayerJoined(IMessage<PlayerAddedMessage> message)
		{
			return 0;
		}

		private int HandlePlayerRemoved(IMessage<PlayerRemovedMessage> message)
		{
			return 0;
		}

		private void HandleChangeColor(PlayerRef playerRef, bool isOn)
		{
		}

		private void InitializeTeamBtnColor()
		{
		}

		private void ToggleMic(bool isOn)
		{
		}

		private bool IsRecorderEnabled()
		{
			return false;
		}

		private void HandleToggleMic(PlayerRef playerRef, bool isOn)
		{
		}

		private void HandleToggleVoice(PlayerRef playerRef, bool isOn)
		{
		}

		private void HandleKickPlayer(PlayerRef playerRef)
		{
		}

		private void HandleChangePlayerNo(PlayerRef playerRef, bool tuneUp)
		{
		}

		private void LateUpdate()
		{
		}

		private void UpdatePlayerEntry(PlayerEntry entry, PlayerRef playerRef)
		{
		}

		private void HandleAddFriend()
		{
		}

		private void HandleButtonPressed(string btnName)
		{
		}
	}
}
