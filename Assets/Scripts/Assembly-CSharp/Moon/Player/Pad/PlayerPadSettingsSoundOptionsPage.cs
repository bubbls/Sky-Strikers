using Moon.Arena;
using Moon.ReportingSystem;
using UnityEngine;

namespace Moon.Player.Pad
{
	public class PlayerPadSettingsSoundOptionsPage : PlayerPadAppSubView
	{
		private const string VisualKeyOff = "off";

		private const string VisualKeyOnLevel1 = "on_level_1";

		private const string VisualKeyOnLevel2 = "on_level_2";

		private const string VisualKeyOnLevel3 = "on_level_3";

		[SerializeField]
		private UIButton _btnMusic;

		private KeyIndexedVisual _musicIcon;

		[SerializeField]
		private UIButton _btnVFX;

		private KeyIndexedVisual _vfxIcon;

		[SerializeField]
		private UIButton _btnCrowd;

		private KeyIndexedVisual _crowdIcon;

		protected override void InitializeInternal()
		{
		}

		protected override void ShowViewInternal()
		{
		}

		protected override void HideViewInternal()
		{
		}

		private void UpdateOptions()
		{
		}

		private void HandleMusicButtonPressed()
		{
		}

		private void HandleVFXButtonPressed()
		{
		}

		private void HandleCrowdButtonPressed()
		{
		}

		private void UpdateIconVisual(GameOption.Volume volume, ref KeyIndexedVisual icon)
		{
		}
	}
}
