using Moon.Arena;
using Moon.Hub;
using UnityEngine;

namespace Moon.ReportingSystem
{
	public class OptionsConsole : MonoBehaviour
	{
		private const string VisualKeyOn = "on";

		private const string VisualKeyOff = "off";

		private const string VisualKeyOnLevel1 = "on_level_1";

		private const string VisualKeyOnLevel2 = "on_level_2";

		private const string VisualKeyOnLevel3 = "on_level_3";

		[SerializeField]
		private ManualButton _btnMusic;

		private KeyIndexedVisual _musicIcon;

		[SerializeField]
		private ManualButton _btnVFX;

		private KeyIndexedVisual _vfxIcon;

		[SerializeField]
		private ManualButton _btnSnapTurn;

		private KeyIndexedVisual _snapTurnIcon;

		[SerializeField]
		private ManualButton _btnSpeedLines;

		private KeyIndexedVisual _speedLinesIcon;

		[SerializeField]
		private ManualButton _btnBatSwitcheroo;

		private KeyIndexedVisual _batSwitcherooIcon;

		[SerializeField]
		private ManualButton _btnPlayerNameOnHead;

		private KeyIndexedVisual _playerNameOnHeadIcon;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void UpdateOptions()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleBatSwitcherooButtonPressed()
		{
		}

		private void HandleSpeedLinesButtonPressed()
		{
		}

		private void HandlePlayerNameOnHeadButtonPressed()
		{
		}

		private void SetToggleOption(ref bool option, KeyIndexedVisual icon)
		{
		}

		private void HandleMusicButtonPressed()
		{
		}

		private void HandleVFXButtonPressed()
		{
		}

		private void UpdateMusicVisual(GameOption.Volume volume)
		{
		}

		private void UpdateVFXVisual(GameOption.Volume volume)
		{
		}
	}
}
