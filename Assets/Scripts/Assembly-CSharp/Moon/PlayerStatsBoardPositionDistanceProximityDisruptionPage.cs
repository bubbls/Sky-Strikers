using SVGImporter;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace Moon
{
	public class PlayerStatsBoardPositionDistanceProximityDisruptionPage : PlayerStatsBoardPage
	{
		[SerializeField]
		[Header("Positioning")]
		private TMP_Text _percentageDefensiveText;

		[SerializeField]
		private SVGImage _defensiveSVGImage;

		[SerializeField]
		private TMP_Text _percentageMiddleText;

		[SerializeField]
		private SVGImage _middleSVGImage;

		[SerializeField]
		private TMP_Text _percentageOffensiveText;

		[SerializeField]
		private SVGImage _offensiveSVGImage;

		[SerializeField]
		private TMP_Text _avgTimeMostAggressiveText;

		[SerializeField]
		private TMP_Text _avgTimeMostDefensiveText;

		[SerializeField]
		[Header("Field Distance")]
		private TMP_Text _avgDistBallText;

		[SerializeField]
		private TMP_Text _avgDistBallPossessionText;

		[SerializeField]
		private TMP_Text _avgDistBallNoPossessionText;

		[SerializeField]
		private TMP_Text _avgDistBallDistTeamText;

		[SerializeField]
		[Header("Ball Proximity")]
		private TMP_Text _avgTimeBehindBallText;

		[SerializeField]
		private TMP_Text _avgTimeFrontBallText;

		[SerializeField]
		private TMP_Text _avgTimeClosestBallText;

		[SerializeField]
		private TMP_Text _avgTimeFarthestBallText;

		[FormerlySerializedAs("_avgTimeDisplacedOneText")]
		[SerializeField]
		[Header("Disruption")]
		private TMP_Text _avgTimeDisplaceDoneText;

		[SerializeField]
		private TMP_Text _avgTimeDisplaceReceivedText;

		public override void UpdatePageData(PlayerSuitClass suitClass)
		{
		}
	}
}
