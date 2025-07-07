using System;
using System.Runtime.CompilerServices;
using Fusion;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.ReportingSystem
{
	public abstract class NewPlayerEntryBase : MonoBehaviour
	{
		private bool _isInitialized;

		public PlayerRef PlayerRef { get; private set; }

		public event Action<PlayerRef, BadBehaviour> RequestReport
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

		public event Action<PlayerRef, int> RequestChangePlayerNo
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

		public event Action<NewPlayerEntryBase> NotifyReportContextMenuShown
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

		public event Action<PlayerRef> RequestChangePlayerTeam
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

		public event Action<PlayerRef> RequestToggleVoice
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

		public event Action<PlayerRef> RequestKickPlayer
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

		public void TryInitialize()
		{
		}

		protected abstract void InitializeInternal();

		public abstract void SetVisible(bool visible);

		public void SetPlayerRef(PlayerRef playerRef)
		{
		}

		public void UpdatePlayerInfo()
		{
		}

		protected abstract void UpdatePlayerInfoInternal();

		public abstract void UpdateRtt(int rtt);

		public abstract void ToggleReportContextMenu(bool show);

		public void SetMicEnabled(bool micEnabled)
		{
		}

		protected abstract void SetMicEnabledInternal(bool micEnabled);

		public void SetSpeakerVolume(MPlayer.PlayerSpeakerVolume volume)
		{
		}

		protected abstract void SetSpeakerVolumeInternal(MPlayer.PlayerSpeakerVolume volume);

		protected void SendRequestReport(BadBehaviour badBehaviour)
		{
		}

		protected void SendRequestChangePlayerTeam()
		{
		}

		protected void SendRequestToggleVoice()
		{
		}

		protected void SendRequestKickPlayer()
		{
		}

		protected void SendRequestChangePlayerNo(int playerNo)
		{
		}

		protected void SendNotifyReportContextMenuShown()
		{
		}

		protected void GetPlayerDisplayInfo(PlayerInfo myPlayerInfo, PlayerInfo targetPlayerInfo, bool entryIsLocalPlayer, out string playerName, out string playerNo, out bool isRedacted)
		{
			playerName = null;
			playerNo = null;
			isRedacted = default(bool);
		}
	}
}
