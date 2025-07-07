using Moon.ReportingSystem;
using UnityEngine;

namespace Moon.Player.Pad
{
	public class PlayerPadSettingsTurningOptionsPage : PlayerPadAppSubView
	{
		private const string VisualKeyOn = "on";

		private const string VisualKeyOff = "off";

		[SerializeField]
		private UIButton _btnOff;

		private KeyIndexedVisual _btnOffVisual;

		[SerializeField]
		private SettingsTurningOptionsGroupSnapTurn _snapTurnGroup;

		[SerializeField]
		private SettingsTurningOptionsGroupSmoothTurn _smoothTurnGroup;

		protected override void InitializeInternal()
		{
		}

		protected override void ShowViewInternal()
		{
		}

		protected override void HideViewInternal()
		{
		}

		private void BtnOff_OnButtonPressed()
		{
		}

		private void SnapTurnGroup_OnMainButtonPressed()
		{
		}

		private void SmoothTurnGroup_OnMainButtonPressed()
		{
		}

		private void SmoothTurnGroup_OnOptionSelected(int optionIndex)
		{
		}

		private void SnapTurnGroup_OnOptionSelected(int optionIndex)
		{
		}

		private void EnableSmoothTurn(int turnSpeed)
		{
		}

		private void EnableSnapTurn(int turnAngle)
		{
		}

		private void SelectOffButton()
		{
		}

		private void ToggleOffButtonVisual(bool selected)
		{
		}
	}
}
