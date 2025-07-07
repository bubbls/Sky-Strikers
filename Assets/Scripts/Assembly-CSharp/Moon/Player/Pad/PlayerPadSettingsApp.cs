using System;
using System.Runtime.CompilerServices;
using Moon.Arena;
using Moon.ReportingSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Player.Pad
{
	public class PlayerPadSettingsApp : PlayerPadApp, IScrollablePlayerPadApp
	{
		private const string VisualKeyOn = "on";

		private const string VisualKeyOff = "off";

		private const string VisualKeyEveryone = "everyone";

		private const string VisualKeyMutualFollowing = "mutualfollowing";

		private const string VisualKeyNoOne = "noone";

		[SerializeField]
		private ScrollRect _scrollRect;

		[SerializeField]
		private UIButton _btnSpeedLines;

		private KeyIndexedVisual _speedLinesIcon;

		[SerializeField]
		private UIButton _btnBatSwitcheroo;

		private KeyIndexedVisual _batSwitcherooIcon;

		[SerializeField]
		private UIButton _btnPlayerNameOnHead;

		private KeyIndexedVisual _playerNameOnHeadIcon;

		[SerializeField]
		private UIButton _btnPadNotifications;

		private KeyIndexedVisual _padNotificationsIcon;

		[SerializeField]
		private UIButton _btnSocialPrivacyState;

		private KeyIndexedVisual _socialPrivacyStateIcon;

		[SerializeField]
		private UIButton _btnSoundOptions;

		[SerializeField]
		private UIButton _btnTurningOptions;

		[SerializeField]
		private PlayerPadAppSubView[] _subViews;

		public override PlayerPadAppID AppID => default(PlayerPadAppID);

		public ScrollRect ScrollRect => null;

		public event Action<ScrollRect> OnRequestRegisterScrollRect
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

		public event Action<ScrollRect> OnRequestUnRegisterScrollRect
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

		protected override void InitializeInternal()
		{
		}

		private void SubView_OnViewClosed()
		{
		}

		protected override void HandleAppAboutToOpenInternal(IPlayerPadAppOpenData appOpenData)
		{
		}

		protected override void HandleAppOpenCompleteInternal()
		{
		}

		protected override void HandleAppAboutToCloseInternal()
		{
		}

		private void UpdateOptions()
		{
		}

		private void HandleBatSwitcherooButtonPressed()
		{
		}

		private void HandleSpeedLinesButtonPressed()
		{
		}

		private void HandleSoundOptionsButtonPressed()
		{
		}

		private void HandleTurningOptionsButtonPressed()
		{
		}

		private void HandlePlayerNameOnHeadButtonPressed()
		{
		}

		private void HandlePadNotificationsButtonPressed()
		{
		}

		private void SetToggleOption(ref bool option, KeyIndexedVisual icon)
		{
		}

		private void HandleSocialPrivacyStateButtonPressed()
		{
		}

		private void UpdateSocialPrivacyStateVisual(GameOption.SocialPrivacyState socialPrivacyState)
		{
		}

		private void ShowSubView<T>() where T : PlayerPadAppSubView
		{
		}
	}
}
