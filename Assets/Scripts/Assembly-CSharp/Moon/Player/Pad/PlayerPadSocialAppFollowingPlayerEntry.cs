using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace Moon.Player.Pad
{
	public class PlayerPadSocialAppFollowingPlayerEntry : PlayerPadSocialAppBaseEntry
	{
		[SerializeField]
		private TMP_Text _playerName;

		[SerializeField]
		private TMP_Text _playerOnlineStateText;

		[SerializeField]
		private Color _onlineColor;

		[SerializeField]
		private Color _offlineColor;

		[SerializeField]
		private UIInputKeyboardButton _unfollowButton;

		private const string ArenaDefaultDisplayName = "Custom Arena:";

		private const string HubDisplayName = "Hub:";

		private const string ArenaDefaultRankedDisplayName = "Ranked Match";

		public bool IsOnline { get; private set; }

		public event Action<string> OnUnfollowButtonPressed
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

		public void UpdateData(string playFabId, string playerName)
		{
		}

		public void UpdatePlayerOnlineState(bool isOnline, string fieldType = "", string sessionCode = "")
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnUnfollowButtonPressed()
		{
		}

		private string ConvertToDisplayFieldType(string fieldType, string sessionCode = "")
		{
			return null;
		}
	}
}
