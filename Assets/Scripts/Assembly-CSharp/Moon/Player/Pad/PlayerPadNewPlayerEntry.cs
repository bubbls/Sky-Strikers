using Moon.Arena;
using Moon.ReportingSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Player.Pad
{
	public class PlayerPadNewPlayerEntry : NewPlayerEntryBase
	{
		private const string VisualKeyOnLevel1 = "on_level_1";

		private const string VisualKeyOnLevel2 = "on_level_2";

		private const string VisualKeyOnLevel3 = "on_level_3";

		private const string VisualKeyOn = "on";

		private const string VisualKeyOff = "off";

		[SerializeField]
		private RectTransform _rectTransform;

		[SerializeField]
		private GameObject _container;

		[SerializeField]
		private TMP_Text _textRtt;

		[SerializeField]
		private TMP_Text _textPlayerName;

		[SerializeField]
		private TMP_Text _textPlayerNo;

		[SerializeField]
		private UIButton _btnNumUp;

		[SerializeField]
		private UIButton _btnNumDown;

		[SerializeField]
		private LayoutGroup _layoutGroup;

		[SerializeField]
		private UIButton _btnTeam;

		private KeyIndexedVisual[] _teamIcons;

		[SerializeField]
		private UIButton _btnMyVoice;

		private KeyIndexedVisual _myVoiceIcon;

		[SerializeField]
		private UIButton _btnOthersVoice;

		private KeyIndexedVisual _othersVoiceIcon;

		[SerializeField]
		private UIInputKeyboardButton _btnExpandMenu;

		[SerializeField]
		private UIInputKeyboardButton _btnFollowPlayer;

		[SerializeField]
		private GameObject _followingState;

		[SerializeField]
		private GameObject _mutualFollowState;

		[SerializeField]
		private UIButton _btnReport;

		[SerializeField]
		private UIButton _btnBackToMainMenu;

		[SerializeField]
		private PlayerPadSocialReportContextMenu _reportContextMenu;

		[SerializeField]
		private GameObject _mainExpandMenu;

		[SerializeField]
		private GameObject _reportMenu;

		[SerializeField]
		private SpeakerVisualizer _speakerVisualizer;

		private int _cachedPlayerNo;

		private SocialService _socialService;

		private string _playFabId;

		private bool _isRequestingFollowPlayer;

		private bool IsVisible => false;

		protected override void InitializeInternal()
		{
		}

		private void HandleOnBackToMainMenuButtonPressed()
		{
		}

		private void HandleFollowPlayerButtonPressed()
		{
		}

		private void FollowPlayer()
		{
		}

		private void HandleOnReportButtonPressed()
		{
		}

		private void OnEnable()
		{
		}

		private void HandleRequestReport(BadBehaviour badBehaviour)
		{
		}

		private void HandleExpandMenuButtonPressed()
		{
		}

		private void HandleTeamButtonPressed()
		{
		}

		public override void SetVisible(bool visible)
		{
		}

		private void TunePlayerNo(bool isUp)
		{
		}

		private Color GetPlayerNameColor(TeamNo teamNo)
		{
			return default(Color);
		}

		protected override void UpdatePlayerInfoInternal()
		{
		}

		public override void UpdateRtt(int rtt)
		{
		}

		private void UpdateSpeakerStatus()
		{
		}

		public override void ToggleReportContextMenu(bool show)
		{
		}

		private void ToggleExpandMenuButtonRotation(bool canExpand)
		{
		}

		private void BtnNumDown_OnButtonPressed()
		{
		}

		private void BtnNumUp_OnButtonPressed()
		{
		}

		private void HandleMyVoiceButtonPressed()
		{
		}

		private void HandleOthersVoiceButtonPressed()
		{
		}

		protected override void SetMicEnabledInternal(bool micEnabled)
		{
		}

		protected override void SetSpeakerVolumeInternal(MPlayer.PlayerSpeakerVolume volume)
		{
		}

		public void Reset()
		{
		}
	}
}
