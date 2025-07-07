using System;
using System.Runtime.CompilerServices;
using DP.Takeaway.VisualScripting;
using Fusion;
using Moon.Arena;
using TMPro;
using UnityEngine;

namespace Moon.MultiPlay
{
	[RequireComponent(typeof(CustomEventHandler))]
	public class PlayerEntry : MonoBehaviour
	{
		private const string ForceToggleOn = "ForceToggleOn";

		private const string ForceToggleOff = "ForceToggleOff";

		[SerializeField]
		private TMP_Text _textPlayerName;

		[SerializeField]
		private TMP_Text _textPlayerNo;

		[SerializeField]
		private GameObject _btnColor;

		[SerializeField]
		private GameObject _btnVoice;

		[SerializeField]
		private GameObject _btnMic;

		[SerializeField]
		private GameObject _btnKick;

		[SerializeField]
		private GameObject _btnPlayerNoUp;

		[SerializeField]
		private GameObject _btnPlayerNoDown;

		[SerializeField]
		private GameObject _iconMasterClient;

		private PlayerRef _playerRef;

		private bool _shouldShowColorButton;

		private bool _shouldShowPlayerNoButtons;

		public event Action<PlayerRef, bool> RequestToggleVoice
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

		public event Action<PlayerRef, bool> RequestChangeColor
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

		public event Action<PlayerRef, bool> RequestChangePlayerNo
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

		public event Action<PlayerRef, bool> RequestToggleMic
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

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void SetPlayerRef(PlayerRef playerRef)
		{
		}

		public void SetMasterClient(bool isMasterClient)
		{
		}

		public void SetPlayerName(string playerName)
		{
		}

		public void SetPlayerNo(int playerNo)
		{
		}

		public void SetPlayerColor(TeamNo teamNo)
		{
		}

		public void SetPlayerVoiceState(bool isRecorder, bool voiceOn)
		{
		}

		public void ShowColorButton(bool show)
		{
		}

		public void ShowPlayerNoButtons(bool show)
		{
		}

		public void ShowKickButton(bool show)
		{
		}

		public void ToggleReadyToPlayUI(bool isReady, TeamNo teamNo)
		{
		}

		private Color GetTeamBoardColor(TeamNo teamNo)
		{
			return default(Color);
		}

		private void HandleToggleChanged(GameObject toggle)
		{
		}

		private void HandleButtonPressed(string btnName)
		{
		}
	}
}
