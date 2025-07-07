using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Player.Pad
{
	public class PlayerPadSocialAppTabController : MonoBehaviour
	{
		private enum TabPage : byte
		{
			None = 0,
			FollowingPlayersPage = 1,
			FollowersPage = 2
		}

		[Header("FollowingPage")]
		[SerializeField]
		private PlayerPadSocialAppBasePage _followingPlayersPage;

		[Header("FollowersPage")]
		[SerializeField]
		private PlayerPadSocialAppBasePage _followersPage;

		public ScrollRect CurrentScrollRect { get; private set; }

		private TabPage CurrentTabPage { get; set; }

		public event Action<ScrollRect, ScrollRect> OnSwitchScrollRect
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

		public event Action<bool> OnTogglePopupOnTop
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

		public void Initialize(SocialService socialService)
		{
		}

		public void ToggleTabPage(bool enable)
		{
		}

		public void SetDefaultState()
		{
		}

		private void OnEnable()
		{
		}

		private void HandleOnFollowedPlayer()
		{
		}

		private void HandleOnToggleUnfollowPopup(bool isShowing)
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnShowFollowingPlayersPage()
		{
		}

		private void HandleOnShowFollowersPage()
		{
		}

		private void ShowFollowingPlayersPage()
		{
		}

		private void ShowFollowersPage()
		{
		}

		public void UpdateFollowingPlayersTabButtonText()
		{
		}
	}
}
