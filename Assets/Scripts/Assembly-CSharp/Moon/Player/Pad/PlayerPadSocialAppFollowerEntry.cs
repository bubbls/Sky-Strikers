using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace Moon.Player.Pad
{
	public class PlayerPadSocialAppFollowerEntry : PlayerPadSocialAppBaseEntry
	{
		[SerializeField]
		private TMP_Text _playerNameText;

		[SerializeField]
		private UIInputKeyboardButton _followButton;

		[SerializeField]
		private GameObject _followedState;

		[SerializeField]
		private GameObject _mutualFollowState;

		public event Action<PlayerPadSocialAppFollowerEntry> OnFollowPlayerButtonPressed
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

		public void UpdateSocialState(bool isFollowing)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnFollowButtonPressed()
		{
		}

		public void SetState(SocialState state)
		{
		}
	}
}
