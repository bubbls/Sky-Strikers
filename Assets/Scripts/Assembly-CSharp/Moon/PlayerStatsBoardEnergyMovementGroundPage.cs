using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Moon
{
	public class PlayerStatsBoardEnergyMovementGroundPage : PlayerStatsBoardPage
	{
		[SerializeField]
		[Header("Energy")]
		private TMP_Text _avgEPMText;

		[SerializeField]
		private TMP_Text _avgECPMText;

		[SerializeField]
		private TMP_Text _avgESPMText;

		[SerializeField]
		private TMP_Text _totalEnergyText;

		[SerializeField]
		private TMP_Text _avgESMALLText;

		[SerializeField]
		private TMP_Text _avgEMIDText;

		[SerializeField]
		private TMP_Text _avgEBIGText;

		[SerializeField]
		[Header("Movement")]
		private TMP_Text _avgSpeedText;

		[SerializeField]
		private TMP_Text _avgDistanceText;

		[SerializeField]
		private TMP_Text _totalDistanceText;

		[SerializeField]
		[Header("Ground/Air")]
		private Image _onGroundFillImage;

		[SerializeField]
		private TMP_Text _avgTimeOnGroundText;

		[SerializeField]
		private TMP_Text _percentageOnGroundText;

		[SerializeField]
		private Image _lowAirFillImage;

		[SerializeField]
		private TMP_Text _avgTimeLowAirText;

		[SerializeField]
		private TMP_Text _percentageLowAirText;

		[SerializeField]
		private Image _highAirFillImage;

		[SerializeField]
		private TMP_Text _avgTimeHighAirText;

		[SerializeField]
		private TMP_Text _percentageHighAirText;

		public override void UpdatePageData(PlayerSuitClass suitClass)
		{
		}
	}
}
