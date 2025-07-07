using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace Moon.Player.Pad
{
	public class PlayerPadSocialAppSearchEntry : PlayerPadSocialAppBaseEntry
	{
		[SerializeField]
		private TMP_Text _playerNameText;

		[SerializeField]
		private UIButton _followPlayerButton;

		[SerializeField]
		private GameObject _alreadyRequestedState;

		[SerializeField]
		private GameObject _alreadyFriendState;

		public event Action<PlayerPadSocialAppSearchEntry> OnFollowPlayerButtonPressed
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

		public void UpdateData(SearchPlayerEntry searchPlayerEntry, bool isFollowing, bool isFollower)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnFollowPlayerButtonPressed()
		{
		}

		public void SetState(SocialState socialState)
		{
		}
	}
}
